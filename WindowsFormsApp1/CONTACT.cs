using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Contact_Classes;

namespace WindowsFormsApp1
{
    public partial class CONTACT : Form
    {
        public CONTACT()
        {
            InitializeComponent();
        }

        contactClass c = new contactClass();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_onclk_Click(object sender, EventArgs e)
        {
            //get the value from the input fields
            c.firstName = IFirstName.Text;
            c.lastName = ILastName.Text;
            c.contactNo = IContactNo.Text;
            c.address = IAddress.Text;
            c.gender = SGender.Text;

            //inserting data into DB using the method we created 
            bool success = c.Insert(c);
            if(success == true)
            {
                //successfully inserted
                MessageBox.Show("New Contact Successfully Inserted");
                // Call the method clear
                Clear();
            }
            else
            {
                //failed to add contact
                MessageBox.Show("Failed to Add New Contact. Try Again !!!");

            }
            // Load data on data grid view
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

        }
        private void CONTACT_Load(object sender, EventArgs e)
        {
            // Load data on data grid view
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method to Clear fields
        public void Clear()
        {
            IFirstName.Text = "";
            ILastName.Text = "";
            IContactNo.Text = "";
            IAddress.Text = "";
            SGender.Text = "";
            IContactID.Text = "";

        }

        private void btnUpdate_onclk_Click(object sender, EventArgs e)
        {
            // Get dta from text boxes
            c.ContactID = int.Parse(IContactID.Text);
            c.firstName = IFirstName.Text;
            c.lastName = ILastName.Text;
            c.contactNo = IContactNo.Text;
            c.address = IAddress.Text;
            c.gender = SGender.Text;
            //Update data in database 
            bool success = c.Update(c);
            if(success == true)
            {
                // Updated successfully
                MessageBox.Show("Contact has been updated successfully.");
                // Load data on data grid view
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //Call Clear
                Clear();
            }
            else
            {
                // Failed to update
                MessageBox.Show("Failed to Update contact.");
            }
        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // GEt  the data from grid view into the text boxes respectively
            // Identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            IContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            IFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            ILastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            IContactNo.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            IAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            SGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnClear_onclk_Click(object sender, EventArgs e)
        {
            // call  clear method
            Clear();
        }

        private void btnDelete_onclk_Click(object sender, EventArgs e)
        {
            // get data frm the text boxes
            c.ContactID = Convert.ToInt32(IContactID.Text);
            bool success = c.Delete(c);
            if(success == true)
            {
                // Successfully deleated
                MessageBox.Show("Data Deleted");
                // Load data on data grid view
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                // failed to deleted
                MessageBox.Show("Can not delete. try again");
            }
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void ISearch_TextChanged(object sender, EventArgs e)
        {
            // get the value from text box search
            string keyword = ISearch.Text;

            SqlConnection conn = new SqlConnection();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TBL_Contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }
    }
}
