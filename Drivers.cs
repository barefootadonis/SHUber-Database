using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Drivers : Form
    {
        string connection = @"Data Source = Task 2.db";
        public Drivers()
        {
            InitializeComponent();
        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            LoadDriver();
        }

        private void LoadDriver()
        {
            SqliteConnection conn = new SqliteConnection(connection);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Driver_ID, Driver_Fname, Driver_Lname, Driver_Email, Driver_TelNo FROM Driver";

            using var reader = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(reader);

            dgvDrivers.DataSource = dt;
            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        private void clearTextFields()
        {
            txtDriverID.Text = "";
            txtDriFirstName.Text = "";
            txtDriLastName.Text = "";
            txtDriEmail.Text = "";
            txtDriTelNo.Text = "";
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
            string nextDriID = GenerateNextDriverID();

            string addQuery = $"INSERT INTO Driver (Driver_ID, Driver_Fname, Driver_Lname, Driver_Email, Driver_TelNo) " +
                "VALUES ('" + nextDriID + "', '" + txtDriFirstName.Text + "', '" + txtDriLastName.Text + "', '" + txtDriEmail.Text + "', '" + txtDriTelNo.Text + "')";
            AmendDatabase(addQuery);
            LoadDriver();
        }

        private void dgvDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDriverID.Text = dgvDrivers.SelectedRows[0].Cells[0].Value.ToString();
            txtDriFirstName.Text = dgvDrivers.SelectedRows[0].Cells[1].Value.ToString();
            txtDriLastName.Text = dgvDrivers.SelectedRows[0].Cells[2].Value.ToString();
            txtDriEmail.Text = dgvDrivers.SelectedRows[0].Cells[3].Value.ToString();
            txtDriTelNo.Text = dgvDrivers.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string editQuery = "UPDATE Driver SET Driver_Fname = '" + txtDriFirstName.Text + "', " + "Driver_Lname = '" + txtDriLastName.Text + "', " + "Driver_Email = '" + txtDriEmail.Text + "', " + "Driver_TelNo = '" + txtDriTelNo.Text + "' " + "WHERE Driver_ID = '" + txtDriverID.Text + "'";
            AmendDatabase(editQuery);
            LoadDriver();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM Driver WHERE Driver_ID = '" + txtDriverID.Text + "'";
            AmendDatabase(deleteQuery);
            LoadDriver();
        }

        private string GenerateNextDriverID()
        {
            using var conn = new SqliteConnection(connection);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Driver_ID FROM Driver ORDER BY Driver_ID DESC LIMIT 1";

            var result = cmd.ExecuteScalar();

            if (result == null || result == DBNull.Value)
            {
                return "DRV001";
            }

            string lastID = result.ToString();
            int number = int.Parse(lastID.Substring(4));
            number++;
            return "DRV" + number.ToString("D3");
        }
    }
}
