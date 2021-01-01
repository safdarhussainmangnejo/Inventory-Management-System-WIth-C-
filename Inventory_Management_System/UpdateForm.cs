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
    public partial class UpdateForm : Form
    {
        Add_Items displayItems = new Add_Items();

        public UpdateForm()
        {
            InitializeComponent();
        }
        public string connectionString = ConfigurationManager.ConnectionStrings["dbString"].ConnectionString;
        private void buttonItemUpdate_Click(object sender, EventArgs e)
        {
            //create boolean variable and set it to false
           
            // create sql connection to db 
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                // sql query to update data to db
                String sql = "Update Stock set ItemName =@ItemName, CompanyName=@CompanyName, Price=@Price, TotalQuantity=@TotalQuantity, AvailQuantity=@AvailQuantity where ItemId =@ItemId";
               
                // create sql command the value to query
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@ItemId", textBoxID.Text);
                sqlCommand.Parameters.AddWithValue("@ItemName", textBoxName.Text);
                sqlCommand.Parameters.AddWithValue("@CompanyName", textBoxCom.Text);
                sqlCommand.Parameters.AddWithValue("@Price", textBoxPric.Text);
                sqlCommand.Parameters.AddWithValue("@TotalQuantity", textBoxQuan.Text);
                sqlCommand.Parameters.AddWithValue("@AvailQuantity", textBoxQuan.Text);

                //open db connection
                conn.Open();

                // create integer variable to check if the query is excuted successfully or not 
                int rows = sqlCommand.ExecuteNonQuery();
                // if query is excuted successfully then value pf rows will be > 0, else < 0
                if (rows > 0)
                {


                    DataTable dt = displayItems.SelectStock();
                    dataGridViewProducts.DataSource = dt;
                    //Query Sucessfull
                    MessageBox.Show("Item updated sucessfully in the stock");
                }
                else
                {
                    //query failed to excute successfully
                    MessageBox.Show("Item couldnot be updated in the stock");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void buttonItemAdd_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // CLEAR TEXT BOXES
            
            // create int variable to know which product is clicked 
            int rowIndex = e.RowIndex;
            //Display the value of respective text boxes
            this.textBoxItemName.Text = dataGridViewProducts.Rows[rowIndex].Cells[0].Value.ToString();
            this.textBoxItemName.Text = dataGridViewProducts.Rows[rowIndex].Cells[1].Value.ToString();
            this.textBoxCompany.Text = dataGridViewProducts.Rows[rowIndex].Cells[2].Value.ToString();
            this.textBoxPrice.Text = dataGridViewProducts.Rows[rowIndex].Cells[3].Value.ToString();
            this.textBoxQuantity.Text = dataGridViewProducts.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            DataTable dt = displayItems.SelectStock();
            dataGridViewProducts.DataSource = dt;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowStock()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("select * from Stock", connection);
            DataTable data_Table = new DataTable();
            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            data_Table.Load(sqlDataReader);
            connection.Close();
            dataGridViewProducts.DataSource = data_Table;
            sqlDataReader.Close();
        }
    }
    
}
