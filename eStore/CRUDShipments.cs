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
    public partial class CRUDShipments : Form
    {
        public CRUDShipments()
        {
            InitializeComponent();
        }

        private void CRUDShipments_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection1.Open();

                SqlCommand cmdOrders = DBConnection1.CreateCommand();
                cmdOrders.CommandText = @"SELECT *
                                          FROM Shipment";

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
            CUShipment frm = new CUShipment();
            frm.Show();
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int shipNum = (int)dgvItems.CurrentRow.Cells["ShipNumber"].Value;
            CUShipment frm = new CUShipment(shipNum);
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreenForm frm = new HomeScreenForm();
            frm.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //string Row = dgvItems.CurrentCell.Value.ToString();

            string Row = dgvItems.CurrentRow.Cells["ShipNumber"].Value.ToString();

            SqlCommand cmdDel = DBConnection1.CreateCommand();

            cmdDel.CommandText = @"DELETE

FROM Shipment

WHERE ShipNumber = @br";

            cmdDel.Parameters.AddWithValue("@br", Row);

            SqlDataReader reader1 = cmdDel.ExecuteReader();

            reader1.Close();

            //show that the item has been deleted

            MessageBox.Show("Shipment Deleted", "DB eStore");

            //refresh the data grid view

            SqlCommand cmdRefresh = DBConnection1.CreateCommand();

            cmdRefresh.CommandText = @"SELECT *

FROM Shipment";

            SqlDataReader reader2 = cmdRefresh.ExecuteReader();

            DataTable tempTable = new DataTable();

            tempTable.Load(reader2);

            dgvItems.DataSource = tempTable;

            reader2.Close();
        }
    }
}
