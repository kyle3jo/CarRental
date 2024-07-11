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
    public partial class CustomerRegistrationForm : Form
    {
        public CustomerRegistrationForm()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check if values are valid
            string title = cmboBox_Title.Text;
            string firstname = txtBox_FirstName.Text;
            string surname = txtBox_SurName.Text;
            string area = txtBox_Area.Text;
            int postcode = Decimal.ToInt32(numUpDown_Postcode.Value);
            string city = txtBox_City.Text;
            string country = txtBox_Country.Text;

            // empty or 0 values
            if (String.IsNullOrEmpty(title) || String.IsNullOrEmpty(firstname) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(area) || postcode == 0 || String.IsNullOrEmpty(city) || String.IsNullOrEmpty(country))
            {
                MessageBox.Show("One or more text boxes are empty or a value of 0. Please try again", "Invalid Input");
            }
            else
            {
                // save to database
                if (doSQL($"INSERT INTO Ass1_Customers VALUES ('{title}', '{firstname}', '{surname}', '{area}', {postcode}, '{city}', '{country}');") > 0)
                {
                    MessageBox.Show("Customer Registration Added!");
                }
                else
                {
                    MessageBox.Show("Error: Customer Registration");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset text boxes to empty or values to 0
            cmboBox_Title.Text = "";
            txtBox_FirstName.Text = "";
            txtBox_SurName.Text = "";
            txtBox_Area.Text = "";
            numUpDown_Postcode.Value = 0;
            txtBox_City.Text = "";
            txtBox_Country.Text = "";
        }
    }
}
