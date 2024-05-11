namespace DataAccessLayer
{
    public class Sales
    {
        public int SalesId { get; set; }
        public DateTime DairyDate { get; set; }
        public required string DairyVoucherNumber { get; set; }
        public TimeSpan DairyTime { get; set; }
        public DateTime InvoiceDate { get; set; }
        public required string InvoiceNumber { get; set; }
        public required string PartyName { get; set; }
        public decimal Amount { get; set; }
        public string? Remarks { get; set; }
        public required string FileUrl { get; set; }
        public required string SalesType { get; set; }
        public int CustomerId { get; set; }
        public required Customer Customer { get; set; }
    }
}
