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
    public partial class WINNER : Form
    {

        public WINNER(string first, string second, string third)
        {
            InitializeComponent();
            this.TopMost = true;

            label2.Text = first; // Set the text of label1
            label3.Text = third;
            label4.Text = second;
        }
        public WINNER()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
