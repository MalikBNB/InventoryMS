using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMS.Data.Layer.Entities
{
    public class OrderItems
    {
        public int Id { get; set; } 

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int ProductId { get; set; }  

        public Product Product { get; set; }

        public string Quantity { get; set; }    

        public decimal Price_HT { get; set; }  

        public float TVA { get; set; }  

        public float Discount { get; set; } 

        public decimal TotalPrice { get; set; }
    }
}
