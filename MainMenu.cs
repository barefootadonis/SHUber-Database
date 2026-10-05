namespace Task_3
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers customersform = new Customers();
            customersform.ShowDialog();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drivers driverform = new Drivers();
            driverform.ShowDialog();
        }
    }
}
