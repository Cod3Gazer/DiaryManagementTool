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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadCustomerReport();
            LoadSalesReport();
            LoadExcusesReport();
        }

        private void LoadCustomerReport()
        {
            using (var context = new AppDbContext())
            {
                var customerData = context.Customers.ToList();
                dgvCustomers.DataSource = customerData;
            }
        }

        private void LoadSalesReport()
        {
            using (var context = new AppDbContext())
            {
                var salesData = context.Sales.ToList();
                dgvSales.DataSource = salesData;
            }
        }

        private void LoadExcusesReport()
        {
            using (var context = new AppDbContext())
            {
                var excusesData = context.Excuses.ToList();
                dgvExcuses.DataSource = excusesData;
            }
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerId"].Value);
                RefreshSales(customerId);
                RefreshExcuses(customerId);
            }
        }

        private void RefreshSales(int customerId)
        {
            using (var context = new AppDbContext())
            {
                var salesData = context.Sales.Where(s => s.CustomerId == customerId).ToList();
                dgvSales.DataSource = salesData;
            }
        }

        private void RefreshExcuses(int customerId)
        {
            using (var context = new AppDbContext())
            {
                var excusesData = context.Excuses.Where(e => e.CustomerId == customerId).ToList();
                dgvExcuses.DataSource = excusesData;
            }
        }

        private void btnAddExcuse_Click(object sender, EventArgs e)
        {

        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerId"].Value);
                RefreshSales(customerId);
                RefreshExcuses(customerId);
            }
        }
    }
}
