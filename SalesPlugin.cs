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
        private static int sale_count;
        private static int gil;
        private readonly Regex gil_regex = new Regex(@"The (\d*) (.*) you put up for sale in the (.*) markets have sold for (\d*,*\d*,*\d*) gil .*", RegexOptions.Compiled); 

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
                    sale_count++;
                    Logger.Info("Market Board sale made.");
                    Logger.Verbose($"Cool Sales Message: " + e.ChatLogEntry.Contents);

                    var matches = gil_regex.Match(e.ChatLogEntry.Contents);
                    if (matches.Success)
                    {
                        var groups = matches.Groups;
                        var amount = int.Parse(groups[0].ToString().Replace(",", ""));
                        Logger.Verbose($"Received {amount:n0} from the sale. Adding to total...");

                        gil += amount;

                        Logger.Info($"You have made {sale_count} sales, and {gil:n0} since starting the bot.");

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
            Logger.Info($"Items sold: {sale_count:n0}");
            Logger.Info($"Gil obtained: {gil:n0}");
            Logger.Info("*~*~*~*~*~*~*~*~*~*~");
        }

    }
}
