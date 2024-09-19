using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottary
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            // Set form to full screen
            this.FormBorderStyle = FormBorderStyle.None; // Remove border and title bar
            this.WindowState = FormWindowState.Maximized; // Maximize the form
            this.TopMost = true; // Keep form on top of other windows
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form1 form1 = new Form1();

            // Show Form2
            form1.Show();

            // Hide or close Form1
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();

            // Hide or close Form1
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
