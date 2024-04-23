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
    public partial class selectservice : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";


        private string selectQuery = "SELECT * FROM Dental_services";
        public string SelectedDetails { get; private set; }
        public selectservice()
        {
            InitializeComponent();
        }

        private void Loaddata()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {

                        connection.Open();
                        DataTable dataTable = new DataTable();


                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }


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
            if (e.RowIndex >= 0)
            {

                SelectedDetails = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                Close();


            }
        }

        private void selectservice_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
    }
}
