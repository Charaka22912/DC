using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace DC
{
    public partial class Addservices : Form
    {
        public Addservices()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Servicename = textBox1.Text.Trim();
            string Price = textBox2.Text.Trim();
            string ServiceDescription = textBox3.Text.Trim();





            // Validate input
            if (string.IsNullOrEmpty(Servicename) || string.IsNullOrEmpty(Price))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Connection 
            string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";

            // SQL query
            string query = "INSERT INTO Dental_services(Servicename, Price,ServiceDescription) " +
                           "VALUES (@Servicename, @Price,@ServiceDescription)";

            // Create connection 
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@Servicename", Servicename);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@ServiceDescription", ServiceDescription);





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
    }

}
