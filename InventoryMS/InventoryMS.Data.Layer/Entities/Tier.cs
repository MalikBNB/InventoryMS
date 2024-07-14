using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMS.Data.Layer.Entities
{
    public class Tier
    {
        public int Id { get; set; }

        public int Code { get; set; }

        public string Reference { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Email { get; set; }

        public TierType TierType {  get; set; } 

        public byte[] Image { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

    }

    public enum TierType
    {
        Client,
        Supplier
    }
}
