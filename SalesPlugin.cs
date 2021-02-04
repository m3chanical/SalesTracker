using ff14bot.AClasses;
using ff14bot.Enums;
using ff14bot.Managers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ff14bot;
using ff14bot.Objects;
using Newtonsoft.Json;

namespace SalesTracker
{
    public class SalesPlugin : BotPlugin
    {
        private int _saleCount;
        private int _gil;
        private readonly Regex _mbRegex = new Regex(@"The (\d{0,3}).+sold for ([\d,]+) gil", RegexOptions.Compiled); 
        private SettingsForm _form;

        public override string Author => "Sinbeard";

        public override string Name => "Market Board Sales Tracker";

        public override Version Version => new Version(1, 1, 0);
        public override bool WantButton => true;
        public override string ButtonText => "Log Report";

        public override void OnButtonPress() 
        {
            if (_form == null)
            {
                _form = new SettingsForm()
                {
                    Text = $"RB Statistics v{Version} {Core.Me.Name}",
                    
                };
                _form.Closed += (o, e) => { _form = null; };
            }
            try
            {
                _form.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public override void OnInitialize()
        {
            Logger.Info("Initializing Sales Tracker Plugin");
        }

        public override void OnEnabled()
        {
            GamelogManager.MessageRecevied += GamelogManager_MessageRecevied;
        }
        public override void OnDisabled() 
        {
            GamelogManager.MessageRecevied -= GamelogManager_MessageRecevied;
        }

        private void GamelogManager_MessageRecevied(object sender, ChatEventArgs e) 
        {
            switch(e.ChatLogEntry.MessageType)
            {
                case MessageType.RetainerSaleReports:
                    Logger.Info("Market Board sale made.");

                    var match = _mbRegex.Match(e.ChatLogEntry.Contents);
                    if (match.Success)
                    {
                        _saleCount++;
                        Sale sale = new Sale();
                        var groups = match.Groups;

                        sale.SalesDateTime = DateTime.Now;
                        sale.AmountSold = groups[1].ToString() != "" ? int.Parse(groups[1].ToString()) : 1;
                        
                        Item item = GetItemFromBytes(e.ChatLogEntry.Bytes);
                        if (item != null)
                        {
                            sale.ItemSold = item.CurrentLocaleName;
                            sale.ItemId = item.Id;
                            sale.SoldPrice = int.Parse(groups[2].ToString().Replace(",", ""));
                            _gil += sale.SoldPrice;

                            Logger.Info($"{sale.AmountSold} x {sale.ItemSold} (Item ID: {sale.ItemId}) sold for {sale.SoldPrice:n0}\n");
                            Logger.Info($"You have made {_saleCount} sales, and {_gil:n0} since starting the bot.");

                            SalesSettings.Instance.Sales.Add(sale); 
                        }
                        else
                        {
                            Logger.Error("Could not find item with ");
                        }
                        
                    }
                    break;
                case MessageType.Tell_Receive:
                    Logger.Info($"Tell received from {e.ChatLogEntry.SenderDisplayName}.");
                    Logger.Info($"Tell text: {e.ChatLogEntry.Contents}");
                    break;
            }      
        }

        private Item GetItemFromBytes(IReadOnlyList<byte> itemBytes)
        {
            List<byte> newBytes = new List<byte>();
            bool HQ = false;
            for (var x = 0; x < itemBytes.Count(); x++) {
                switch (itemBytes[x]) {
                    case 2:
                        // special in-game replacements/wrappers
                        // 2 46 5 7 242 2 210 3
                        // 2 29 1 3
                        // remove them
                        if (itemBytes[x + 1] == 0x27 && itemBytes[x + 3] == 0x03) {
                            var length = itemBytes[x + 2];
                            newBytes.AddRange(itemBytes.Skip(x + 5).Take(length - 5));
                        }
                        break;
                }
            }
            var result = "";
            foreach (var b in newBytes) {
                result += $"{b:X}";
            }

            uint itemId = (uint) int.Parse(result, NumberStyles.HexNumber);
            if (itemId > 1000000)
            {
                itemId -= 1000000;
                HQ = true;
            }
            
            return DataManager.GetItem(itemId, HQ);
        }
    }
}
