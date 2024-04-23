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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DC
{
    public partial class Appoinment : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";


        private string selectQuery = "SELECT * FROM Appoinments";
        public string SelectedDetail { get; private set; }
        public Appoinment()
        {
            InitializeComponent();

        }

        private void LoadData()
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

        private void Appoinment_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAppoinment add1 = new AddAppoinment();
            add1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string PatientID = textBox1.Text.Trim();

            string query = "SELECT * FROM Appoinments WHERE PatientID LIKE @PatientID";


            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@PatientID", "%" + PatientID + "%");


                connection.Open();
                DataTable dataTable = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }


                dataGridView1.DataSource = dataTable;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                string selectedPatientID = dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();


                Editappoinment editForm = new Editappoinment(selectedPatientID);
                editForm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Deleteappoinment d1 = new Deleteappoinment();
            d1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
