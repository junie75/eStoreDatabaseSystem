using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStore
{
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm()
        {
            InitializeComponent();
        }

        public SqlConnection DBConnection;

        private void HomeScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            // Log out and go back to login screen
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Close();
        }

        private void PasswordBtn_Click(object sender, EventArgs e)
        {
            // Go to change password page
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();

            //moving DB connection to the next form
            changePasswordForm.DBConnection = DBConnection;

            //homeScreen is hidden, changePassword form is shown
            changePasswordForm.Show();
            this.Hide();
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            CRUDCustomers CRUDCustomers = new CRUDCustomers();
            CRUDCustomers.Show();
            this.Close();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            CRUDOrders CRUDOrders = new CRUDOrders();
            CRUDOrders.Show();
            this.Close();
        }

        private void ShipmentBtn_Click(object sender, EventArgs e)
        {
            CRUDShipments CRUDShipments = new CRUDShipments(); 
            CRUDShipments.Show();
            this.Close();
        }

        private void ItemBtn_Click(object sender, EventArgs e)
        {
            CRUDItems CRUDItems = new CRUDItems();
            CRUDItems.Show();
            this.Close();

        }

        private void SaleBtn_Click(object sender, EventArgs e)
        {
            CRUDSales Sales = new CRUDSales();
            Sales.Show();
            this.Close();
        }
    }
}
