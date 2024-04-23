namespace DC
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            textBox1 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            button2 = new Button();
            button3 = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog2 = new PrintPreviewDialog();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            button4 = new Button();
            label14 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 27);
            textBox1.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Location = new Point(164, 403);
            label12.Name = "label12";
            label12.Size = new Size(21, 22);
            label12.TabIndex = 14;
            label12.Text = "+";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Location = new Point(164, 325);
            label11.Name = "label11";
            label11.Size = new Size(21, 22);
            label11.TabIndex = 13;
            label11.Text = "+";
            label11.Click += label11_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(164, 250);
            label1.Name = "label1";
            label1.Size = new Size(21, 22);
            label1.TabIndex = 12;
            label1.Text = "+";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Mr", "Ms" });
            listBox1.Location = new Point(69, 143);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(61, 24);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(225, 147);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 10;
            label10.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(606, 480);
            label9.Name = "label9";
            label9.Size = new Size(0, 28);
            label9.TabIndex = 2;
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(468, 480);
            label8.Name = "label8";
            label8.Size = new Size(67, 31);
            label8.TabIndex = 9;
            label8.Text = "Total";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(191, 400);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(344, 27);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 322);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(344, 27);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 247);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(344, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(298, 50);
            label4.Name = "label4";
            label4.Size = new Size(129, 38);
            label4.TabIndex = 2;
            label4.Text = "INVOICE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(599, 147);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Date";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 147);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage_1;
            // 
            // button2
            // 
            button2.Location = new Point(478, 66);
            button2.Name = "button2";
            button2.Size = new Size(103, 28);
            button2.TabIndex = 3;
            button2.Text = "View All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1098, 730);
            button3.Name = "button3";
            button3.Size = new Size(54, 52);
            button3.TabIndex = 4;
            button3.Text = "Print";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printPreviewDialog2
            // 
            printPreviewDialog2.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog2.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog2.ClientSize = new Size(400, 300);
            printPreviewDialog2.Enabled = true;
            printPreviewDialog2.Icon = (Icon)resources.GetObject("printPreviewDialog2.Icon");
            printPreviewDialog2.Name = "printPreviewDialog2";
            printPreviewDialog2.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(606, 250);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 6;
            label5.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(606, 322);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 7;
            label6.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Location = new Point(606, 403);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 8;
            label7.Text = "00";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(420, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 606);
            panel1.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(538, 98);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 15;
            // 
            // button4
            // 
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(54, 50);
            button4.TabIndex = 16;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(576, 487);
            label14.Name = "label14";
            label14.Size = new Size(24, 20);
            label14.TabIndex = 16;
            label14.Text = "Rs";
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1666, 801);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Name = "Invoice";
            Text = "Invoice";
            WindowState = FormWindowState.Maximized;
            Load += Invoice_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label9;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button button2;
        private Label label10;
        private ListBox listBox1;
        private Label label12;
        private Label label11;
        private Label label1;
        private Button button3;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintPreviewDialog printPreviewDialog2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Label label13;
        private Button button4;
        private Label label14;
    }
}