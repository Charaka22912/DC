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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Dashboard));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            label3 = new Label();
            label2 = new Label();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.FlatAppearance.MouseDownBackColor = Color.Cyan;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(325, 380);
            button1.Name = "button1";
            button1.Size = new Size(310, 143);
            button1.TabIndex = 0;
            button1.Text = "Appoinment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(690, 380);
            button2.Name = "button2";
            button2.Size = new Size(310, 143);
            button2.TabIndex = 1;
            button2.Text = "Dentist";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1059, 380);
            button3.Name = "button3";
            button3.Size = new Size(310, 143);
            button3.TabIndex = 2;
            button3.Text = "Patient";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(325, 573);
            button4.Name = "button4";
            button4.Size = new Size(310, 143);
            button4.TabIndex = 3;
            button4.Text = "Services";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(690, 573);
            button5.Name = "button5";
            button5.Size = new Size(310, 143);
            button5.TabIndex = 4;
            button5.Text = "Invoices";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("STFangsong", 47.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(643, 9);
            label1.Name = "label1";
            label1.Size = new Size(392, 90);
            label1.TabIndex = 5;
            label1.Text = "Dashboard";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top;
            button6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(1059, 573);
            button6.Name = "button6";
            button6.Size = new Size(310, 143);
            button6.TabIndex = 6;
            button6.Text = "Monthly Report";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 162);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.Location = new Point(1634, 20);
            button7.Name = "button7";
            button7.Size = new Size(97, 44);
            button7.TabIndex = 8;
            button7.Text = "Log out";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(375, 149);
            label3.Name = "label3";
            label3.Size = new Size(136, 62);
            label3.TabIndex = 10;
            label3.Text = "Total";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 211);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 11;
            label2.Text = "Total Patients";
            // 
            // Dashboard
            // 
            ClientSize = new Size(1759, 782);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load_1;
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label3;
        private Label label2;
        private string connectionString = "Data Source=localhost;Initial Catalog=Clinic;Integrated Security=True";
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Patients p1 = new Patients();
            p1.Show();
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox1;

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 h2 = new Form1();
            h2.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Appoinment appoinment = new Appoinment();
            appoinment.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Services services = new Services();
            services.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadPatientCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Patients";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        connection.Open();
                        int patientCount = (int)command.ExecuteScalar();
                        label3.Text = "" + patientCount.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            LoadPatientCount();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Invoice invoice = new Invoice();
            invoice.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Report report = new Report();
            report.Show();
        }
    }
}
