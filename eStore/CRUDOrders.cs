using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStore
{
    public partial class CRUDOrders : Form
    {
        public CRUDOrders()
        {
            InitializeComponent();
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CRUDOrders_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection1.Open();

                SqlCommand cmdOrders = DBConnection1.CreateCommand();
                cmdOrders.CommandText = @"SELECT *
                                          FROM [Order]";

                SqlDataReader reader = cmdOrders.ExecuteReader();

                DataTable tempTable = new DataTable();
                tempTable.Load(reader);

                dgvItems.DataSource = tempTable;

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CUOrder frm = new CUOrder();
            frm.Show();
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int orderNum = (int)(dgvItems.CurrentRow.Cells["OrderNumber"].Value);
            CUOrder frm = new CUOrder(orderNum);
            frm.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //string Row = dgvItems.CurrentCell.Value.ToString();

            string Row = dgvItems.CurrentRow.Cells["OrderNumber"].Value.ToString();

            SqlCommand cmdDel = DBConnection1.CreateCommand();

            cmdDel.CommandText = @"DELETE

FROM [Order]

WHERE OrderNumber = @br";

            cmdDel.Parameters.AddWithValue("@br", Row);

            SqlDataReader reader1 = cmdDel.ExecuteReader();

            reader1.Close();

            //show that the item has been deleted

            MessageBox.Show("Order Deleted", "DB eStore");

            //refresh the data grid view

            SqlCommand cmdRefresh = DBConnection1.CreateCommand();

            cmdRefresh.CommandText = @"SELECT *

FROM [Order]";

            SqlDataReader reader2 = cmdRefresh.ExecuteReader();

            DataTable tempTable = new DataTable();

            tempTable.Load(reader2);

            dgvItems.DataSource = tempTable;

            reader2.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomeScreenForm frm = new HomeScreenForm();
            frm.Show();
            this.Close();
        }
    }
}
