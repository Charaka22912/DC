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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Name = "Firstname";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LastName.Name = "Lastname";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Name = "Addressline1";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Name = "Addressline2";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Name = "Addressline3";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Name = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Name = "female";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.Name = "Username";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.Name = "password";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string firstName = textBox1.Text.Trim();
            string lastName = LastName.Text.Trim();
            string addressLine1 = textBox3.Text.Trim();
            string addressLine2 = textBox4.Text.Trim();
            string addressLine3 = textBox5.Text.Trim();
            string gender = radioButton1.Checked ? "Male" : "Female";
            DateTime dob = dateTimePicker1.Value;
            string userType = "";

            foreach (object item in checkedListBox1.CheckedItems)
            {
                userType += item.ToString() + ", ";
            }

           
            userType = userType.TrimEnd(',', ' ');

            string username = textBox8.Text.Trim();
            string password = textBox9.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(addressLine1) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(userType) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";
            string query = "INSERT INTO Register(FirstName, LastName, Addressline1, Addressline2, Addressline3, Gender, DOB, Usertype, Username, Pass_word) " +
                           "VALUES (@FirstName, @LastName, @Addressline1, @Addressline2, @Addressline3, @Gender, @DOB, @Usertype, @Username, @Pass_word)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Addressline1", addressLine1);
                command.Parameters.AddWithValue("@Addressline2", addressLine2);
                command.Parameters.AddWithValue("@Addressline3", addressLine3);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@DOB", dob);
                command.Parameters.AddWithValue("@Usertype", userType);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Pass_word", password);

                
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully!");
                        this.Close();
                        Form1 h1 = new Form1();
                        h1.Show();
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


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 h1 = new Form1();
            h1.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
