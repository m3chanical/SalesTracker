using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ff14bot.Helpers;
using Newtonsoft.Json;

namespace SalesTracker
{
    public class SalesSettings : JsonSettings
    {
        private static SalesSettings _instance;

        public static SalesSettings Instance => _instance ?? (_instance = new SalesSettings());
        private List<Sale> _sales = new List<Sale>();

        public SalesSettings() : base(Path.Combine(CharacterSettingsDirectory, "MarketBoardSales.json"))
        {
        }

        [Setting]
        [Description("List of recorded sales while plugin has run.")]
        [JsonProperty("Sales")]
        public List<Sale> Sales
        {
            get => _sales;
            set
            {
                if (_sales != value)
                {
                    _sales = value;
                    Save();
                }
            }
        }
    }
}
