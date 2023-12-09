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
    public partial class CRDItemsOnSale : Form
    {
        int saleNum;
        public CRDItemsOnSale(int saleNum)
        {
            InitializeComponent();

            this.saleNum = saleNum;

            lblSaleNum.Text += saleNum.ToString();
            LoadDgvCmbStoreItems();
            LoadDgvCmbSaleItems();
            CheckSaleExpiration();
        }

        private void CheckSaleExpiration()
        {
            dbConnection.Open();
            SqlCommand cmdCheck = dbConnection.CreateCommand();
            cmdCheck.CommandText = @"SELECT EndDate FROM dbo.Sale WHERE SaleNumber = @saleNum";
            cmdCheck.Parameters.AddWithValue("saleNum", saleNum);
            SqlDataReader reader = cmdCheck.ExecuteReader();
            if (reader.Read())
            {
                if (reader[0].ToString().CompareTo(DateTime.Now.ToString("M-dd-yyyy")) < 0)
                {
                    btnAdd.Enabled = false;
                    btnRemove.Enabled = false;
                    btnSave.Enabled = false;
                }
                else
                    lblNotice.Visible = false;
            }
            reader.Close();
            dbConnection.Close();
        }

        private void LoadDgvCmbStoreItems()
        {
            dbConnection.Open();
            SqlCommand cmdGetItems = dbConnection.CreateCommand();
            cmdGetItems.CommandText = @"SELECT ItemNumber as 'Item#', ItemName as 'Name', Category FROM dbo.Item WHERE SaleNumber IS NULL";
            SqlDataReader reader = cmdGetItems.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvStoreItems.DataSource = dt;

            reader = cmdGetItems.ExecuteReader();
            while (reader.Read())
                cmbStoreItem.Items.Add(reader[1].ToString());

            reader.Close();
            dbConnection.Close();
        }

        private void LoadDgvCmbSaleItems()
        {
            dbConnection.Open();
            SqlCommand cmdGetItems = dbConnection.CreateCommand();
            cmdGetItems.CommandText = @"SELECT ItemNumber as 'Item#', ItemName as 'Name', Category FROM dbo.Item WHERE SaleNumber = @saleNum";
            cmdGetItems.Parameters.AddWithValue("saleNum", saleNum);
            SqlDataReader reader = cmdGetItems.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvSaleItems.DataSource = dt;

            reader = cmdGetItems.ExecuteReader();
            while (reader.Read())
                cmbSaleItem.Items.Add(reader[1].ToString());

            reader.Close();
            dbConnection.Close();
        }

        private void dgvStoreItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbStoreItem.Text = dgvStoreItems.CurrentRow.Cells["Name"].Value.ToString();
        }

        private void dgvSaleItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbSaleItem.Text = dgvSaleItems.CurrentRow.Cells["Name"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)(dgvSaleItems.DataSource);
            DataRow dr = dt.NewRow();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dr[i] = dgvStoreItems.CurrentRow.Cells[i].Value;
            }
            dt.Rows.Add(dr);
            cmbSaleItem.Items.Add(cmbStoreItem.Text);

            dgvStoreItems.Rows.Remove(dgvStoreItems.CurrentRow);
            cmbStoreItem.Items.Remove(cmbStoreItem.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)(dgvStoreItems.DataSource);
            DataRow dr = dt.NewRow();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dr[i] = dgvSaleItems.CurrentRow.Cells[i].Value;
            }
            dt.Rows.Add(dr);
            cmbStoreItem.Items.Add(cmbSaleItem.Text);

            dgvSaleItems.Rows.Remove(dgvSaleItems.CurrentRow);
            cmbStoreItem.Items.Remove(cmbSaleItem.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dbConnection.Open();
            SqlCommand cmdSave = dbConnection.CreateCommand();
            cmdSave.CommandText = @"UPDATE dbo.Item SET SaleNumber = @saleNum WHERE ItemNumber = @itemNum AND SaleNumber IS NULL";
            foreach (DataGridViewRow row in dgvSaleItems.Rows)
            {
                if (row.Cells["Item#"].Value != null)
                {
                    cmdSave.Parameters.AddWithValue("itemNum", (int)(row.Cells["Item#"].Value));
                    cmdSave.Parameters.AddWithValue("saleNum", saleNum);
                    cmdSave.ExecuteNonQuery();
                    cmdSave.Parameters.Clear();
                }
            }
            cmdSave.CommandText = @"UPDATE dbo.Item SET SaleNumber = Null WHERE ItemNumber = @itemNum AND SaleNumber IS NOT NULL";
            foreach (DataGridViewRow row in dgvStoreItems.Rows)
            {
                if (row.Cells["Item#"].Value != null)
                {
                    cmdSave.Parameters.AddWithValue("itemNum", (int)(row.Cells["Item#"].Value));
                    cmdSave.Parameters.AddWithValue("saleNum", saleNum);
                    cmdSave.ExecuteNonQuery();
                    cmdSave.Parameters.Clear();
                }
            }
            dbConnection.Close();

            MessageBox.Show("item saved to sale");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CRUDSales frm = new CRUDSales();
            frm.Show();
            this.Close();
        }
    }
}
