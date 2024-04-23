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

namespace DC
{
    public partial class Services : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";

        // SQL query to select data from your table
        private string selectQuery = "SELECT * FROM Dental_services";
        public Services()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                // Create a connection 
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create a SqlCommand 
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {

                        connection.Open();
                        DataTable dataTable = new DataTable();


                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Services_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoginUserControl_LoginSuccess(object sender, EventArgs e)
        {
            // If login is successful, open the desired form
            Addservices newservice = new Addservices();
            newservice.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loginControl loginForm = new loginControl();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // If login is successful, open the registration form
                // (Replace this with your registration form opening logic)
                MessageBox.Show("Login successful....");

                Addservices newservice = new Addservices();
                newservice.Show();
            }
            else
            {
                // Handle login failure (optional)
                MessageBox.Show("Login failed. Please try again.");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginControl loginForm = new loginControl();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // If login is successful, open the registration form
                // (Replace this with your registration form opening logic)
                MessageBox.Show("Login successful....");

                Editservices newservice = new Editservices();
                newservice.Show();
            }
            else
            {
                // Handle login failure (optional)
                MessageBox.Show("Login failed. Please try again.");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
