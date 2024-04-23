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
using System.Collections;

namespace DC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox2.PasswordChar = '*';

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";


            string query = "SELECT COUNT(*) FROM Register WHERE Username = @Username AND Pass_word = @Pass_word";

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Pass_word", password);


                    connection.Open();


                    int count = (int)command.ExecuteScalar();


                    if (count > 0)
                    {

                        this.Close();
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                    }
                    else
                    {

                        MessageBox.Show("Invalid username or password!");
                        this.Close();
                        Form2 form3 = new Form2();
                        form3.Show();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 h2 = new Form1();
            h2.Show();
        }
    }

}
