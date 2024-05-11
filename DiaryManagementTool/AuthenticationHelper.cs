using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryManagementTool
{
    public static class AuthenticationHelper
    {
        public static void LogoutUser()
        {
            // Clear the user session
            UserSession.Instance.CurrentUser = null;

            // Optionally reset other states if needed

            Application.Exit();
        }
    }

}
