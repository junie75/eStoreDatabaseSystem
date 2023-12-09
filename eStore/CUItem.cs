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
using System.Xml.Linq;

namespace eStore
{
    public partial class CUItem : Form
    {
        int itemNum;

        public CUItem(int itemNum = -1)
        {
            InitializeComponent();
            cmbSales.Visible = false;

            LoadCmbSales();

            this.itemNum = itemNum;

            if (itemNum > 0)
            {
                lblAddItem.Visible = false;
                btnSaveItem.Text = "Update";
                LoadItemInfo();
            }
            else
            {
                lblUpdateItem.Visible = false;
                lblNumber.Visible = false;
            }
        }

        private void GetItemNum()
        {
            dbConnection.Open();
            SqlCommand cmdGetItemNum = dbConnection.CreateCommand();
            cmdGetItemNum.CommandText = @"SELECT max(ItemNumber) + 1 FROM dbo.Item";
            SqlDataReader reader = cmdGetItemNum.ExecuteReader();
            if (reader.Read())
                itemNum = reader.GetInt32(0);
            else
                MessageBox.Show("Error: unable to get current item's #", "Error");
            reader.Close();
            dbConnection.Close();
        }

        private void LoadItemInfo()
        {
            dbConnection.Open();
            SqlCommand cmdGetItemInfo = dbConnection.CreateCommand();
            cmdGetItemInfo.CommandText = @"SELECT * FROM dbo.Item WHERE ItemNumber = @itemNum";
            cmdGetItemInfo.Parameters.AddWithValue("itemNum", itemNum);
            SqlDataReader reader = cmdGetItemInfo.ExecuteReader();
            if (reader.Read())
            {
                // name, price, qty, category, sale#, item#, buyable
                txtName.Text = reader[0].ToString();
                txtPrice.Text = reader[1].ToString();
                txtQty.Text = reader[2].ToString();
                txtCategory.Text = reader[3].ToString();
                //rbOnSaleNo.Checked = true;
                if (!reader[4].ToString().Equals(""))
                {
                    rbOnSaleYes.Checked = true;
                    cmbSales.Text = reader[4].ToString();
                }
                else
                    rbOnSaleNo.Checked = true;
                lblNumber.Text += reader[5].ToString();
                string isBuyable = reader[6].ToString();
                if (reader.GetBoolean(6))
                    rbBuyableYes.Checked = true;
                else
                    rbBuyableNo.Checked = true;
            }
            reader.Close();
            dbConnection.Close();
        }

        private void LoadCmbSales()
        {
            dbConnection.Open();

            SqlCommand cmdGetSales = dbConnection.CreateCommand();
            cmdGetSales.CommandText = @"SELECT SaleNumber from dbo.Sale";
            SqlDataReader reader = cmdGetSales.ExecuteReader();
            while (reader.Read())
            {
                cmbSales.Items.Add(reader.GetInt32(0));
            }

            reader.Close();
            dbConnection.Close();
        }

        private void rbBuyableYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuyableYes.Focused)
                rbBuyable_CheckedChanged(true);
        }

        private void rbBuyableNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuyableNo.Focused)
                rbBuyable_CheckedChanged(false);
        }

        private void rbBuyable_CheckedChanged(bool yesChecked)
        {
            rbBuyableNo.Checked = !yesChecked;
            rbBuyableYes.Checked = yesChecked;
        }

        private void rbOnSaleYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOnSaleYes.Focused)
                rbOnSale_CheckedChanged(true);
            cmbSales.Visible = true;
        }

        private void rbOnSaleNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOnSaleNo.Focused)
                rbOnSale_CheckedChanged(false);
            cmbSales.Visible = false;
        }

        private void rbOnSale_CheckedChanged(bool yesChecked)
        {
            rbOnSaleNo.Checked = !yesChecked;
            rbOnSaleYes.Checked = yesChecked;
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            // name, price, qty, category, sale#, item#, buyable
            string message = "added.";

            dbConnection.Open();
            SqlCommand cmdSaveItem = dbConnection.CreateCommand();
            if (itemNum > 0)
            {
                cmdSaveItem.CommandText = @"UPDATE dbo.Item SET ItemName = @name, Price = @price, QuantityAvailable = @qty, Category = @cat, 
                                            SaleNumber = @sale, isPurchasable = @canBuy WHERE ItemNumber = @itemNum";
                message = "updated.";
            }
            else
            {
                dbConnection.Close();
                GetItemNum();
                cmdSaveItem.CommandText = @"INSERT INTO dbo.Item VALUES (@name, @price, @qty, @cat, @sale, @itemNum, @canBuy)";
                dbConnection.Open();
            }
            cmdSaveItem.Parameters.AddWithValue("name", txtName.Text);
            cmdSaveItem.Parameters.AddWithValue("price", decimal.Parse(txtPrice.Text.Substring(txtPrice.Text.IndexOfAny("0123456789".ToCharArray()))));
            cmdSaveItem.Parameters.AddWithValue("qty", int.Parse(txtQty.Text));
            cmdSaveItem.Parameters.AddWithValue("cat", txtCategory.Text);
            if (rbOnSaleYes.Checked)
                cmdSaveItem.Parameters.AddWithValue("sale", int.Parse(cmbSales.Text));
            else
                cmdSaveItem.Parameters.AddWithValue("sale", DBNull.Value);
            cmdSaveItem.Parameters.AddWithValue("itemNum", itemNum);
            if (rbBuyableYes.Checked)
                cmdSaveItem.Parameters.AddWithValue("canBuy", 1);
            else
                cmdSaveItem.Parameters.AddWithValue("canBuy", 0);
            cmdSaveItem.ExecuteNonQuery();

            dbConnection.Close();

            MessageBox.Show("item has been " + message);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CRUDItems frm = new CRUDItems();
            frm.Show();
            this.Close();
        }
    }
}
