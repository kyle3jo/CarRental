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
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();

            getData("Ass1_Rents", grid_Rent);
            getData("Ass1_Returns", grid_Return);
            getData("Ass1_Customers", grid_Customer);
            getData("Ass1_Cars", grid_Car);
        }

        public void getData(string table, DataGridView grid)
        {
            DataTable dataTable = new DataTable();

            // Connect to DB
            SqlConnection connection = new SqlConnection("Data Source=DRM22;Initial Catalog=ICT365;Integrated Security=True");
            connection.Open();

            // Make and Execute SQL Query
            SqlCommand command = new SqlCommand($"SELECT * FROM {table}", connection);
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            grid.DataSource = dataTable;

        }

            private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm Form = new HomeForm();
            Form.ShowDialog();
            this.Close();
        }
    }
}
