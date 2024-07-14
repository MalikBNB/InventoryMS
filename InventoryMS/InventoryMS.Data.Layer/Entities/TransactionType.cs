using System.Collections.Generic;

namespace InventoryMS.Data.Layer.Entities
{
    public class TransactionType
    {
        public int Id { get; set; }

        public TransactionTypeCode Code { get; set; }

        public string Label { get; set; } 
        
        public bool isIn {  get; set; } 

        public ICollection<Transaction> Transactions { get; set; }

    }

    public enum TransactionTypeCode
    {
        Collection,
        Disbursement
    }
}
