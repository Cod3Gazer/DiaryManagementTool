using DataAcessLayer;

namespace DataAccessLayer
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string PrintName { get; set; }
        public int LedgerTypeId { get; set; }

        public LedgerType LedgerType { get; set; }
        public string PhoneNumber { get; set; }
        public string AlternativePhoneNumber { get; set; }
        public string Address { get; set; }
        public int CreditDays { get; set; }
        public string FollowUpBy { get; set; }
    }
}
