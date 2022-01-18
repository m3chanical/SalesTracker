using System;
using System.ComponentModel;

namespace SalesTracker
{
    public class Sale: IEquatable<Sale>
    {
        public DateTime SalesDateTime { get; set; }
        public int AmountSold { get; set; }
        public string ItemSold { get; set; }
        public uint ItemId { get; set; }
        public int SoldPrice { get; set; }
        
        [Browsable(false)]
        public int ByteHashCode { get; set; }
        public override string ToString() {
            return
                $"[{SalesDateTime}]\t{ItemSold} (Id: {ItemId}) Amount: {AmountSold} Gil: {SoldPrice:n0}";
        }

        bool IEquatable<Sale>.Equals(Sale other)
        {
            return SoldPrice == other.SoldPrice && ByteHashCode == other.ByteHashCode;
        }

        public bool Equals(Sale other)
        {
            return SoldPrice == other.SoldPrice && ByteHashCode == other.ByteHashCode;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Sale) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (SoldPrice * 397) ^ ByteHashCode;
            }
        }
    }
}