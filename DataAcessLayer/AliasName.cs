namespace DataAccessLayer
{
    public class AliasName
    {
        public int AliasNameId { get; set; }
        public string FullName { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
