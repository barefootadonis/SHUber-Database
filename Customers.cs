using Microsoft.Data.Sqlite;
using System.Data;

namespace Task_3
{
    public partial class Customers : Form
    {
        string connection = @"Data Source = Task 2.db";
        public Customers()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            SqliteConnection conn = new SqliteConnection(connection);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Cust_ID, Cust_Fname, Cust_Lname, Cust_Email, Cust_TelNo FROM Customer";

            using var reader = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(reader);

            dgvCustomers.DataSource = dt;
            conn.Close();
        }


        private void lblCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        private void clearTextFields()
        {
            txtCustomerID.Text = "";
            txtCustFirstName.Text = "";
            txtCustLastName.Text = "";
            txtCustEmail.Text = "";
            txtCustTelNo.Text = "";
        }

        private void AmendDatabase(string txtQuery)
        {
            SqliteConnection conn = new SqliteConnection(connection);
            conn.Open();
            string query = txtQuery;
            SqliteCommand cmd = new SqliteCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            clearTextFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nextCustID = GenerateNextCustomerID();

            string addQuery = $"INSERT INTO Customer (Cust_ID, Cust_Fname, Cust_Lname, Cust_Email, Cust_TelNo) " +
                "VALUES ('" + nextCustID + "', '" + txtCustFirstName.Text + "', '" + txtCustLastName.Text + "', '" + txtCustEmail.Text + "', '" + txtCustTelNo.Text + "')";
            AmendDatabase(addQuery);
            LoadCustomer();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerID.Text = dgvCustomers.SelectedRows[0].Cells[0].Value.ToString();
            txtCustFirstName.Text = dgvCustomers.SelectedRows[0].Cells[1].Value.ToString();
            txtCustLastName.Text = dgvCustomers.SelectedRows[0].Cells[2].Value.ToString();
            txtCustEmail.Text = dgvCustomers.SelectedRows[0].Cells[3].Value.ToString();
            txtCustTelNo.Text = dgvCustomers.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string editQuery = "UPDATE Customer SET Cust_Fname = '" + txtCustFirstName.Text + "', " + "Cust_Lname = '" + txtCustLastName.Text + "', " + "Cust_Email = '" + txtCustEmail.Text + "', " + "Cust_TelNo = '" + txtCustTelNo.Text + "' " + "WHERE Cust_ID = '" + txtCustomerID.Text + "'";
            AmendDatabase(editQuery);
            LoadCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM Customer WHERE Cust_ID = '" + txtCustomerID.Text + "'";
            AmendDatabase(deleteQuery);
            LoadCustomer();
        }

        private string GenerateNextCustomerID()
        {
            using var conn = new SqliteConnection(connection);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Cust_ID FROM Customer ORDER BY Cust_ID DESC LIMIT 1";

            var result = cmd.ExecuteScalar();

            if (result == null || result == DBNull.Value)
            {
                return "CUST001";
            }

            string lastID = result.ToString();
            int number = int.Parse(lastID.Substring(4));
            number++;
            return "CUST" + number.ToString("D3");
        }

    }
}
