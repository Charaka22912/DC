using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Reflection;

namespace DC
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int printAreaWidth = e.MarginBounds.Width;
            int printAreaHeight = e.MarginBounds.Height;

            // Define starting point for printing
            int startX = e.MarginBounds.Left;
            int startY = e.MarginBounds.Top;

            // Define font for printing
            Font printFont = new Font("Arial", 12);

            // Iterate through each control on the form
            foreach (Control control in Controls)
            {
                // Print labels
                if (control is Label)
                {
                    Label label = control as Label;
                    e.Graphics.DrawString(label.Text, printFont, Brushes.Black, startX, startY);
                    startY += label.Height; // Move to next line
                }

                // Print textboxes
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    e.Graphics.DrawString(textBox.Text, printFont, Brushes.Black, startX, startY);
                    startY += textBox.Height; // Move to next line
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Print the document
                printDocument1.Print();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Selectpatient s2 = new Selectpatient();

            // Show the second form as a dialog (blocks interaction with the first form until the second form is closed)
            if (s2.ShowDialog() == DialogResult.OK)
            {
                // Display the selected details from the second form in the TextBox on the first form
                textBox1.Text = s2.SelectedDetails;
            }
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
                    label2.Text = reader["PFirstname"].ToString();
                    label10.Text = reader["PLastname"].ToString();




                }
                else
                {
                    MessageBox.Show("Patient not found.");
                }



            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            selectservice selectservice = new selectservice();
            // Show the second form as a dialog (blocks interaction with the first form until the second form is closed)
            if (selectservice.ShowDialog() == DialogResult.OK)
            {
                // Display the selected details from the second form in the TextBox on the first form
                label1.Text = selectservice.SelectedDetails;
            }

            string ID = label1.Text.Trim();
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
                    label5.Text = reader["Price"].ToString();
                    CalculateTotal();


                }
                else
                {
                    MessageBox.Show("Service not found.");
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            selectservice selectservice = new selectservice();

            // Show the second form as a dialog (blocks interaction with the first form until the second form is closed)
            if (selectservice.ShowDialog() == DialogResult.OK)
            {
                // Display the selected details from the second form in the TextBox on the first form
                label11.Text = selectservice.SelectedDetails;
            }
            string ID = label11.Text.Trim();
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
                    textBox3.Text = reader["Servicename"].ToString();
                    label6.Text = reader["Price"].ToString();
                    CalculateTotal();


                }
                else
                {
                    MessageBox.Show("Service not found.");
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            selectservice selectservice = new selectservice();

            // Show the second form as a dialog (blocks interaction with the first form until the second form is closed)
            if (selectservice.ShowDialog() == DialogResult.OK)
            {
                // Display the selected details from the second form in the TextBox on the first form
                label12.Text = selectservice.SelectedDetails;
            }
            string ID = label12.Text.Trim();
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
                    textBox4.Text = reader["Servicename"].ToString();
                    label7.Text = reader["Price"].ToString();
                    CalculateTotal();


                }
                else
                {
                    MessageBox.Show("Service not found.");
                }
            }
        }
        private void CalculateTotal()
        {
            decimal total = 0;

            // Check if labels for prices of services are not empty
            if (!string.IsNullOrEmpty(label5.Text))
                total += Convert.ToInt16(label5.Text);
            if (!string.IsNullOrEmpty(label6.Text))
                total += Convert.ToInt16(label6.Text);
            if (!string.IsNullOrEmpty(label7.Text))
                total += Convert.ToInt16(label7.Text);

            // Display the total in Label 9
            label9.Text = total.ToString();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            CalculateTotal();
            DateTime today = DateTime.Today;


            label3.Text = today.ToShortDateString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string PatientID = textBox1.Text.Trim();
            string InvoiceDate = label3.Text;
            string Amount = label9.Text.Trim();
            string service1 = textBox2.Text.Trim();
            string amount1 = label5.Text.Trim();
            string service2 = textBox3.Text.Trim();
            string service3 = textBox4.Text.Trim();
            string amount2 = label6.Text.Trim();
            string amount3 = label7.Text.Trim();
            int InvoiceNO;
            if (string.IsNullOrEmpty(PatientID) || string.IsNullOrEmpty(InvoiceDate) || string.IsNullOrEmpty(Amount))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";

            // SQL query
            string query = "INSERT INTO Invoices(PatientID, InvoiceDate, Amount) " +
                "OUTPUT INSERTED.InvoiceNO " +
               "VALUES (@PatientID, @InvoiceDate, @Amount)";

            // Create connection 
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@PatientID", PatientID);
                command.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
                command.Parameters.AddWithValue("@Amount", Amount);
                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the SQL command and retrieve the InvoiceID
                    InvoiceNO = (int)command.ExecuteScalar();

                    // Check if InvoiceID was successfully retrieved
                    if (InvoiceNO > 0)
                    {
                        // Create an instance of Form2 and pass the data
                        PrintInvoice printInvoice = new PrintInvoice(PatientID, InvoiceDate, Amount, service1, amount1, InvoiceNO.ToString(), service2, service3, amount2, amount3);
                        printInvoice.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve InvoiceID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
