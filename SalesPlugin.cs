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
using Newtonsoft.Json;

namespace SalesTracker
{
    public class SalesPlugin : BotPlugin
    {
        public int SaleCount { get; set; }
        private readonly Regex _mbRegex = new Regex(@"The (\d*)(.*) you put up for sale in the (.*) markets .* sold for (.*) gil .*", RegexOptions.Compiled); 
        private SettingsForm _form;
        public static SalesDatabase Database = new SalesDatabase();

        public override string Author => "Sinbeard";

        public override string Name => "Market Board Sales Tracker";

        public override Version Version => new Version(1, 6, 5);
        public override bool WantButton => true;
        public override string ButtonText => "Log Report";

        public override void OnButtonPress() 
        {
            if (_form == null)
            {
                _form = new SettingsForm()
                {
                    Text = "RB Statistics v" + Version,
                    
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
            //Database = JsonConvert.DeserializeObject<SalesDatabase>(File.ReadAllText(@"Plugins\SalesTracker\sales.json"));
        }

        public override void OnEnabled()
        {
            GamelogManager.MessageRecevied += GamelogManager_MessageRecevied;
            // load settings? json file... look in settings folder. 
            // todo: don't forget to save...
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
                    Logger.Verbose($"Cool Sales Message: " + e.ChatLogEntry.Contents);

                    var match = _mbRegex.Match(e.ChatLogEntry.Contents);
                    if (match.Success)
                    {
                        SaleCount++;
                        SalesSettings.Sale sale = new SalesSettings.Sale();
                        var groups = match.Groups;

                        sale.SalesDateTime = DateTime.Now;
                        sale.AmountSold = groups[1].ToString() != "" ? int.Parse(groups[1].ToString()) : 1;
                        Item item = GetItemFromBytes(e.ChatLogEntry.Bytes);
                        sale.ItemSold = item == null ? groups[2].ToString() : item.CurrentLocaleName;
                        sale.ItemId = item?.Id ?? 0;
                        sale.SoldPrice = int.Parse(groups[4].ToString().Replace(",", ""));
                        sale.MarketSold = groups[3].ToString();

                        SalesSettings.Instance.Sales.Add(sale); // ???

                        if (_form != null)
                        {
                            _form.Gil += sale.SoldPrice;
                            _form.Sales++;

                            Logger.Info(
                                $"{sale.AmountSold} x {sale.ItemSold}:{sale.ItemId} sold for {sale.SoldPrice:n0} on {sale.MarketSold} market\n");
                            Logger.Info($"You have made {SaleCount} sales, and {_form.Gil:n0} since starting the bot.");
                        }
                    }
                    break;
                case MessageType.Tell_Receive:
                    Logger.Info("Tell received.");
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

            Item item = DataManager.GetItem(itemId, HQ);
            return item;
        }
    }
}
