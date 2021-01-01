using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;


namespace Inventory_Management_System
{
    public partial class LoginForm : Form
    {
        
        SqlConnection connection;
        SqlCommand command;
        public LoginForm()
        {
             

            InitializeComponent();
            
            
        }
        public static string connectionString = ConfigurationManager.ConnectionStrings["dbString"].ConnectionString;

        Users user = new Users();
        UsersDatabase userdata = new UsersDatabase();
        public static string loggedIn;
        private void pboxClose_Click(object sender, EventArgs e)
        {
            // code to close this form 
            this.Close();

        }

        

        private void LoginForm_Load(object sender, EventArgs e)
        {
           

        }

        public void insert_data()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Insert into users (id, username, password, usertype) Values (@id,@username,@password,@usertype)", connection);
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.AddWithValue("@username", textBoxUserName.Text);
                sqlCommand.Parameters.AddWithValue("@password", textBoxPassword.Text);
                sqlCommand.Parameters.AddWithValue("@usertype", comboBoxUserType.Text);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                //status.Text = "inserted";
                Show_All_Data();
            }
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            user.username = textBoxUserName.Text.Trim();
            user.password = textBoxPassword.Text.Trim();
            user.user_type = comboBoxUserType.Text.Trim();

            //checking the login credentials

            bool success = userdata.loginCheck(user);
            if (success == true)
            {
                //login success
                MessageBox.Show("Login Successful");
                loggedIn = user.username;
                // open respective forms based on user type 
                switch (user.user_type)
                {
                    case "admin":
                        {
                            //display Admin Dashboard
                            Dashboard admin = new Dashboard();
                            admin.Show();
                            this.Hide();

                        }
                        break;
                    case "user":
                        {
                            //display User dashboard
                            // frmUserDashBoard user = new frmUserDashBoard();
                            MessageBox.Show("User Form not availble.");
                            // user.Show();
                            // this.Hide();
                        }
                        break;
                    default:
                        {
                            //display error message
                            MessageBox.Show("Invalid User Type.");
                        }
                        break;
                }

            }
            else
            {
                // login failed 
                MessageBox.Show("Login Failed. Try Again");

            }

        }

        public void Show_All_Data()
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand("select * from users", connection);
            DataTable data_Table = new DataTable();
            connection.Open();
            SqlDataReader sqlDataReader = command.ExecuteReader();
            data_Table.Load(sqlDataReader);
            connection.Close();
            //dataGridView1.DataSource = data_Table;
            sqlDataReader.Close();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            dashboard.Show();
            
        }
    }
}
