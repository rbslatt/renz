using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ACT1E_CRUD
{
    //REGISTER.CS
    public partial class register : Form
    {
        private MySqlConnection connection;
        public register()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=renzdb;username=root;password=;");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 loginpage = new Form1();
            loginpage.Show();
            this.Hide();
        }
        private void txtname_TextChanged(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string username = txtpassword.Text;
            string password = txtusername.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter both name, username and password");
            }
            try
            {
                connection.Open();
                string registerquery = "INSERT INTO user (username, password, name) VALUE (@username, @password, @name)";
                MySqlCommand command = new MySqlCommand(registerquery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int rowaffected = command.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Account Successfully Registered!");
                }
                else
                {
                    MessageBox.Show("Epwedi ing Account mu!, Mulit nakamu tnx.");
                }
                txtname.Clear();
                txtpassword.Clear();
                txtusername.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //Close Connection
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
