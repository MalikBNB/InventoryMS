using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMS.Data.Layer.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string Reference { get; set; }   

        public int TierId { get; set; } 

        public Tier Tier { get; set; }

        public int OrderTypeId { get; set; }

        public OrderType OrderType { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal Total_HT { get; set; }    

        public decimal Total_TVA { get; set; } 
        
        public decimal Total_TTC { get; set; }

        public bool Status { get; set; }    

        public ICollection<OrderItems> Items { get; set; }

        public ICollection<Deposit> Deposits { get; set; }

    }
}
