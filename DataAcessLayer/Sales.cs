using System;

namespace DataAccessLayer
{
    public class Sales
    {
        public int SalesId { get; set; }
        public DateTime DairyDate { get; set; }
        public int DairyVoucherNumber { get; set; }
        public TimeSpan DairyTime { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string PartyName { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public string FileUrl { get; set; }
        public string SalesType { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
