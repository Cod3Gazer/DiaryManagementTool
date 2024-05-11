namespace DataAccessLayer
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public DateTime DairyDate { get; set; }
        public required string DairyVoucherNumber { get; set; }
        public TimeSpan DairyTime { get; set; }
        public DateTime Date { get; set; }
        public required string PartyName { get; set; }
        public decimal Amount { get; set; }
        public required string PaymentMode { get; set; }
        public required string Remarks { get; set; }
        public int CustomerId { get; set; }
        public required Customer Customer { get; set; }
    }
}
