using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace eStore
{
    public partial class CRUDItems : Form
    {
        public CRUDItems()
        {
            InitializeComponent();
        }
        private void CRUDItems_Load_1(object sender, EventArgs e)
        {
            try
            {
                DBConnection1.Open();

                SqlCommand cmdItems = DBConnection1.CreateCommand();
                cmdItems.CommandText = @"SELECT *
                                              FROM Item";

                SqlDataReader reader = cmdItems.ExecuteReader();

                DataTable tempTable = new DataTable();
                tempTable.Load(reader);

                dgvItems1.DataSource = tempTable;

                reader.Close();

                //fill combo box with possible search by attributes

                string[] searchBy = { "ItemName", "ItemNumber", "Category", "SaleNumber" };
                searchByBox.Items.AddRange(searchBy);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CUItem frm = new CUItem();
            frm.Show();
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int itemNum = (int)dgvItems1.CurrentRow.Cells["ItemNumber"].Value;
            CUItem frm = new CUItem(itemNum);
            frm.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //string Row = dgvItems1.CurrentCell.Value.ToString();

            string Row = dgvItems1.CurrentRow.Cells["ItemNumber"].Value.ToString();

            SqlCommand cmdDel = DBConnection1.CreateCommand();

            cmdDel.CommandText = @"DELETE

FROM Item

WHERE ItemNumber = @br";

            cmdDel.Parameters.AddWithValue("@br", Row);

            SqlDataReader reader1 = cmdDel.ExecuteReader();

            reader1.Close();

            //show that the item has been deleted

            MessageBox.Show("Item Deleted", "DB eStore");

            //refresh the data grid view

            SqlCommand cmdRefresh = DBConnection1.CreateCommand();

            cmdRefresh.CommandText = @"SELECT *

FROM Item";

            SqlDataReader reader2 = cmdRefresh.ExecuteReader();

            DataTable tempTable = new DataTable();

            tempTable.Load(reader2);

            dgvItems1.DataSource = tempTable;

            reader2.Close();

        }

        private void dgvItems1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string it = searchBox1.Text;

            if (it == "")
            {
                SqlCommand cmdSearchedItem = DBConnection1.CreateCommand();
                cmdSearchedItem.CommandText = @"SELECT *
                                              FROM Item";

                SqlDataReader reader = cmdSearchedItem.ExecuteReader();

                DataTable tempTable = new DataTable();
                tempTable.Load(reader);

                dgvItems1.DataSource = tempTable;

                reader.Close();
            }
            else
            {
                string searchBy = searchByBox.Text;
                SqlCommand cmdSearchedItem = DBConnection1.CreateCommand();

                //change query based on which attribute we are searching for
                switch (searchBy)
                {
                    case "ItemName":
                        cmdSearchedItem.CommandText = @"SELECT *
                                              FROM Item
                                              WHERE ItemName = @item";
                        break;
                    case "ItemNumber":
                        cmdSearchedItem.CommandText = @"SELECT *
                                              FROM Item
                                              WHERE ItemNumber = @item";
                        break;
                    case "Category":
                        cmdSearchedItem.CommandText = @"SELECT *
                                              FROM Item
                                              WHERE Category = @item";
                        break;
                    case "SaleNumber":
                        cmdSearchedItem.CommandText = @"SELECT *
                                              FROM Item
                                              WHERE ItemNumber = @item";
                        break;
                }

                cmdSearchedItem.Parameters.AddWithValue("@item", it);

                SqlDataReader reader = cmdSearchedItem.ExecuteReader();

                DataTable tempTable = new DataTable();
                tempTable.Load(reader);

                dgvItems1.DataSource = tempTable;

                reader.Close();
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomeScreenForm frm = new HomeScreenForm();
            frm.Show();
            this.Close();
        }
    }
}
