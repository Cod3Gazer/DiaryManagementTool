namespace DataAccessLayer
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public required string FullName { get; set; }
        public string? PrintName { get; set; }
        public required string LedgerType { get; set; }
        public required string PhoneNumber { get; set; }
        public string? AlternativePhoneNumber { get; set; }
        public string? Address { get; set; }
        public int CreditDays { get; set; }
        public required string FollowUpBy { get; set; }
    }
}
