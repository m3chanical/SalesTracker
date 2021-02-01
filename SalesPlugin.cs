using ff14bot.AClasses;
using ff14bot.Enums;
using ff14bot.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTracker
{
    public class SalesPlugin : BotPlugin
    {
        private static int _saleCount;
        private static int _gil;
        private readonly Regex _mbRegex = new Regex(@"The (\d*)(.*) you put up for sale in the (.*) markets .* sold for (.*) gil .*", RegexOptions.Compiled); 

        public override string Author => "Sinbeard";

        public override string Name => "Market Board Sales Tracker";

        public override Version Version => new Version(1, 2, 0);
        public override bool WantButton => true;
        public override string ButtonText => "Log Report";

        public override void OnButtonPress() 
        {
            // output chat log with sales
            report_gil();

            try
            {
                var form = new SettingsForm();
                form.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public override void OnInitialize()
        {
            
        }

        public override void OnEnabled()
        {
            GamelogManager.MessageRecevied += GamelogManager_MessageRecevied;
            // load settings? 
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
                        _saleCount++;
                        var groups = match.Groups;

                        var amount = groups[1].ToString() != "" ? int.Parse(groups[1].ToString()) : 1;
                        var item = groups[2].ToString();
                        var price = int.Parse(groups[4].ToString().Replace(",", ""));
                        _gil += price;
                        var market = groups[3].ToString();

                        Logger.Info($"{amount} x {item} sold for {price:n0} on {market}\n");
                        Logger.Info($"You have made {_saleCount} sales, and {_gil:n0} since starting the bot.");
                        
                        report_gil();
                    }
                    break;
                case MessageType.Tell_Receive:
                    Logger.Info("HOLY SHIT YOU RECEIVED A TELL.");
                    break;
                default:
                    break;
            }      
        }

        private void report_gil() 
        {
            Logger.Info("*~*~*~*~*~*~*~*~*~*~");
            Logger.Info($"Items sold: {_saleCount:n0}");
            Logger.Info($"Gil obtained: {_gil:n0}");
            Logger.Info("*~*~*~*~*~*~*~*~*~*~");
        }

    }
}
