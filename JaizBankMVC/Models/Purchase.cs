namespace JaizBankMVC.Models
{
    public class Purchase
    {
        public int STAN { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public decimal Amount { get; set; }
        public Transaction Transaction { get; set; }
    }
}
