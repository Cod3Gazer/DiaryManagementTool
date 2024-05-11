using DataAccessLayer;
using DataAcessLayer;
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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            btnSubmit.Enabled = false;
            btnSubmit.BackColor = Color.Gray;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            NameTxtbox.TextChanged += ValidateForm;
            PrintNameTxtBox.TextChanged += ValidateForm;
            PhoneNumberTxtbox.TextChanged += ValidateForm;
            AddressTxtbox.TextChanged += ValidateForm;
            CreditDaysTxtbox.TextChanged += ValidateForm;
            FollowUpByTxtbox.TextChanged += ValidateForm;

            try
            {
                List<LedgerType> ledgerTypes = GetLedgerTypes();
                LedgerTypeListBox.DataSource = ledgerTypes;
                LedgerTypeListBox.DisplayMember = "LedgerTypeValue";
                LedgerTypeListBox.ValueMember = "LedgerTypeId";
                LedgerTypeListBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ledger types: " + ex.Message);
            }
        }

        private void ValidateForm(object sender, EventArgs e)
        {
            bool isValid = !string.IsNullOrWhiteSpace(NameTxtbox.Text) &&
                                !string.IsNullOrWhiteSpace(PrintNameTxtBox.Text) &&
                                !string.IsNullOrWhiteSpace(PhoneNumberTxtbox.Text) &&
                                !string.IsNullOrWhiteSpace(AddressTxtbox.Text) &&
                                !string.IsNullOrWhiteSpace(CreditDaysTxtbox.Text) &&
                                !string.IsNullOrWhiteSpace(FollowUpByTxtbox.Text) &&
                                LedgerTypeListBox.SelectedIndex >= 0; // Ensure a ledger type is selected

            btnSubmit.Enabled = isValid;
            btnSubmit.BackColor = isValid ? Color.RoyalBlue : Color.Gray;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FullName = NameTxtbox.Text,
                PrintName = PrintNameTxtBox.Text,
                PhoneNumber = PhoneNumberTxtbox.Text,
                LedgerTypeId = (int)LedgerTypeListBox.SelectedValue,
                AlternativePhoneNumber = AlterPhnNoTxtbox.Text,
                Address = AddressTxtbox.Text,
                CreditDays = int.Parse(CreditDaysTxtbox.Text),
                FollowUpBy = FollowUpByTxtbox.Text
            };

            AddCustomer(customer);
            MessageBox.Show("Customer added successfully.");
            ClearForm();
        }

        public void AddCustomer(Customer customer)
        {
            using (var context = new AppDbContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public List<LedgerType> GetLedgerTypes()
        {
            using (var context = new AppDbContext())
            {
                return context.LedgerTypes.ToList();
            }
        }

        private void ClearForm()
        {
            // Reset all textboxes
            NameTxtbox.Text = string.Empty;
            PrintNameTxtBox.Text = string.Empty;
            PhoneNumberTxtbox.Text = string.Empty;
            AlterPhnNoTxtbox.Text = string.Empty;
            AddressTxtbox.Text = string.Empty;
            CreditDaysTxtbox.Text = string.Empty;
            FollowUpByTxtbox.Text = string.Empty;

            // Reset ListBox selection
            LedgerTypeListBox.SelectedIndex = 0;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
