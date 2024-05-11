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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            sidePanelUserControl1.ButtonClicked += LoadFormInPanel;
            LoadFormInPanel(typeof(SalesForm));  // Load Sales form by default
        }

        private void LoadFormInPanel(Type formType)
        {
            // Search for an existing form by name
            var existingForm = tableLayoutPanel1.Controls.Find("dynamicForm", true).FirstOrDefault() as Form;

            // Check if the existing form is of the same type as the requested form type
            if (existingForm != null && existingForm.GetType() == formType)
            {
                // If so, simply bring it to the front (if needed)
                existingForm.BringToFront();
            }
            else
            {
                // If no such form exists, or a different form is requested, proceed to create a new instance
                if (existingForm != null)
                {
                    tableLayoutPanel1.Controls.Remove(existingForm); // Remove the old form
                    existingForm.Dispose(); // Properly dispose of the old form
                }

                // Create a new instance of the form
                var form = (Form)Activator.CreateInstance(formType);
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Name = "dynamicForm"; // Assign a name to the form

                // Add the new form to the table layout panel
                tableLayoutPanel1.Controls.Add(form, 1, 0); // Add to Column 1, Row 0
                form.Show();
            }
        }

    }
}
