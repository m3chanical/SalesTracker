using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ff14bot.Helpers;

namespace SalesTracker
{
    public class SalesSettings : JsonSettings
    {
        public SalesSettings() : base(Path.Combine(CharacterSettingsDirectory, "MarketBoardSales.json"))
        {
        }
    }
}
