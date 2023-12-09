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
    public partial class CUShipment : Form
    {
        int shipNum, ordNum;
        bool setup = true;
        object[] original = new object[3];

        public CUShipment(int shipNum = -1)
        {
            InitializeComponent();

            txtOrderNum.Visible = false;

            this.shipNum = shipNum;

            if (shipNum > 0)
            {
                lblAddShipment.Visible = false;
                btnSaveShipment.Text = "Update Shipment";
                LoadShipmentInfo();
            }
            else
            {
                lblUpdateShipment.Visible = false;
                cmbShipNum.Enabled = false;
                GetShipNum();
                cmbShipNum.Text = this.shipNum.ToString();
            }
            LoadCmbCustomerID();

            setup = false;
        }

        private void LoadShipmentInfo()
        {
            dbConnection.Open();
            SqlCommand cmdGetShipmentInfo = dbConnection.CreateCommand();
            cmdGetShipmentInfo.CommandText = @"SELECT dbo.Shipment.*, OrderNumber, CustomerID, Name
                                               FROM dbo.Shipment JOIN dbo.[Order] ON dbo.[Order].ShipmentNumber = dbo.Shipment.ShipNumber
                                                                 JOIN dbo.Customer ON dbo.[Order].CustomerID = dbo.Customer.ID
                                               WHERE dbo.Shipment.ShipNumber = @shipNum";
            cmdGetShipmentInfo.Parameters.AddWithValue("shipNum", shipNum);
            SqlDataReader reader = cmdGetShipmentInfo.ExecuteReader();
            if (reader.Read())
            {
                // shipto, shipfrom, shipdate, shiparrive, ship#, ordnum, id, name
                txtShipTo.Text = reader[0].ToString();
                txtShipFrom.Text = reader[1].ToString();
                txtShipDate.Text = reader[2].ToString();
                txtShipArriveDate.Text = reader[3].ToString();
                cmbShipNum.Text = reader[4].ToString();
                cmbShipNum.Items.Add(cmbShipNum.Text);
                cmbOrderNum.Text = reader[5].ToString();
                ordNum = int.Parse(cmbOrderNum.Text);
                cmbOrderNum.Items.Add(ordNum);
                cmbCustomerID.Text = reader[6].ToString();
                cmbCustomerID.Items.Add(cmbCustomerID.Text);
                lblCustomerName.Text += reader[7].ToString();

                for (int i = 0; i < 3; i++)
                    original[i] = reader[i + 4].ToString();
            }
            reader.Close();
            dbConnection.Close();

            LoadCmbOrderNum();
        }

        private void LoadShipmentInfo(int ordNum)
        {
            dbConnection.Open();
            SqlCommand cmdGetShipmentInfo = dbConnection.CreateCommand();
            cmdGetShipmentInfo.CommandText = @"SELECT dbo.Shipment.*
                                               FROM dbo.Shipment JOIN dbo.[Order] ON dbo.[Order].ShipmentNumber = dbo.Shipment.ShipNumber
                                               WHERE dbo.[Order].OrderNumber = @ordNum";
            cmdGetShipmentInfo.Parameters.AddWithValue("ordNum", ordNum);
            SqlDataReader reader = cmdGetShipmentInfo.ExecuteReader();
            if (reader.Read())
            {
                // shipto, shipfrom, shipdate, shiparrive, ship#
                txtShipTo.Text = reader[0].ToString();
                txtShipFrom.Text = reader[1].ToString();
                txtShipDate.Text = reader[2].ToString();
                txtShipArriveDate.Text = reader[3].ToString();
                cmbShipNum.Text = reader[4].ToString();
            }
            reader.Close();
            dbConnection.Close();
        }

        private void GetShipNum()
        {
            dbConnection.Open();
            SqlCommand cmdGetShipNum = dbConnection.CreateCommand();
            cmdGetShipNum.CommandText = @"SELECT max(ShipNumber) + 1 FROM dbo.Shipment";
            SqlDataReader reader = cmdGetShipNum.ExecuteReader();
            if (reader.Read())
                shipNum = reader.GetInt32(0);
            else
                MessageBox.Show("Error: unable to get current shipment's #", "Error");
            reader.Close();
            dbConnection.Close();
        }

        private void LoadCmbShipNum(int custID)
        {
            bool connectionOpen = false;
            cmbShipNum.Items.Clear();
            cmbShipNum.Text = "";
            if (dbConnection.State != ConnectionState.Closed)
            {
                dbConnection.Close();
                connectionOpen = true;
            }
            dbConnection.Open();
            SqlCommand cmdGetShipNums = dbConnection.CreateCommand();
            cmdGetShipNums.CommandText = @"SELECT ShipmentNumber FROM dbo.[Order] WHERE CustomerID = @custID AND ShipmentNumber IS NOT NULL";
            cmdGetShipNums.Parameters.AddWithValue("custID", custID);
            SqlDataReader reader = cmdGetShipNums.ExecuteReader();
            while (reader.Read())
                cmbShipNum.Items.Add(reader[0].ToString());
            reader.Close();
            dbConnection.Close();
            //if (cmbShipNum.Items.Count == 0)
            //{
            //    GetShipNum();
            //    lblUpdateShipment.Text = shipNum.ToString();
            //    cmbShipNum.Text = shipNum.ToString();
            //    cmbShipNum.Items.Add(cmbShipNum);
            //}

            if (connectionOpen)
            {
                dbConnection.Open();
            }
        }

        private void LoadCmbCustomerID()
        {
            dbConnection.Open();
            SqlCommand cmdGetCustomerIDs = dbConnection.CreateCommand();
            if (lblUpdateShipment.Visible)
                cmdGetCustomerIDs.CommandText = @"SELECT DISTINCT(ID) FROM dbo.Customer JOIN dbo.[Order] ON ID = CustomerID WHERE ShipmentNumber IS NOT NULL";
            else
                cmdGetCustomerIDs.CommandText = @"SELECT DISTINCT(ID) FROM dbo.Customer JOIN dbo.[Order] ON ID = CustomerID WHERE ShipmentNumber IS NULL";
            SqlDataReader reader = cmdGetCustomerIDs.ExecuteReader();
            if (lblUpdateShipment.Visible)
                reader.Read(); //bug: reader in loop returns first(?) ID in db without this line
            while (reader.Read())
            {
                //lblUpdateShipment.Text += reader[0].ToString(); 
                cmbCustomerID.Items.Add(reader[0].ToString());
            }
            reader.Close();
            dbConnection.Close();
        }

        private void LoadCmbOrderNum()
        {
            if (!setup)
            {
                cmbOrderNum.Items.Clear();
                cmbOrderNum.Text = "";
            }

            dbConnection.Open();
            SqlCommand cmdGetCustomerOrders = dbConnection.CreateCommand();
            if (lblUpdateShipment.Visible)
                cmdGetCustomerOrders.CommandText = @"SELECT OrderNumber FROM dbo.[Order] WHERE CustomerID = @custID AND ShipmentNumber IS NOT NULL";
            else
                cmdGetCustomerOrders.CommandText = @"SELECT OrderNumber FROM dbo.[Order] WHERE CustomerID = @custID AND ShipmentNumber IS NULL";
            cmdGetCustomerOrders.Parameters.AddWithValue("custID", int.Parse(cmbCustomerID.Text));
            SqlDataReader reader = cmdGetCustomerOrders.ExecuteReader();
            while (reader.Read())
                cmbOrderNum.Items.Add(reader[0].ToString());
            reader.Close();
            dbConnection.Close();
        }

        private void cmbCustomerID_TextChanged(object sender, EventArgs e)
        {
            bool connectionOpen = false;

            if (!setup && cmbCustomerID.Items.Contains(cmbCustomerID.Text))
            {
                if (dbConnection.State != ConnectionState.Closed)
                {
                    dbConnection.Close();
                    connectionOpen = true;
                }

                dbConnection.Open();
                SqlCommand cmdGetCustomerName = dbConnection.CreateCommand();
                cmdGetCustomerName.CommandText = @"SELECT Name, Address FROM dbo.Customer WHERE ID = @id";
                cmdGetCustomerName.Parameters.AddWithValue("id", cmbCustomerID.Text);
                SqlDataReader reader = cmdGetCustomerName.ExecuteReader();
                if (reader.Read())
                {
                    lblCustomerName.Text = "Customer Name: " + reader[0].ToString();
                    txtShipTo.Text = reader[1].ToString();
                }
                else if (cmbCustomerID.Focused)
                    MessageBox.Show("Error: unable to get customer name for selected customer #", "Error");
                reader.Close();
                dbConnection.Close();
            }
            else
                lblCustomerName.Text = "Customer Name: ";

            if (!setup && !lblCustomerName.Text.Equals(""))
            {
                if (lblUpdateShipment.Visible)
                    LoadCmbShipNum(int.Parse(cmbCustomerID.Text));
                LoadCmbOrderNum();
            }

            if (connectionOpen)
                dbConnection.Open();
        }

        private void cmbShipNum_TextChanged(object sender, EventArgs e)
        {
            bool connectionOpen = false;

            if (!setup && cmbShipNum.Items.Contains(cmbShipNum.Text))
            {
                shipNum = int.Parse(cmbShipNum.Text);

                if (dbConnection.State != ConnectionState.Closed)
                {
                    dbConnection.Close();
                    connectionOpen = true;
                }

                dbConnection.Open();
                SqlCommand cmdGetCustomerName = dbConnection.CreateCommand();
                cmdGetCustomerName.CommandText = @"SELECT ID, Name FROM dbo.Customer JOIN dbo.[Order] ON ID = CustomerID
                                                                                     JOIN dbo.Shipment ON ShipmentNumber = ShipNumber
                                                                                     WHERE ShipNumber = @shipNum";
                cmdGetCustomerName.Parameters.AddWithValue("shipNum", shipNum);
                SqlDataReader reader = cmdGetCustomerName.ExecuteReader();
                if (reader.Read())
                {
                    cmbCustomerID.Text = reader[0].ToString();
                    lblCustomerName.Text = "Customer Name: " + reader[1].ToString();
                }
                else if (cmbShipNum.Focused)
                    MessageBox.Show("Error: unable to get customer info for selected ship #", "Error");
                reader.Close();
                dbConnection.Close();
            }
            else
                lblCustomerName.Text = "Customer Name: ";

            if (!setup && !lblCustomerName.Text.Equals("") && !cmbShipNum.Focused)
                LoadCmbShipNum(int.Parse(cmbCustomerID.Text));

            if (connectionOpen)
                dbConnection.Open();
        }

        private void cmbOrderNum_LostFocus(object sender, EventArgs e)
        {
            if (!setup && cmbOrderNum.Text.Length >= 6 && !ordNum.ToString().Equals(cmbOrderNum.Text))
            {
                ordNum = int.Parse(cmbOrderNum.Text);

                dbConnection.Open();
                SqlCommand cmdGetCustomerInfo = dbConnection.CreateCommand();
                cmdGetCustomerInfo.CommandText = @"SELECT ID, Name FROM dbo.Customer JOIN dbo.[Order] ON ID = CustomerID WHERE OrderNumber = @ordNum";
                cmdGetCustomerInfo.Parameters.AddWithValue("ordNum", ordNum);
                SqlDataReader reader = cmdGetCustomerInfo.ExecuteReader();
                if (reader.Read())
                {
                    cmbCustomerID.Text = reader[0].ToString();
                    //lblCustomerName.Text = "Customer Name: " + reader[1].ToString();
                }
                else
                    MessageBox.Show("Error: unable to get customer info for typed order #", "Error");
                reader.Close();
                dbConnection.Close();

                LoadCmbOrderNum();
                cmbOrderNum.Text = "" + ordNum;
                LoadShipmentInfo(ordNum);
            }
        }

        private void btnSaveShipment_Click(object sender, EventArgs e)
        {
            // shipto, shipfrom, shipdate, shiparrive, ship#
            string message = "added.";

            dbConnection.Open();
            SqlCommand cmdSaveShipment = dbConnection.CreateCommand();
            if (lblUpdateShipment.Visible)
            {
                cmdSaveShipment.CommandText = @"UPDATE dbo.Shipment 
                                                SET ShipTo = @to, ShipFrom = @from, ShipDate = @date, ShipArriveDate = @arrive, ShipNumber = @shipNum
                                                FROM dbo.Shipment JOIN dbo.[Order] ON ShipNumber = ShipmentNumber
                                                WHERE ShipNumber = @oldShipNum";
                cmdSaveShipment.Parameters.AddWithValue("oldShipNum", original[0]);
                message = "updated.";
            }
            else
            {
                //dbConnection.Close();
                //GetShipNum();
                cmdSaveShipment.CommandText = @"INSERT INTO dbo.Shipment VALUES (@to, @from, @date, @arrive, @shipNum)";
                //dbConnection.Open();
            }
            cmdSaveShipment.Parameters.AddWithValue("to", txtShipTo.Text);
            cmdSaveShipment.Parameters.AddWithValue("from", txtShipFrom.Text);
            if (txtShipArriveDate.Text.Equals(""))
                cmdSaveShipment.Parameters.AddWithValue("arrive", DateTime.Now.AddMonths(1).ToString("M-dd-yyyy"));
            else
                cmdSaveShipment.Parameters.AddWithValue("arrive", txtShipArriveDate.Text);
            if (txtShipDate.Text.Equals(""))
                cmdSaveShipment.Parameters.AddWithValue("date", DateTime.Now.ToString("M-dd-yyyy"));
            else
                cmdSaveShipment.Parameters.AddWithValue("date", txtShipDate.Text);
            cmdSaveShipment.Parameters.AddWithValue("shipNum", shipNum);

            if (lblUpdateShipment.Visible)
            {
                if (!original[0].Equals(shipNum) || !original[1].Equals(ordNum + "") || !original[2].Equals(cmbCustomerID.Text))
                    UpdateOrder();
            }

            cmdSaveShipment.ExecuteNonQuery();

            if (lblAddShipment.Visible)
            {
                UpdateOrder();
            }

            dbConnection.Close();

            MessageBox.Show("shipment has been " + message);

        }

        private void UpdateOrder()
        {
            SqlCommand cmdUpdateOrder = dbConnection.CreateCommand();
            cmdUpdateOrder.CommandText = @"UPDATE dbo.[Order] SET CustomerID = @custID, ShipmentNumber = @shipNum WHERE OrderNumber = @ordNum";
            cmdUpdateOrder.Parameters.AddWithValue("custID", int.Parse(cmbCustomerID.Text));
            cmdUpdateOrder.Parameters.AddWithValue("shipNum", shipNum);
            cmdUpdateOrder.Parameters.AddWithValue("ordNum", ordNum);
            cmdUpdateOrder.ExecuteNonQuery();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CRUDShipments frm = new CRUDShipments();
            frm.Show();
            this.Close();
        }

        private void Form_Clicked(object sender, EventArgs e)
        {
            cmbShipNum.Focus();
            //lblUpdateShipment.Text = "" + txtOrderNum.Focused;
        }
    }
}
