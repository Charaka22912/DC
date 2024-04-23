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
    public partial class Selectpatient : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";

        // SQL query to select data from your table
        private string selectQuery = "SELECT * FROM Patients";
        public string SelectedDetails { get; private set; }
        public Selectpatient()
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

        private void Selectpatient_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure a valid row is clicked
            {
                // Assuming the first column of the DataGridView contains the details
                SelectedDetails = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                Close();


            }
        }
    }
}
