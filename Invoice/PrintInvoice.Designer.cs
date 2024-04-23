namespace DC
{
    partial class PrintInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintInvoice));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(382, 17);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Invoice";
            // 
            // label2
            // 
            label2.Location = new Point(79, 118);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "InvoiceNo";
            // 
            // label3
            // 
            label3.Location = new Point(643, 118);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Date";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.Document;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 716);
            panel1.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(176, 118);
            label13.Name = "label13";
            label13.Size = new Size(24, 20);
            label13.TabIndex = 11;
            label13.Text = ".....";
            // 
            // label12
            // 
            label12.Location = new Point(485, 503);
            label12.Name = "label12";
            label12.Size = new Size(52, 20);
            label12.TabIndex = 10;
            // 
            // label11
            // 
            label11.Location = new Point(485, 429);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 9;
            // 
            // label10
            // 
            label10.Location = new Point(485, 386);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 8;
            // 
            // label9
            // 
            label9.Location = new Point(485, 340);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 7;
            // 
            // label8
            // 
            label8.Location = new Point(79, 439);
            label8.Name = "label8";
            label8.Size = new Size(304, 48);
            label8.TabIndex = 6;
            // 
            // label7
            // 
            label7.Location = new Point(79, 386);
            label7.Name = "label7";
            label7.Size = new Size(304, 40);
            label7.TabIndex = 5;
            // 
            // label6
            // 
            label6.Location = new Point(79, 340);
            label6.Name = "label6";
            label6.Size = new Size(304, 32);
            label6.TabIndex = 4;
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.Location = new Point(485, 271);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Amount";
            // 
            // label4
            // 
            label4.Location = new Point(192, 271);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "Description";
            label4.Click += label4_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += PrintDocument1_PrintPage;
            // 
            // button1
            // 
            button1.Location = new Point(800, 56);
            button1.Name = "button1";
            button1.Size = new Size(74, 47);
            button1.TabIndex = 4;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PrintInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 825);
            Controls.Add(button1);
            Controls.Add(panel1);
            ImeMode = ImeMode.On;
            Name = "PrintInvoice";
            Text = "PrintInvoice";
            Load += PrintInvoice_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private PrintPreviewDialog printPreviewDialog1;
        private Button button1;
        public System.Drawing.Printing.PrintDocument printDocument1;
        private Label label13;
    }
}