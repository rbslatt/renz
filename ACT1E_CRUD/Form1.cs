using MySql.Data.MySqlClient;
namespace ACT1E_CRUD
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            //Declare variable for connection string
            connection = new MySqlConnection("server=localhost;database=renzdb;username=root;password=;");

        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Create variable username and password
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            //Check if usename and password are not empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password");
            }

            try
            {
                //Login Code
                //open connection
                connection.Open();
                //Create SQL query for login
                string loginquery = "SELECT COUNT(*) FROM user WHERE username = @username AND password = @password";
                //Execute sql command
                MySqlCommand command = new MySqlCommand(loginquery, connection);
                //Sanitize query sql injection
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                //Get Total record
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Successfully login");
                    admin adminpage = new admin();
                    adminpage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username and password");
                }
            }
            catch (Exception ex)
            {
                //display error
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

        private void LinkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register registerpage = new register();
            registerpage.Show();
            this.Hide();
        }
    }
}
