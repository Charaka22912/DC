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
    public partial class Deleteappoinment : Form
    {
        public Deleteappoinment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selectpatient s3 = new Selectpatient();


            if (s3.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = s3.SelectedDetails;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell != null && clickedCell.Value != null)
                {

                    string PatientID = dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();


                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        string deleteQuery = "DELETE  FROM Appoinments WHERE PatientID = @PatientID";
                        using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True"))
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@PatientID", PatientID);


                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();


                            if (rowsAffected > 0)
                            {

                                dataGridView1.Rows.RemoveAt(e.RowIndex);
                                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}
