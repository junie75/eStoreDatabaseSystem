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
    public partial class CRUDSales : Form
    {
        public CRUDSales()
        {
            InitializeComponent();
        }

        private void CRUDSales_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection1.Open();

                SqlCommand cmdSales = DBConnection1.CreateCommand();
                cmdSales.CommandText = @"SELECT *
                                              FROM Sale";

                SqlDataReader reader = cmdSales.ExecuteReader();

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
            CUSale CUSale = new CUSale();
            CUSale.Show();
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int saleNum = (int)dgvItems.CurrentRow.Cells["SaleNumber"].Value;
            CUSale CUSale = new CUSale(saleNum);
            CUSale.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //string Row = dgvItems.CurrentCell.Value.ToString();

            string Row = dgvItems.CurrentRow.Cells["SaleNumber"].Value.ToString();

            SqlCommand cmdDel = DBConnection1.CreateCommand();

            cmdDel.CommandText = @"DELETE

FROM Sale

WHERE SaleNumber = @br";

            cmdDel.Parameters.AddWithValue("@br", Row);

            SqlDataReader reader1 = cmdDel.ExecuteReader();

            reader1.Close();

            //show that the item has been deleted

            MessageBox.Show("Sale Deleted", "DB eStore");

            //refresh the data grid view

            SqlCommand cmdRefresh = DBConnection1.CreateCommand();

            cmdRefresh.CommandText = @"SELECT *

FROM Sale";

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

        private void CRUDSales_DoubleClick(object sender, EventArgs e)
        {
            int saleNum = (int)dgvItems.CurrentRow.Cells["SaleNumber"].Value;
            CRDItemsOnSale frm = new CRDItemsOnSale(saleNum);
            frm.Show();
            this.Close();
        }
    }
}
