using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMS.Data.Layer.Entities
{
    public class Transaction
    {
        public int Id { get; set; } 

        public decimal Amount { get; set; }
        
        public int TierId { get; set; } 

        public Tier Tier { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public DateTime Date { get; set; }

        public int TransactionTypeId { get; set; }  

        public TransactionType TransactionType { get; set; }    

        public ICollection<Deposit> Deposits { get; set; }   
    }

    public enum PaymentMethod
    {
        Cash,
        Check
    }
}
