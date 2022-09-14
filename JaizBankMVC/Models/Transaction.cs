using JaizBankMVC.Enum;

namespace JaizBankMVC.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }

        //Merchant
        public string? MerchantName { get; set; }
        public string? Location { get; set; }
        public int TerminalID { get; set; }


        //Purchase
        public int STAN { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public string? Amount { get; set; }
        public string? DebitCardNo { get; set; }
        public string? ExpiryDate { get; set; }
        public int AuthorizationCode { get; set; }
        public string? Offline { get; set; }

        //Transaction Declined
        public int ResponseCode { get; set; }
        public string? AID { get; set; }
        public string? RRN { get; set; }

        public string? Accelerex { get; set; }

        public string? PTAD { get; set; }
    }
}
