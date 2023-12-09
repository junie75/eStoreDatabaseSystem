using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Console.WriteLine("hello world");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string usernameBox = UsernameTextbox.Text;
            string passwordBox = PasswordTextbox.Text;

            SqlCommand command = new SqlCommand("SELECT Username, Password FROM Login WHERE Username = @username AND Password = @password", sqlConnection1);
            command.Parameters.AddWithValue("@Username", usernameBox);
            command.Parameters.AddWithValue("@Password", passwordBox);
            
            sqlConnection1.Open(); // open
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Successful login, go to home screen
                HomeScreenForm homeScreen = new HomeScreenForm();

                //moving DB connection to the next form
                homeScreen.DBConnection = sqlConnection1;

                //using global variable to establish username
                Globals.username = usernameBox;


                //homeScreen
                homeScreen.Show();
                this.Hide();
                reader.Close();
    

            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
            sqlConnection1.Close(); // close
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Close the entire application
            }
        }
    }
}
