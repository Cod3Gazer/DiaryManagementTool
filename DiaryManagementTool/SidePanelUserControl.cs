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
    public partial class SidePanelUserControl : UserControl
    {
        Timer timer = new Timer();
        public delegate void OnButtonClickedHandler(Type formType);

        public event OnButtonClickedHandler ButtonClicked;

        public SidePanelUserControl()
        {
            if (this.DesignMode)
            {
                return; // Do nothing at design time
            }
            InitializeComponent();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(timer_Tick); // Connect the Tick event to a handler
            timer.Start(); // Start the timer
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Update the CurrentTimeLbl text with the current time each second
            CurrentTimeLbl.Text = DateTime.Now.ToString("hh:mm tt"); // Using hh:mm:ss tt for showing seconds as well
        }

        private void SidePanelUserControl_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return; // Do nothing at design time
            }
            // Use the current user data from the singleton
            UsernameLbl.Text = UserSession.Instance.CurrentUser.Username;
            CurrentTimeLbl.Text = DateTime.Now.ToString("hh:mm tt");
            HighlightButton(SalesBtn);
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(typeof(CustomerForm));
            HighlightButton(sender as Button);
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(typeof(SalesForm));
            HighlightButton(sender as Button);
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(typeof(ReportsForm));
            HighlightButton(sender as Button);
        }

        private void HighlightButton(Button btn)
        {
            // Assume all buttons have been added to a list or array for simplicity
            foreach (var button in new Button[] { SalesBtn, AddCustomerBtn }) // Add other buttons as necessary
            {
                button.BackColor = Color.RoyalBlue;
            }
            btn.BackColor = Color.Navy;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            AuthenticationHelper.LogoutUser();
        }
    }
}
