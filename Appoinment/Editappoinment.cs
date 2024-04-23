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
    public partial class Editappoinment : Form
    {

        public Editappoinment(string patientID)
        {
            InitializeComponent();
            textBox1.Text = patientID;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Editappoinment_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e) { }
        /* {
             string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";
             string query = "UPDATE Patients SET PFirstname = @PFirstname WHERE PatientID = @PatientID";

             using (SqlConnection connection = new SqlConnection(connectionString))
             using (SqlCommand command = new SqlCommand(query, connection))
             {

                 command.Parameters.AddWithValue("@PLastname", textBox2.Text);



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
         }*/
    }
}
