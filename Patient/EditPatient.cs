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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DC
{
    public partial class EditPatient : Form
    {
        public EditPatient()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PatientID = textBox1.Text.Trim();
            string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";
            string query = "SELECT *FROM Patients WHERE PatientID = @PatientID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PatientID", PatientID);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Read data from SqlDataReader and assign it to text boxes
                    textBox8.Text = reader["PFirstname"].ToString();
                    textBox2.Text = reader["PLastname"].ToString();
                    textBox3.Text = reader["PAddress"].ToString();
                    if (reader["PDOB"] != DBNull.Value)
                    {
                        // Parse the value to DateTime
                        DateTime PDOB = Convert.ToDateTime(reader["PDOB"]);

                        // Set the value to DateTimePicker control
                        dateTimePicker1.Value = PDOB;
                    }
                    else
                    {
                        // Handle case where Pmedical column is DBNull
                        // For example, set DateTimePicker to today's date or leave it empty
                        dateTimePicker1.Value = DateTime.Today;
                    }
                    textBox4.Text = reader["PContact"].ToString();
                    textBox5.Text = reader["Pmedical"].ToString();


                }
                else
                {
                    MessageBox.Show("Patient not found.");
                }



            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";
            string query = "UPDATE Patients SET PFirstname = @PFirstname, PLastname = @PLastname,PAddress =@PAddress,PDOB =@PDOB ,PContact =@PContact ,Pmedical = @Pmedical WHERE PatientID = @PatientID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PFirstname", textBox8.Text);
                command.Parameters.AddWithValue("@PLastname", textBox2.Text);
                command.Parameters.AddWithValue("@PAddress", textBox3.Text);
                command.Parameters.AddWithValue("@PDOB", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@PContact", textBox4.Text);
                command.Parameters.AddWithValue("@Pmedical", textBox5.Text);
                // Add parameters for other details
                command.Parameters.AddWithValue("@PatientID", textBox1.Text);


                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Patient details updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update patient details.");
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Selectpatient s2 = new Selectpatient();

            // Show the second form as a dialog (blocks interaction with the first form until the second form is closed)
            if (s2.ShowDialog() == DialogResult.OK)
            {
                // Display the selected details from the second form in the TextBox on the first form
                textBox1.Text = s2.SelectedDetails;
            }
        }
    }
}
