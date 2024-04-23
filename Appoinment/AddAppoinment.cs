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
    public partial class AddAppoinment : Form
    {
        public AddAppoinment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selectpatient secondForm = new Selectpatient();

            
            if (secondForm.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = secondForm.SelectedDetails;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string PatientID = textBox1.Text.Trim();
            DateTime appoinmentday = dateTimePicker1.Value;





            if (string.IsNullOrEmpty(PatientID))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

  
            string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";

    
            string query = "INSERT INTO Appoinments(PatientID, appoinmentday) " +
                           "VALUES (@PatientID, @appoinmentday)";

     
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@PatientID", PatientID);
                command.Parameters.AddWithValue("@appoinmentday", appoinmentday);




                try
                {
              
                    connection.Open();
                 
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully!");
                        this.Close();

             
                    }
                    else
                    {
                        MessageBox.Show("No rows were affected.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
