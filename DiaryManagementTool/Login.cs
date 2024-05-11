using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryManagementTool
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            string password = "admin"; // This is the plaintext password; in production, ensure this comes from a secure input method
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            using (var context = new AppDbContext())
            {
                var adminUser = new User
                {
                    Username = "admin",
                    FullName = "admin",
                    Password = hashedPassword, // Use the hashed password
                    UserType = "admin"
                };

                context.Users.Add(adminUser);
                context.SaveChanges();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (var context = new AppDbContext())
            {
                // Retrieve the user by username
                var user = context.Users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    // Store the user in the singleton
                    UserSession.Instance.CurrentUser = user;

                    // Hide the login form
                    this.Hide();

                    // Instantiate and show the Sales form
                    MainForm mainForm = new MainForm(); // Assuming 'Sales' is the name of your sales form class
                    mainForm.FormClosed += (s, args) => this.Close(); // Ensure the application exits when the Sales form is closed
                    mainForm.Show();
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }
    }
}
