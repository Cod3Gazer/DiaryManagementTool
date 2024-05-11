using System;

namespace DataAccessLayer
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public DateTime DairyDate { get; set; }
        public string DairyVoucherNumber { get; set; }
        public TimeSpan DairyTime { get; set; }
        public DateTime Date { get; set; }
        public string PartyName { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMode { get; set; }
        public string Remarks { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
