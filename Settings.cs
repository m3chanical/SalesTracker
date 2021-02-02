using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ff14bot.Helpers;

namespace SalesTracker
{
    public class SalesSettings : JsonSettings
    {
        private static SalesSettings _instance;

        public static SalesSettings Instance => _instance ?? (_instance = new SalesSettings());
        private BindingList<Sale> _sales = new BindingList<Sale>();
        public class Sale
        {
            public DateTime SalesDateTime { get; set; }
            public int AmountSold { get; set; }
            public string ItemSold { get; set; }
            public uint ItemId { get; set; }
            public int SoldPrice { get; set; }
            public string MarketSold { get; set; }
        }

        public SalesSettings() : base(Path.Combine(CharacterSettingsDirectory, "MarketBoardSales.json"))
        {
        }

        [Setting]
        public BindingList<Sale> Sales
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
