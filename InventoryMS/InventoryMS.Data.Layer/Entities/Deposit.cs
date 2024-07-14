namespace InventoryMS.Data.Layer.Entities
{
    public class Deposit
    {
        public int Id { get; set; }

        public int OrderId { get; set; }    

        public Order Order { get; set; }

        public int TransactionId { get; set; }  

        public Transaction Transaction { get; set; }

        public decimal Slice { get; set; }  
    }
}
