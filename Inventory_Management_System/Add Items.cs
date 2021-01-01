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
   
    public partial class Add_Items : Form
    {
        LoginForm log = new LoginForm();
        StockDatabase stock = new StockDatabase(); 
        //string con = LoginForm.connectionString;
        SqlConnection connection;
       
        public Add_Items()
        {
            InitializeComponent();
        }

        public string connectionString = ConfigurationManager.ConnectionStrings["dbString"].ConnectionString;
        private void buttonItemAdd_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            insert_data();
        }
        public void insert_data()
        {
            try
            {

                SqlCommand sqlCommand = new SqlCommand("Insert into Stock (ItemId, ItemName, CompanyName, Price, TotalQuantity, AvailQuantity) Values (@ItemId,@ItemName,@CompanyName,@Price, @TotalQuantity,@AvailQuantity)", connection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@ItemId", textBoxItemId.Text);
                sqlCommand.Parameters.AddWithValue("@ItemName", textBoxItemName.Text);
                sqlCommand.Parameters.AddWithValue("@CompanyName", textBoxCompany.Text);
                sqlCommand.Parameters.AddWithValue("@Price", textBoxPrice.Text);
                sqlCommand.Parameters.AddWithValue("@TotalQuantity", textBoxQuantity.Text);
                sqlCommand.Parameters.AddWithValue("@AvailQuantity", textBoxQuantity.Text);
                connection.Open();
                
                int rows = sqlCommand.ExecuteNonQuery();

                //If the query is executed Successfully then the value to rows will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    ShowStock();
                    //Query Sucessfull
                    MessageBox.Show("New Item added sucessfully in the stock");
                    
                }
                else
                {
                    //Query Failed
                    MessageBox.Show("New Item couldnot be added in the stock");
                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void ShowStock()
        {

            DataTable data_Table = SelectStock();
            dataGridView1.DataSource = data_Table;
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Items_Load(object sender, EventArgs e)
        {
            ShowStock();
        }
        #region Select Method for product module
        public DataTable SelectStock()
        {
            //create sql connection to connect to database 
            SqlConnection conn = new SqlConnection(connectionString);

            //datatable to hold data from database
            DataTable dt = new DataTable();
            try
            {
                //Wrting the query to select all the products from database
                String sql = "Select * from Stock";

                //Creating SQL Command to evaluate Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Sql Data adapter to hold the value of the db temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open database connection 
                conn.Open();

                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
#endregion
    }
}
