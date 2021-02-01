using ff14bot.AClasses;
using ff14bot.Enums;
using ff14bot.Managers;
using System;
using System.Collections.Generic;
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

        public override Version Version => new Version(1, 6, 0);
        public override bool WantButton => true;
        public override string ButtonText => "Log Report";

        public override void OnButtonPress() 
        {
            if (_form == null)
            {
                _form = new SettingsForm
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
            Database = JsonConvert.DeserializeObject<SalesDatabase>(File.ReadAllText(@"Plugins\SalesTracker\sales.json"));
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
                        Sale sale = new Sale();
                        var groups = match.Groups;

                        sale.SalesDateTime = DateTime.Now;
                        sale.AmountSold = groups[1].ToString() != "" ? int.Parse(groups[1].ToString()) : 1;
                        sale.ItemSold = groups[2].ToString();
                        sale.SoldPrice = int.Parse(groups[4].ToString().Replace(",", ""));
                        sale.MarketSold = groups[3].ToString();

                        Database.Sales.Add(sale);

                        _form.Gil += sale.SoldPrice;
                        _form.Sales++;
                        
                        Logger.Info($"{sale.AmountSold} x {sale.ItemSold} sold for {sale.SoldPrice:n0} on {sale.MarketSold} market\n");
                        Logger.Info($"You have made {SaleCount} sales, and {_form.Gil:n0} since starting the bot.");
                    }
                    break;
                case MessageType.Tell_Receive:
                    Logger.Info("HOLY SHIT YOU RECEIVED A TELL.");
                    break;
                default:
                    break;
            }      
        }
    }
}
