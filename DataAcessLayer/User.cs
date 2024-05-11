namespace DataAccessLayer
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }  // Hashed passwords
        public string UserType { get; set; }
    }
}
