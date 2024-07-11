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
    public partial class CarRegistration : Form
    {
        public CarRegistration()
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
            string engine = txtBox_Engine.Text;
            int regyear = Decimal.ToInt32(num_RegYear.Value);
            string model = txtBox_Model.Text;
            string color = txtBox_Color.Text;
            string trans = cmboBox_Trans.Text;

            // empty or 0 values
            if (String.IsNullOrEmpty(engine) || regyear == 0 || String.IsNullOrEmpty(model) || String.IsNullOrEmpty(color) || String.IsNullOrEmpty(trans))
            {
                MessageBox.Show("One or more text boxes are empty or a value of 0. Please try again", "Invalid Input");
            }
            else
            {
                // save to database
                if (doSQL($"INSERT INTO Ass1_Cars VALUES ('{engine}', {regyear}, '{model}', '{color}', '{trans}');") > 0)
                {
                    MessageBox.Show("Car Registration Success!");
                }
                else
                {
                    MessageBox.Show("Error: Car Registration");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset text boxes to empty or values to 0
            txtBox_Engine.Text = "";
            num_RegYear.Value = 0;
            txtBox_Model.Text = "";
            txtBox_Color.Text = "";
            cmboBox_Trans.Text = "";
        }
    }
}
