using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace DC
{
    public partial class Addpatient : Form
    {
        public Addpatient()
        {
            InitializeComponent();
        }

        private void Addpatient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PFirstname = textBox1.Text.Trim();
            string PLastname = textBox2.Text.Trim();
            string PAddress = textBox3.Text.Trim();
            DateTime PDOB = dateTimePicker1.Value;
            string PContact = textBox5.Text.Trim();
            string Pmedical = textBox6.Text.Trim();





            // Validate input
            if (string.IsNullOrEmpty(PFirstname) || string.IsNullOrEmpty(PLastname) || string.IsNullOrEmpty(PAddress) || string.IsNullOrEmpty(Pmedical))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Connection 
            string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";

            // SQL query
            string query = "INSERT INTO Patients(PFirstname, PLastname,PAddress, PDOB, PContact, Pmedical) " +
                           "VALUES (@PFirstname, @PLastname,@Paddress, @PDOB, @PContact, @Pmedical)";

            // Create connection 
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@PFirstname", PFirstname);
                command.Parameters.AddWithValue("@PLastname", PLastname);
                command.Parameters.AddWithValue("@Paddress", PAddress);
                command.Parameters.AddWithValue("@PDOB", PDOB);
                command.Parameters.AddWithValue("@PContact", PContact);
                command.Parameters.AddWithValue("@Pmedical", Pmedical);




                try
                {
                    // Open the connection
                    connection.Open();
                    // Execute the SQL command
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

