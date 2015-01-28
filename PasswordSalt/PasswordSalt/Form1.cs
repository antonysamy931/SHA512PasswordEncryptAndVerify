using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSalt
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Helper.ComputeHash(textBox1.Text, "SHA512", null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool Verify = Helper.VerifyHash(textBox1.Text, "SHA512", richTextBox1.Text);
            if (Verify)
            {
                label3.Text = "Valid";
            }
            else
            {
                label3.Text = "Invalid";
            }
        }
    }
}
