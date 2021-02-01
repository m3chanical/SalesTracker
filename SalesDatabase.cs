using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTracker
{
    public class SalesDatabase
    {
        public List<Sale> Sales { get; set; }
    }
    public class Sale
    {
        public DateTime SalesDateTime { get; set; }
        public int AmountSold { get; set; }
        public string ItemSold { get; set; }
        public int SoldPrice { get; set; }
        public string MarketSold { get; set; }
    }
}
