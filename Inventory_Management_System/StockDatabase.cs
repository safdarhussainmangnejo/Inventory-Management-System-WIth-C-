using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    
    class StockDatabase
    {
        Add_Items addItems = new Add_Items();
        
         static string connectionString = ConfigurationManager.ConnectionStrings["dbString"].ConnectionString;
       

        public bool InsertItem(Users Userobj)
        {
            // create boolean varaible set it to false and return it 
            bool isSuccessful = false;
            //connecting to database
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                //SQL Query to check login
                string sql = "select * from users where username= @username and password=@password and usertype=@usertype";
                //sql command to pass value 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", Userobj.username);
                cmd.Parameters.AddWithValue("@password", Userobj.password);
                cmd.Parameters.AddWithValue("@usertype", Userobj.user_type);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                // Checking the rows in DataTable
                if (dt.Rows.Count > 0)
                {
                    //login sucessful
                    isSuccessful = true;
                }
                else
                {
                    //Login failed
                    isSuccessful = false;
                }

            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }

            return isSuccessful;
        }

        #region Select Method for product module
        public static DataTable Select()
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
