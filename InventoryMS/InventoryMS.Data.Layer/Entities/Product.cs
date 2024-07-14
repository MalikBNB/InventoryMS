using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMS.Data.Layer.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public int Code { get; set; }   

        public string Reference { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public ProductCategory Category { get; set; }

        public decimal Price { get; set; }  

        public string QuantityInStock { get; set; }

        public ICollection<OrderItems> Items { get; set; }

    }
}
