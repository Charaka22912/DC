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

namespace DC
{
    public partial class Editservices : Form
    {
        public Editservices()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectservice selectservice = new selectservice();

            // Show the second form as a dialog (blocks interaction with the first form until the second form is closed)
            if (selectservice.ShowDialog() == DialogResult.OK)
            {
                // Display the selected details from the second form in the TextBox on the first form
                textBox1.Text = selectservice.SelectedDetails;
            }
            string ID = textBox1.Text.Trim();
            string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";
            string query = "SELECT *FROM Dental_services WHERE ID = @ID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", ID);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Read data from SqlDataReader and assign it to text boxes
                    textBox2.Text = reader["Servicename"].ToString();
                    textBox3.Text = reader["Price"].ToString();
                    textBox4.Text = reader["ServiceDescription"].ToString();


                }
                else
                {
                    MessageBox.Show("Service not found.");
                }



            }
        }

        private void Editservices_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";
            string query = "UPDATE Dental_services SET Servicename = @Servicename, Price = @Price,ServiceDescription =@ServiceDescription WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Servicename", textBox2.Text);
                command.Parameters.AddWithValue("@Price", textBox3.Text);
                command.Parameters.AddWithValue("@ServiceDescription", textBox4.Text);

                // Add parameters for other details
                command.Parameters.AddWithValue("@ID", textBox1.Text);


                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Service details updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update Service details.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
