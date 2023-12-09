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
    public partial class CUSale : Form
    {
        int saleNum;
        public CUSale(int saleNum = -1)
        {
            InitializeComponent();

            rbChange.Enabled = false;
            rbMultiply.Enabled = false;
            rbSubtract.Enabled = false;
            rbSubtract.Checked = true;

            this.saleNum = saleNum;

            if (saleNum >= 0)
            {
                lblSale.Text = "Update Sale";
                btnSaveSale.Text = "Update";
                LoadSaleInfo();
            }
            else
            {
                lblSale.Text = "Add Sale";
                btnSaveSale.Text = "Add";
                GetSaleNum(false);
                cmbSaleNum.Enabled = false;
            }
        }

        private void GetSaleNum(bool forSaleNum)
        {
            dbConnection.Open();
            SqlCommand cmdGetSaleNum = dbConnection.CreateCommand();
            cmdGetSaleNum.CommandText = @"SELECT max(SaleNumber)+1 FROM dbo.Sale";
            SqlDataReader reader = cmdGetSaleNum.ExecuteReader();
            if (reader.Read())
                if (forSaleNum)
                    saleNum = reader.GetInt32(0);
                else
                    cmbSaleNum.Text = reader[0].ToString();
            else
                MessageBox.Show("Error: unable to get current shipment's #", "Error");
            reader.Close();
            dbConnection.Close();
        }

        private void LoadSaleInfo()
        {
            cmbSaleNum.Text = "";
            cmbSaleNum.Items.Clear();
            txtSaleAmount.Text = "";
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;

            dbConnection.Open();
            SqlCommand cmdGetSaleInfo = dbConnection.CreateCommand();
            cmdGetSaleInfo.CommandText = @"SELECT * FROM dbo.Sale WHERE SaleNumber = @saleNum";
            cmdGetSaleInfo.Parameters.AddWithValue("saleNum", saleNum);
            SqlDataReader reader = cmdGetSaleInfo.ExecuteReader();
            if (reader.Read())
            {
                cmbSaleNum.Text = reader[0].ToString();
                cmbSaleNum.Items.Add(reader[0].ToString());
                txtSaleAmount.Text = reader[1].ToString();
                dtpStart.Value = DateTime.Parse(reader[2].ToString());
                dtpEnd.Value = DateTime.Parse(reader[3].ToString());
            }
            reader.Close();
            dbConnection.Close();
        }

        //private void LoadCmbSaleNum()
        //{
        //    cmbSaleNum.Text = "";
        //    cmbSaleNum.Items.Clear();

        //    dbConnection.Open();
        //    SqlCommand cmdGetSaleNums = dbConnection.CreateCommand();
        //    cmdGetSaleNums.CommandText = @"SELECT SaleNumber FROM dbo.Sale";
        //    SqlDataReader reader = cmdGetSaleNums.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        cmbSaleNum.Text = reader[0].ToString();
        //        cmbSaleNum.Items.Add(reader[0].ToString());
        //    }
        //    reader.Close();
        //    dbConnection.Close();
        //}

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            string message = "updated.";

            dbConnection.Open();
            SqlCommand cmdSaveSale = dbConnection.CreateCommand();
            if (saleNum < 0)
            {
                message = "added";
                dbConnection.Close();
                GetSaleNum(true);
                dbConnection.Open();
                cmdSaveSale.CommandText = @"INSERT INTO dbo.Sale VALUES (@saleNum, @saleAmount, @start, @end)";
            }
            else
                cmdSaveSale.CommandText = @"UPDATE dbo.Sale SET SaleAmount = @saleAmount, StartDate = @start, EndDate = @end
                                            WHERE SaleNumber = @saleNum";
            cmdSaveSale.Parameters.AddWithValue("saleNum", saleNum);
            cmdSaveSale.Parameters.AddWithValue("saleAmount", decimal.Parse(txtSaleAmount.Text.Substring(txtSaleAmount.Text.IndexOfAny("0123456789".ToCharArray()))));
            cmdSaveSale.Parameters.AddWithValue("start", dtpStart.Value.ToString("M-dd-yyyy"));
            cmdSaveSale.Parameters.AddWithValue("end", dtpEnd.Value.ToString("M-dd-yyyy"));
            cmdSaveSale.ExecuteNonQuery();
            dbConnection.Close();

            MessageBox.Show("sale has been " + message);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CRUDSales frm = new CRUDSales();
            frm.Show();
            this.Close();
        }
    }
}
