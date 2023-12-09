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
    public partial class CUOrder : Form
    {
        private bool setup = true;

        public CUOrder(int orderNum = -1)
        {
            InitializeComponent();

            // fill form with initial relevant data
            LoadData(orderNum);
        }

        private void LoadData(int orderNumber)
        {
            // make a new order# or get order# of order to be edited
            int orderNum = LoadOrderNum(orderNumber);

            // fill combobox with known customers
            LoadCmbCustomerID();

            // fill datagridview with items in db that aren't out of stock
            LoadDgvCmbItemsInStock();

            txtAddItemQty.Text = "1";

            // if updating an order, fill 2nd datagridview with items in that order
            if (orderNumber > 0)
            {
                LoadDgvCmbItemsInOrderAndLblSubtotal(orderNumber);
                GetCustomerInfo(orderNumber);
                lblAddOrder.Visible = false;
            }
            else
            {
                SetupDgvItemsInOrderAndSubtotal();
                lblUpdateOrder.Visible = false;
            }

            setup = false;
        }

        private void GetCustomerInfo(int orderNumber)
        {
            dbConnection.Open();
            SqlCommand cmdGetCustomerInfo = dbConnection.CreateCommand();
            cmdGetCustomerInfo.CommandText = @"SELECT ID, Name FROM dbo.[Customer] JOIN dbo.[Order] ON ID = CustomerID WHERE OrderNumber = @ordNum";
            cmdGetCustomerInfo.Parameters.AddWithValue("ordNum", orderNumber);
            SqlDataReader reader = cmdGetCustomerInfo.ExecuteReader();
            if (reader.Read())
            {
                cmbCustomerID.SelectedIndex = cmbCustomerID.Items.IndexOf(reader[0].ToString());
                cmbCustomerID.Enabled = false;
                lblCustomerName.Text += reader[1].ToString();
            }
            dbConnection.Close();
        }

        private void SetupDgvItemsInOrderAndSubtotal()
        {
            string[] columnNames = { "Item#", "Name", "Qty", "Price" };

            for (int i = 0; i < columnNames.Length; i++)
            {
                dgvItemsInOrder.Columns.Add(new DataGridViewTextBoxColumn());
                dgvItemsInOrder.Columns[i].HeaderText = columnNames[i];
                dgvItemsInOrder.Columns[i].Name = columnNames[i];
            }

            lblSubtotal.Text = "Subtotal: $0.00";
        }

        private void LoadDgvCmbItemsInOrderAndLblSubtotal(int orderNum)
        {
            lblAddOrder.Visible = false;
            lblOrderNum.Text = "Order#: " + orderNum;
            dbConnection.Open();
            SqlCommand cmdGetOrderItems = dbConnection.CreateCommand();
            cmdGetOrderItems.CommandText = @"SELECT dbo.[OrderItem].ItemNumber as 'Item#', ItemName as 'Name', ItemQuantity as 'Qty', Price * ItemQuantity as 'Price'
                                           FROM dbo.[OrderItem] JOIN dbo.Item ON dbo.Item.ItemNumber = dbo.[OrderItem].ItemNumber 
                                           WHERE OrderNumber = @ordNum";
            cmdGetOrderItems.Parameters.AddWithValue("ordNum", orderNum);
            SqlDataReader reader = cmdGetOrderItems.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvItemsInOrder.DataSource = dt;

            reader = cmdGetOrderItems.ExecuteReader();
            while (reader.Read())
                cmbRemoveSelectedItem.Items.Add(reader[1].ToString());

            SqlCommand cmdGetSubtotal = dbConnection.CreateCommand();
            cmdGetSubtotal.CommandText = @"SELECT Subtotal FROM dbo.[Order] WHERE OrderNumber = @ordNum";
            cmdGetSubtotal.Parameters.AddWithValue("ordNum", orderNum);
            reader.Close();
            reader = cmdGetSubtotal.ExecuteReader();
            if (reader.Read())
                lblSubtotal.Text = "Subtotal: $" + reader[0].ToString();

            reader.Close();
            dbConnection.Close();
        }

        private void LoadDgvCmbItemsInStock()
        {
            dbConnection.Open();
            SqlCommand cmdGetItems = dbConnection.CreateCommand();
            cmdGetItems.CommandText = @"SELECT ItemNumber as 'Item#', ItemName as 'Name', Price, QuantityAvailable as 'Qty', Category, SaleNumber as 'Sale#'
                                      FROM dbo.Item WHERE QuantityAvailable > 0 AND isPurchasable = 1";
            SqlDataReader reader = cmdGetItems.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvItemsInStock.DataSource = dt;

            reader = cmdGetItems.ExecuteReader();
            while (reader.Read())
                cmbAddSelectedItem.Items.Add(reader[1].ToString());

            reader.Close();
            dbConnection.Close();
        }

        private void LoadCmbCustomerID()
        {
            dbConnection.Open();
            SqlCommand cmdGetCustomerIDs = dbConnection.CreateCommand();
            cmdGetCustomerIDs.CommandText = @"SELECT ID FROM dbo.Customer";
            SqlDataReader reader = cmdGetCustomerIDs.ExecuteReader();
            while (reader.Read())
                cmbCustomerID.Items.Add(reader[0].ToString());
            reader.Close();
            dbConnection.Close();
        }

        private int LoadOrderNum(int orderNumber)
        {
            int orderNum = orderNumber;

            if (orderNum < 0)
            {
                dbConnection.Open();
                SqlCommand cmdGetOrderNum = dbConnection.CreateCommand();
                cmdGetOrderNum.CommandText = @"SELECT max(OrderNumber) + 1 FROM dbo.[Order]";
                SqlDataReader reader = cmdGetOrderNum.ExecuteReader();
                if (reader.Read())
                    orderNum = reader.GetInt32(0);
                else
                    MessageBox.Show("Error: unable to get current order's #", "Error");
                reader.Close();
                dbConnection.Close();
            }

            lblOrderNum.Text += orderNum.ToString();

            return orderNum;
        }

        private void cmbCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (!setup && cmbCustomerID.Items.Contains(cmbCustomerID.Text))
            {
                dbConnection.Open();
                SqlCommand cmdGetCustomerName = dbConnection.CreateCommand();
                cmdGetCustomerName.CommandText = @"SELECT Name FROM dbo.Customer WHERE ID = @id";
                cmdGetCustomerName.Parameters.AddWithValue("id", cmbCustomerID.Text);
                SqlDataReader reader = cmdGetCustomerName.ExecuteReader();
                if (reader.Read())
                {
                    lblCustomerName.Text = "Customer Name: " + reader[0].ToString();
                }
                else
                    MessageBox.Show("Error: unable to get name for selected customer #", "Error");
                reader.Close();
                dbConnection.Close();
            }
            else
                lblCustomerName.Text = "Customer Name: ";
        }

        private decimal CalculateOrderSubtotal()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dgvItemsInOrder.Rows)
                subtotal += (decimal)(row.Cells["Price"].Value);
            lblSubtotal.Text = "Subtotal: $" + subtotal.ToString();

            return subtotal;
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            int orderNum = int.Parse(lblOrderNum.Text.Substring(lblOrderNum.Text.IndexOfAny("0123456789".ToCharArray())));
            int custID;
            string orderResult = "updated in";

            try
            {
                custID = int.Parse(cmbCustomerID.Text);
            }
            catch
            {
                MessageBox.Show("customer # not selected, order not saved");
                return; // custID = 100000;
            }
            decimal subtotal, total, shippingFee = 0, taxes = 0;

            subtotal = CalculateOrderSubtotal();
            total = subtotal + shippingFee + taxes;
            dbConnection.Open();

            SqlCommand cmdSaveOrder1 = dbConnection.CreateCommand();
            if (lblAddOrder.Visible)
            {
                cmdSaveOrder1.CommandText = @"INSERT INTO dbo.[Order] VALUES (@subtot, @tot, @date, @custID, @ordNum, @shipNum)";
                orderResult = "added to";
                cmdSaveOrder1.Parameters.AddWithValue("shipNum", DBNull.Value);
                cmdSaveOrder1.Parameters.AddWithValue("custID", custID);
            }
            else
                cmdSaveOrder1.CommandText = @"UPDATE dbo.[Order] SET Subtotal = @subtot, Total = @tot, OrderDate = @date, OrderNumber = @ordNum
                                             WHERE OrderNumber = @ordNum";
            cmdSaveOrder1.Parameters.AddWithValue("subtot", subtotal);
            cmdSaveOrder1.Parameters.AddWithValue("tot", total);
            cmdSaveOrder1.Parameters.AddWithValue("date", DateTime.Now.ToString("M-dd-yyyy"));
            cmdSaveOrder1.Parameters.AddWithValue("ordNum", orderNum);
            cmdSaveOrder1.ExecuteNonQuery();

            SqlCommand cmdGetItemsInOrder = dbConnection.CreateCommand();
            cmdGetItemsInOrder.CommandText = @"SELECT ItemNumber FROM dbo.[OrderItem] WHERE OrderNumber = @ordNum";
            cmdGetItemsInOrder.Parameters.AddWithValue("ordNum", orderNum);
            SqlDataReader reader = cmdGetItemsInOrder.ExecuteReader();
            List<int> itemsInOrder = new List<int>();
            while (reader.Read())
                itemsInOrder.Add(reader.GetInt32(0));
            reader.Close();

            foreach (DataGridViewRow row in dgvItemsInOrder.Rows)
            {
                int qty = (int)(row.Cells["Qty"].Value), itemNum = (int)(row.Cells["Item#"].Value);
                SqlCommand cmdSaveOrder2 = dbConnection.CreateCommand();
                if (lblAddOrder.Visible || !itemsInOrder.Contains(itemNum))
                    cmdSaveOrder2.CommandText = @"INSERT INTO dbo.[OrderItem] VALUES (@itemNum, @qty, @ordNum)";
                else
                {
                    cmdSaveOrder2.CommandText = @"UPDATE dbo.[OrderItem] SET ItemNumber = @itemNum, ItemQuantity = @qty, OrderNumber = @ordNum
                                                  WHERE OrderNumber = @ordNum AND ItemNumber = @itemNum";
                    itemsInOrder.Remove(itemNum);
                }
                cmdSaveOrder2.Parameters.AddWithValue("itemNum", itemNum);
                cmdSaveOrder2.Parameters.AddWithValue("qty", qty);
                cmdSaveOrder2.Parameters.AddWithValue("ordNum", orderNum);
                cmdSaveOrder2.ExecuteNonQuery();

                //update item inventory
                SqlCommand cmdUpdateItemStock = dbConnection.CreateCommand();
                cmdUpdateItemStock.CommandText = @"UPDATE dbo.Item SET QuantityAvailable = QuantityAvailable - @qty WHERE ItemNumber = @itemNum";
                cmdUpdateItemStock.Parameters.AddWithValue("qty", qty);
                cmdUpdateItemStock.Parameters.AddWithValue("itemNum", itemNum);
                cmdUpdateItemStock.ExecuteNonQuery();
            }

            if (itemsInOrder.Count != 0)
            {
                SqlCommand cmdUpdateItemStock = dbConnection.CreateCommand();
                cmdUpdateItemStock.CommandText = @"UPDATE dbo.Item SET QuantityAvailable = QuantityAvailable + @qty WHERE ItemNumber = @itemNum";

                SqlCommand cmdGetItemQty = dbConnection.CreateCommand();
                cmdGetItemQty.CommandText = @"SELECT ItemQuantity FROM dbo.[OrderItem] WHERE ItemNumber = @itemNum";

                SqlCommand cmdRemoveItems = dbConnection.CreateCommand();
                cmdRemoveItems.CommandText = @"DELETE FROM dbo.[OrderItem] WHERE OrderNumber = @ordNum AND ItemNumber = @itemNum";
                foreach (int itemNumber in itemsInOrder)
                {
                    cmdGetItemQty.Parameters.AddWithValue("itemNum", itemNumber);
                    reader = cmdGetItemQty.ExecuteReader();
                    int qty = 0;
                    if (reader.Read())
                        qty = reader.GetInt32(0);
                    reader.Close();
                    cmdGetItemQty.Parameters.Clear();

                    cmdUpdateItemStock.Parameters.AddWithValue("qty", qty);
                    cmdUpdateItemStock.Parameters.AddWithValue("itemNum", itemNumber);
                    cmdUpdateItemStock.ExecuteNonQuery();
                    cmdUpdateItemStock.Parameters.Clear();

                    cmdRemoveItems.Parameters.AddWithValue("ordNum", orderNum);
                    cmdRemoveItems.Parameters.AddWithValue("itemNum", itemNumber);
                    cmdRemoveItems.ExecuteNonQuery();
                    cmdRemoveItems.Parameters.Clear();
                }
            }

            dbConnection.Close();

            string message = "order " + orderNum + " has been " + orderResult + " database";
            MessageBox.Show(message);

            if (lblAddOrder.Visible)
            {
                orderNum += 1;
                lblOrderNum.Text = "Order#: " + orderNum;
                cmbCustomerID.Text = "";
                dgvItemsInOrder.Rows.Clear();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            bool addItem = false;

            if (cmbAddSelectedItem.Text.Equals(""))
                MessageBox.Show("error: item not selected");
            else if (!cmbAddSelectedItem.Items.Contains(cmbAddSelectedItem.Text))
                MessageBox.Show("error: item doesn't exist");
            else if (int.Parse(txtAddItemQty.Text.Trim()) < 1 || txtAddItemQty.Text.Trim().IndexOfAny("0123456789".ToCharArray()) == -1)
                MessageBox.Show("error: qty must be 1 or greater");
            else
                addItem = true;

            if (addItem)
            {
                int itemNum = -1, itemQty = int.Parse(txtAddItemQty.Text);
                decimal itemPrice = -1;
                bool emptyStock = false;
                foreach (DataGridViewRow row in dgvItemsInStock.Rows)
                {
                    if (row.Cells["Name"].Value.ToString().Equals(cmbAddSelectedItem.Text))
                    {
                        itemNum = (int)(row.Cells["Item#"].Value);
                        itemPrice = (decimal)(row.Cells["Price"].Value);

                        int qtyInStock = (int)(row.Cells["Qty"].Value);
                        if (qtyInStock < itemQty)
                        {
                            MessageBox.Show("item qty to add is more than what's available. adding remainder of stock to order instead.");
                            itemQty = qtyInStock;
                        }

                        row.Cells["Qty"].Value = qtyInStock - itemQty;

                        if ((int)(row.Cells["Qty"].Value) == 0)
                        {
                            dgvItemsInStock.Rows.Remove(row);
                            emptyStock = true;
                        }
                        break;
                    }
                }
                if (lblAddOrder.Visible)
                    dgvItemsInOrder.Rows.Add(itemNum, cmbAddSelectedItem.Text, itemQty, itemPrice * itemQty);
                else
                {
                    DataTable dt = (DataTable)(dgvItemsInOrder.DataSource);
                    DataRow dr = dt.NewRow();
                    object[] rowInfo = { itemNum, cmbAddSelectedItem.Text, itemQty, itemPrice * itemQty };
                    dr.ItemArray = rowInfo;
                    dt.Rows.Add(dr);
                }

                CalculateOrderSubtotal();

                if (!cmbRemoveSelectedItem.Items.Contains(cmbAddSelectedItem.Text))
                    cmbRemoveSelectedItem.Items.Add(cmbAddSelectedItem.Text);

                if (emptyStock)
                {
                    cmbAddSelectedItem.Items.Remove(cmbAddSelectedItem.Text);
                    cmbAddSelectedItem.Text = "";
                }
            }
        }

        private void dgvItemsInStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbAddSelectedItem.Text = dgvItemsInStock.CurrentRow.Cells["Name"].Value.ToString();
        }

        private void dgvItemsInOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbRemoveSelectedItem.Text = dgvItemsInOrder.CurrentRow.Cells["Name"].Value.ToString();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow orderRow in dgvItemsInOrder.Rows)
            {
                if (orderRow.Cells["Name"].Value.ToString().Equals(cmbRemoveSelectedItem.Text))
                {
                    bool stockItemExists = false;
                    int itemQty = (int)(orderRow.Cells["Qty"].Value);
                    foreach (DataGridViewRow stockRow in dgvItemsInStock.Rows)
                    {
                        if (stockRow.Cells["Name"].Value.ToString().Equals(cmbRemoveSelectedItem.Text))
                        {
                            stockRow.Cells["Qty"].Value = (int)(stockRow.Cells["Qty"].Value) + itemQty;
                            stockItemExists = true;
                            break;
                        }
                    }
                    if (!stockItemExists)
                    {
                        dbConnection.Open();
                        SqlCommand cmdGetItem = dbConnection.CreateCommand();
                        cmdGetItem.CommandText = @"SELECT ItemNumber as 'Item#', ItemName as 'Name', Price, QuantityAvailable as 'Qty', Category, SaleNumber as 'Sale#'
                                                   FROM dbo.Item WHERE ItemNumber = @itemNum";
                        cmdGetItem.Parameters.AddWithValue("itemNum", (int)(orderRow.Cells["Item#"].Value));
                        SqlDataReader reader = cmdGetItem.ExecuteReader();
                        if (reader.Read())
                        {
                            DataTable dt = (DataTable)(dgvItemsInStock.DataSource);
                            DataRow dr = dt.NewRow();
                            for (int i = 0; i < 5; i++)
                                dr[i] = reader[i].ToString();
                            if (reader[5].ToString().Equals(""))
                                dr[5] = System.DBNull.Value;
                            else
                                dr[5] = reader[5].ToString();
                            dt.Rows.Add(dr);
                        }
                        reader.Close();
                        dbConnection.Close();

                        cmbAddSelectedItem.Items.Add(cmbRemoveSelectedItem.Text);
                    }

                    dgvItemsInOrder.Rows.Remove(orderRow);
                    cmbRemoveSelectedItem.Items.Remove(cmbRemoveSelectedItem.Text);
                    cmbRemoveSelectedItem.Text = "";
                    break;
                }
            }
            CalculateOrderSubtotal();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CRUDOrders frm = new CRUDOrders();
            frm.Show();
            this.Close();

        }
    }
}
