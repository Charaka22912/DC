using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DC
{
    public partial class loginControl : Form
    {
        public loginControl()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {


                string password = textBox1.Text;

                if (AuthenticateUser(password))
                {

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }


        }
        private bool AuthenticateUser(string password)
        {
            return (password == "admin123");
        }
    }
}
