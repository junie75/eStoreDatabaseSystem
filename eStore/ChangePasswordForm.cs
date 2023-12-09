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
using System.Diagnostics.Eventing.Reader;

namespace eStore
{
    public partial class ChangePasswordForm : Form
    {
        public SqlConnection DBConnection;
        public string username = Globals.username;
        private HomeScreenForm  homeScreen = new HomeScreenForm();

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

            helloLabel.Text = "Hello, " + this.username;
                
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string oldPasswordBox = OldPasswordBox.Text;
            string newPasswordBox = NewPasswordBox.Text;
            string confirmBox = ConfirmBox.Text;

            SqlCommand command = new SqlCommand("SELECT Username, Password FROM Login WHERE Username = @username AND Password = @password", DBConnection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", oldPasswordBox);

            DBConnection.Open(); // open
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            { 
                if(newPasswordBox == confirmBox && newPasswordBox != "")
                {
                    reader.Close();
                    SqlCommand command2 = new SqlCommand("UPDATE Login SET Password = @newPassword WHERE Username = @Username", DBConnection);
                    command2.Parameters.AddWithValue("@Username", username);
                    command2.Parameters.AddWithValue("@newPassword", confirmBox);
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Password has been updated.");
                    homeScreen.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("New password does not match. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect old password. Please try again.");
            }

            reader.Close();
            DBConnection.Close();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            homeScreen.Show();
            this.Close();
        }

    }
}
