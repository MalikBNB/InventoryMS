using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMS.Data.Layer.Entities
{
    public class OrderType
    {
        public int Id { get; set; }

        public OrderTypeCode Code { get; set; }

        public string Label { get; set; }

        public bool isIn { get; set; }

        public byte Sign { get; set; }  

        public ICollection<Order> Orders { get; set; }
    }

    public enum OrderTypeCode
    {
        GoodsReceipt,
        DeliveryNote,
        SaleReturnOrder,
        PurchaseReturnOrder
    }
}
