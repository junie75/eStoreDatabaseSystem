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
    public partial class CUCustomer : Form
    {
        int custID;
        public CUCustomer(int custID = -1)
        {
            InitializeComponent();

            this.custID = custID;

            if (custID > 0)
            {
                lblAddCustomer.Visible = false;
                btnAddUpdate.Text = "Update";
                LoadCustInfo();
            }
            else
                lblUpdateCustomer.Visible = false;
        }

        private void GetCustID()
        {
            dbConnection.Open();
            SqlCommand cmdGetCustID = dbConnection.CreateCommand();
            cmdGetCustID.CommandText = @"SELECT max(ID) + 1 FROM dbo.Customer";
            SqlDataReader reader = cmdGetCustID.ExecuteReader();
            if (reader.Read())
                custID = reader.GetInt32(0);
            else
                MessageBox.Show("Error: unable to get current customer's #", "Error");
            reader.Close();
            dbConnection.Close();
        }

        private void LoadCustInfo()
        {
            string fullName = "", email = "", phone = "", address = "";

            dbConnection.Open();
            SqlCommand cmdGetCustomerInfo = dbConnection.CreateCommand();
            cmdGetCustomerInfo.CommandText = @"SELECT dbo.[Customer].*, UserName, Password FROM dbo.[Customer] JOIN dbo.Login ON ID = CustomerID WHERE ID = @id";
            cmdGetCustomerInfo.Parameters.AddWithValue("id", custID);
            SqlDataReader reader = cmdGetCustomerInfo.ExecuteReader();
            if (reader.Read())
            {
                // full name, email, phone, address
                fullName = reader[0].ToString();
                email = reader[1].ToString();
                phone = reader[2].ToString();
                address = reader[3].ToString();
                txtUser.Text = reader[5].ToString();
                txtPass.Text = reader[6].ToString();
            }
            reader.Close();
            dbConnection.Close();

            int firstSpace = fullName.IndexOf(' ');
            txtFname.Text = fullName.Substring(0, firstSpace);
            txtLName.Text = fullName.Substring(firstSpace + 1);
            txtPhone.Text = phone;
            txtAddress.Text = address;
            txtEmail.Text = email;
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            string phone = "", email, address, name;
            string message = "added.";

            name = txtFname.Text + " " + txtLName.Text;
            address = txtAddress.Text;

            string[] phoneParts = txtPhone.Text.Split("()- ".ToCharArray());
            foreach (string part in phoneParts)
            {
                phone += part;
            }
            if (phone.IndexOfAny("abcdefghijklmnopqrstuvwxyz".ToCharArray()) != -1 || phone.Length != 10)
            {
                MessageBox.Show("invalid phone number");
                return;
            }
            phone = phone.Substring(0, 3) + "-" + phone.Substring(3, 3) + "-" + phone.Substring(6);

            email = txtEmail.Text.Trim();
            if (!email.Contains("@") || !email.Contains(".") || email.IndexOf('@') > email.LastIndexOf('.') || email.LastIndexOf('.') == email.IndexOf('@') + 1)
            {
                MessageBox.Show("invalid email");
                return;
            }
            string emailFirstPart = email.Substring(0, email.IndexOf('@'));
            string emailLastPart = email.Substring(email.LastIndexOf('.'));
            if (emailFirstPart.Length == 0 || emailLastPart.Length == 0)
            {
                MessageBox.Show("invalid email");
                return;
            }

            dbConnection.Open();

            SqlCommand cmdSaveCustomer1 = dbConnection.CreateCommand();
            SqlCommand cmdSaveCustomer2 = dbConnection.CreateCommand();
            if (custID > 0)
            {
                cmdSaveCustomer1.CommandText = @"UPDATE dbo.Customer SET Name = @name, Email = @email, Phone = @phone, Address = @addr WHERE ID = @id";
                cmdSaveCustomer2.CommandText = @"UPDATE dbo.Login SET Username = @user, Password = @pass WHERE CustomerID = @id";
                message = "updated.";
            }
            else
            {
                dbConnection.Close();
                GetCustID();
                cmdSaveCustomer1.CommandText = @"INSERT INTO dbo.Customer VALUES (@name, @email, @phone, @addr, @id)";
                cmdSaveCustomer2.CommandText = @"INSERT INTO dbo.Login VALUES (@user, @pass, 0, @id)";
                dbConnection.Open();
            }
            cmdSaveCustomer1.Parameters.AddWithValue("name", name);
            cmdSaveCustomer1.Parameters.AddWithValue("email", email);
            cmdSaveCustomer1.Parameters.AddWithValue("phone", phone);
            cmdSaveCustomer1.Parameters.AddWithValue("addr", address);
            cmdSaveCustomer1.Parameters.AddWithValue("id", custID);
            cmdSaveCustomer2.Parameters.AddWithValue("user", txtUser.Text);
            cmdSaveCustomer2.Parameters.AddWithValue("pass", txtPass.Text);
            cmdSaveCustomer2.Parameters.AddWithValue("id", custID);
            cmdSaveCustomer1.ExecuteNonQuery();
            cmdSaveCustomer2.ExecuteNonQuery();

            dbConnection.Close();

            MessageBox.Show("customer has been " + message);
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            CRUDCustomers frm = new CRUDCustomers();
            frm.Show();
            this.Close();
        }
    }
}
