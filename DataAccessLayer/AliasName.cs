namespace DataAccessLayer
{
    public class AliasName
    {
        public int AliasNameId { get; set; }
        public required string FullName { get; set; }
        public int CustomerId { get; set; }
        public required Customer Customer { get; set; }
    }
}
