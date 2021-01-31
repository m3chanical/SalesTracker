using ff14bot.AClasses;
using ff14bot.Enums;
using ff14bot.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SalesTracker
{
    public class SalesPlugin : BotPlugin
    {
        private static int sale_count = 0;
        private static int gil = 0;
        private Regex gil_regex = new Regex(@"\b(\d*,*\d*,*\d{1,3})\b", RegexOptions.Compiled); // matches any number from 1 to 999,999,999 w/ commas

        public override string Author => "Sinbeard";

        public override string Name => "Market Board Sales Tracker";

        public override Version Version => new Version(0, 1, 0);
        public override bool WantButton => true;
        public override string ButtonText => "Log Report";

        public override void OnButtonPress() 
        {
            // output chat log with sales
            Logger.Info($"You have made {sale_count} sales and {gil} gil.");
        }

        public override void OnInitialize()
        {
            
        }

        public override void OnEnabled()
        {
            GamelogManager.MessageRecevied += GamelogManager_MessageRecevied;
        }

        private void GamelogManager_MessageRecevied(object sender, ChatEventArgs e) 
        {
            switch(e.ChatLogEntry.MessageType)
            {
                case MessageType.RetainerSaleReports:
                    sale_count++;
                    Logger.Info("You made a sale! Wow. Cool.");
                    Logger.Verbose($"Cool Sales Message: " + e.ChatLogEntry.Contents);

                    var groups = gil_regex.Match(e.ChatLogEntry.Contents).Groups;
                    if (groups.Count != 0) {
                        var amount = int.Parse(groups[0].ToString().Replace(",", ""));
                        Logger.Verbose($"Received {amount:n0} from the sale. Adding to total...");

                        gil += amount;

                        Logger.Info($"You have made {sale_count} sales, and {gil:n0} since starting the bot.");
                    }
                    break;
                case MessageType.Tell_Receive:
                    Logger.Info("HOLY SHIT YOU RECEIVED A TELL.");
                    break;
                default:
                    break;
            }      
        }

        public override void OnDisabled() 
        {
            GamelogManager.MessageRecevied -= GamelogManager_MessageRecevied;
        }

    }
}
