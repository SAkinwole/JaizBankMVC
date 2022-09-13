using JaizBankMVC.Enum;

namespace JaizBankMVC.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
    }
}
