namespace KT_ICT365_Assign1
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentForm Form = new RentForm();
            Form.ShowDialog();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnForm Form = new ReturnForm();
            Form.ShowDialog();
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewReport Form = new ViewReport();
            Form.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRegistrationForm Form = new CustomerRegistrationForm();
            Form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarRegistration Form = new CarRegistration();
            Form.ShowDialog();
            this.Close();
        }
    }
}