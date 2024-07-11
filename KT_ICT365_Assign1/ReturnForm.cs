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
    public partial class ReturnForm : Form
    {
        public ReturnForm()
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset text boxes to empty or values to 0
            txtBox_UniqBookNum.Text = "";
            num_MilesBefore.Value = 0;
            num_MilesAfter.Value = 0;
            cmboBox_CarCategory.Text = "";
            num_DaysRented.Value = 0;
            num_Discount.Value = 0;
            num_TotalCost.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check if values are valid
            string uniqBookNum = txtBox_UniqBookNum.Text;
            int milesBefore = Decimal.ToInt32(num_MilesBefore.Value);
            int milesAfter = Decimal.ToInt32(num_MilesAfter.Value);
            string category = cmboBox_CarCategory.Text;
            int daysRented = Decimal.ToInt32(num_DaysRented.Value);
            int discount = Decimal.ToInt32(num_DaysRented.Value);
            float totalCost = float.Parse(num_TotalCost.Text);

            // empty or 0 values
            if (String.IsNullOrEmpty(uniqBookNum) || milesBefore == 0 || milesAfter == 0 || String.IsNullOrEmpty(category) || daysRented == 0 || discount == 0 || totalCost == 0)
            {
                MessageBox.Show("One or more text boxes are empty or a value of 0. Please try again", "Invalid Input");
            }
            else
            {
                // save to database
                if (doSQL($"INSERT INTO Ass1_Returns VALUES ('{uniqBookNum}', '{datePicker_Return.Value}', {milesBefore}, {milesAfter}, '{category}', {daysRented}, {discount}, {totalCost});") > 0)
                {
                    MessageBox.Show("Return Success!");
                }
                else
                {
                    MessageBox.Show("Error: Return");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm Form = new HomeForm();
            Form.ShowDialog();
            this.Close();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            string category = cmboBox_CarCategory.Text;
            int daysRented = Decimal.ToInt32(num_DaysRented.Value);
            int milesBefore = Decimal.ToInt32(num_MilesBefore.Value);
            int milesAfter = Decimal.ToInt32(num_MilesAfter.Value);
            int discount = Decimal.ToInt32(num_Discount.Value);
            float cost = 0;

            // im assumed cost per km and distance tariff is 1
            if (String.Equals(category, "Hatchback"))
            {

                cost = 20 * daysRented;
            }

            if (String.Equals(category, "Sedan"))
            {

                cost = 40 * daysRented;
            }

            if (String.Equals(category, "Wagon"))
            {

                cost = (float)((70 * daysRented * 1.5 ) + (1 * (milesAfter - milesBefore)));
            }

            if (String.Equals(category, "12-Seater Van"))
            {

                cost = (float)((20 * daysRented * 1.5) + (1 * (milesAfter - milesBefore) * 1));
            }

            if (String.Equals(category, "20-Seater Van"))
            {

                cost = (float)(70 * daysRented * 1.5) + (1 * (milesAfter - milesBefore) * 1);
            }

            if (String.Equals(category, "42-Seater Van"))
            {

                cost = (float)(42 * daysRented * 1.5) + (1 * (milesAfter - milesBefore) * 1);
            }

            if (String.Equals(category, "5-Seater Charter"))
            {

                cost = (float)(275 * (daysRented / 30.4167));
            }

            if (String.Equals(category, "7-Seater Charter"))
            {

                cost = (float)(350 * (daysRented / 30.4167));
            }

            // apply discount if any
            cost = cost - ((discount / 100) * cost);
            // round cost to 2 decimal places
            cost = (float)System.Math.Round(cost, 2);
            // input cost to total cost textbox
            num_TotalCost.Text = cost.ToString();

        }
    }

 
}
