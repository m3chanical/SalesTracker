using System;

namespace SalesTracker
{
    public class Sale
    {
        public DateTime SalesDateTime { get; set; }
        public int AmountSold { get; set; }
        public string ItemSold { get; set; }
        public uint ItemId { get; set; }
        public int SoldPrice { get; set; }
        public override string ToString() {
            return
                $"[{SalesDateTime}]\t{ItemSold} (Id: {ItemId}) Amount: {AmountSold} Gil: {SoldPrice:n0}";
        }
    }
}