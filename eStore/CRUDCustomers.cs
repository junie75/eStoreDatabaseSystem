using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStore
{
    public partial class CRUDCustomers : Form
    {
        public HomeScreenForm homeScreen = new HomeScreenForm();

        public CRUDCustomers()
        {
            InitializeComponent();
        }

        private void CRUDCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection1.Open();
                SqlCommand cmdItems = DatabaseConnection1.CreateCommand();
                cmdItems.CommandText = @"SELECT Name, Email, Phone, Address, ID, Username, Password
                                        FROM Customer JOIN Login ON ID = CustomerID";

                SqlDataReader reader = cmdItems.ExecuteReader();

                DataTable tempTable = new DataTable();
                tempTable.Load(reader);

                dgvItems.DataSource = tempTable;

                reader.Close();

                //fill combo box with possible search by attributes

                string[] searchBy = { "Name", "ID", "Username" };
                searchByBox.Items.AddRange(searchBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //addButtonClick
        private void button1_Click(object sender, EventArgs e)
        {
            CUCustomer frm = new CUCustomer(); //create instance of that form’s object
            frm.Show();
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int customerID = (int)(dgvItems.CurrentRow.Cells["ID"].Value);
            CUCustomer frm = new CUCustomer(customerID); //create instance of that form’s object

            frm.Show();
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string cust = searchBox1.Text;

            if (cust == "")
            {
                SqlCommand cmdSearchCust = DatabaseConnection1.CreateCommand();
                cmdSearchCust.CommandText = @"SELECT Name, Email, Phone, Address, ID, Username, Password
                                        FROM Customer JOIN Login ON ID = CustomerID";

                SqlDataReader reader = cmdSearchCust.ExecuteReader();

                DataTable tempTable = new DataTable();
                tempTable.Load(reader);

                dgvItems.DataSource = tempTable;

                reader.Close();
            }
            else
            {
                string searchBy = searchByBox.Text;
                SqlCommand cmdSearchedItem = DatabaseConnection1.CreateCommand();

                //change query based on which attribute we are searching for
                switch (searchBy)
                {
                    case "Name":
                        cmdSearchedItem.CommandText = @"SELECT Name, Email, Phone, Address, ID, 
                                                                            Username, Password
                                              FROM Customer JOIN Login ON ID = CustomerID
                                              WHERE Name = @br";
                        break;
                    case "ID":
                        cmdSearchedItem.CommandText = @"SELECT Name, Email, Phone, Address, ID, 
                                                                            Username, Password
                                              FROM Customer JOIN Login ON ID = CustomerID
                                              WHERE ID = @br";
                        break;
                    case "Username":
                        cmdSearchedItem.CommandText = @"SELECT Name, Email, Phone, Address, ID, 
                                                                            Username, Password
                                              FROM Customer JOIN Login ON ID = CustomerID
                                              WHERE Username = @br";
                        break;
                }

                cmdSearchedItem.Parameters.AddWithValue("@br", cust);

                SqlDataReader reader = cmdSearchedItem.ExecuteReader();

                DataTable tempTable = new DataTable();
                tempTable.Load(reader);

                dgvItems.DataSource = tempTable;

                reader.Close();
            }
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            homeScreen.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //string Row = dgvItems.CurrentCell.Value.ToString();

            string Row = dgvItems.CurrentRow.Cells["ID"].Value.ToString();

            SqlCommand cmdDel = DatabaseConnection1.CreateCommand();

            cmdDel.CommandText = @"DELETE

FROM Customer

WHERE ID = @br";

            cmdDel.Parameters.AddWithValue("@br", Row);

            SqlDataReader reader1 = cmdDel.ExecuteReader();

            reader1.Close();

            //show that the item has been deleted

            MessageBox.Show("Customer Deleted", "DB eStore");

            //refresh the data grid view

            SqlCommand cmdRefresh = DatabaseConnection1.CreateCommand();

            cmdRefresh.CommandText = @"SELECT Name, Email, Phone, Address, ID, Username, Password

FROM Customer JOIN Login ON ID = CustomerID";

            SqlDataReader reader2 = cmdRefresh.ExecuteReader();

            DataTable tempTable = new DataTable();

            tempTable.Load(reader2);

            dgvItems.DataSource = tempTable;

            reader2.Close();
        }
    }
}
