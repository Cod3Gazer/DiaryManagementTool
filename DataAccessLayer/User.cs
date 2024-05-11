namespace DataAccessLayer
{
    public class User
    {
        public int UserId { get; set; }
        public required string Username { get; set; }
        public required string FullName { get; set; }
        public required string Password { get; set; }  // Hashed passwords
        public required string UserType { get; set; }
    }
}
