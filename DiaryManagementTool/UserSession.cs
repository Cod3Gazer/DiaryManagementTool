using DataAccessLayer;

namespace DiaryManagementTool
{
    public class UserSession
    {
        private static UserSession _instance;
        private static readonly object _lock = new object();

        // Property to access the current user
        public User CurrentUser { get; set; }

        // Private constructor to prevent instantiation outside
        private UserSession() { }

        // Public property to get the instance of the session
        public static UserSession Instance
        {
            get
            {
                lock (_lock)  // Ensure thread safety
                {
                    if (_instance == null)
                    {
                        _instance = new UserSession();
                    }
                    return _instance;
                }
            }
        }
    }
}
