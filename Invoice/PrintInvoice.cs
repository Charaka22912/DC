using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DC
{
    public partial class PrintInvoice : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";


        public string SelectedDetails { get; private set; }
        public PrintInvoice(string PatientID, string InvoiceDate, string Amount, string service1, string amount1, string InvoiceNO, string service2, string amount2, string service3
            , string amount3)
        {

            InitializeComponent();

            label3.Text = " " + InvoiceDate;
            label12.Text = "" + Amount;
            label6.Text = "" + service1;
            label9.Text = "" + amount1;
            label13.Text = "" + InvoiceNO;
            label7.Text = "" + service2;
            label8.Text = "" + service3;
            label10.Text = "" + amount2;
            label11.Text = "" + amount3;

            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);

            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            loaddate();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();

        }


        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));

            // Draw the bitmap onto the print page
            e.Graphics.DrawImage(bmp, e.PageBounds);

        }
        private void loaddate()
        {
            string InvoiceNO = label13.Text.Trim();
            string query = "SELECT *FROM Invoices WHERE InvoiceNO = @InvoiceNO";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@InvoiceNO", InvoiceNO);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Read data from SqlDataReader and assign it to text boxes
                    label3.Text = reader["InvoiceDate"].ToString();

                }
                else
                {

                }



            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
