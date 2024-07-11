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

namespace KT_ICT365_Assign1
{
    public partial class RentForm : Form
    {
        public RentForm()
        {
            InitializeComponent();
        }

        // Connects to the DB and does the queries
        public int doSQL(string query)
        {
            // Connect to DB
            SqlConnection connection = new SqlConnection("Data Source=DRM22;Initial Catalog=ICT365;Integrated Security=True");
            connection.Open();

            // Make and Execute SQL Query
            SqlCommand command = new SqlCommand(query, connection);
            int rows = command.ExecuteNonQuery();
            connection.Close();

            // Returns affected rows from the SQL Query
            return rows;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm Form = new HomeForm();
            Form.ShowDialog();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset text boxes to empty or values to 0
            txtBox_UniqBookNum.Text = "";
            txtBox_VehicleID.Text = "";
            txtBox_CustSocSecNum.Text = "";
            numUpDown_Miles.Value = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check if values are valid
            string uniqBookNum = txtBox_UniqBookNum.Text;
            string vehicleID = txtBox_VehicleID.Text;
            string custSocSecNum = txtBox_CustSocSecNum.Text;
            int miles = Decimal.ToInt32(numUpDown_Miles.Value);

            // empty or 0 values
            if (String.IsNullOrEmpty(uniqBookNum) || String.IsNullOrEmpty(vehicleID) || String.IsNullOrEmpty(custSocSecNum) || miles == 0)
            {
                MessageBox.Show("One or more text boxes are empty or a value of 0. Please try again", "Invalid Input");
            }
            else
            {
                // save to database
                if (doSQL($"INSERT INTO Ass1_Rents VALUES ('{uniqBookNum}', '{vehicleID}', '{custSocSecNum}', '{datePicker_Rental.Value}', {miles});") > 0)
                {
                    MessageBox.Show("Rent Success!");
                }
                else
                {
                    MessageBox.Show("Error: Rent");
                }
            }
        }
    }
}
