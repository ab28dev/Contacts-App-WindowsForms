using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Contact_Classes
{
    class contactClass
    {
        //getter and setter properies
        //acts as data carier in app
        public int ContactID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string contactNo { get; set; }
        public string address { get; set; }
        public string gender { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        
        // selecting data from database
        public DataTable Select()
        {
            //step 1: Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //step 2: writing sql query
                string sql = "SELECT * FROM TBL_Contact";
                // creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Creating sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        // Inserting data into database
        public bool Insert (contactClass c)
        {
            // creating a default return type and setting its value to false
            bool isSuccess = false;
            //step 1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                // Step 2: create sql query to insert data
                string sql = "INSERT INTO TBL_Contact(firstName, lastName, contactNo, address, gender) VALUES (@firstName, @lastName, @contactNo, @address, @gender)";
                // creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                // create parameters to add data
                cmd.Parameters.AddWithValue("@firstName", c.firstName);
                cmd.Parameters.AddWithValue("@lastName", c.lastName);
                cmd.Parameters.AddWithValue("@contactNo", c.contactNo);
                cmd.Parameters.AddWithValue("@address", c.address);
                cmd.Parameters.AddWithValue("@gender", c.gender);

                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else it will be zero
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //method to update data in our database from our application
        public bool Update(contactClass c)
        {
            //create a default return type and set it to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                // Sql to update data in our database
                string sql = "UPDATE TBL_Contact SET firstName = @firstName, lastname = @lastName, contactNo = @contactNo, address = @address, gender = @gender WHERE ContactID = @ContactID";
                // Sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add value
                cmd.Parameters.AddWithValue("@firstName", c.firstName);
                cmd.Parameters.AddWithValue("@lastName", c.lastName);
                cmd.Parameters.AddWithValue("@contactNo", c.contactNo);
                cmd.Parameters.AddWithValue("@address", c.address);
                cmd.Parameters.AddWithValue("@gender", c.gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                //open database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfull rows will be greater than zero
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                    
            }
            finally
            {
                conn.Close();
            }
                
            return isSuccess;
        }
        //method to delete data from database
        public bool Delete(contactClass c)
        {
            //create a default return value and set it to false
            bool isSuccess = false;
            //create sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                // delete data
                string sql = "DELETE FROM TBL_Contact WHERE ContactID = @ContactID";
                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                // open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully the value of rows will be greater than zero
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                //close connection
                conn.Close();
            }
            return isSuccess;
        }
    }
}
