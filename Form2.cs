using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottary
{
    public partial class Form2 : Form
    {
        public int i = 0; // Counter to toggle timer state
        public List<string> num = new List<string>(); // List to store numbers

        public Form2()
        {
            InitializeComponent();

            // Set form to full screen
            this.FormBorderStyle = FormBorderStyle.None; // Remove border and title bar
            this.WindowState = FormWindowState.Maximized; // Maximize the form
            this.TopMost = true; // Keep form on top of other windows

            StreamReader ws = new StreamReader("other.txt");
            String line = ws.ReadToEnd();
            line = Regex.Replace(line, @"\t|\n|\r", "");
            MessageBox.Show(line);
            char[] chars = new char[] { ' ', ',', '"', '{', '}', };


            foreach (var numbers in line.Split(chars, StringSplitOptions.RemoveEmptyEntries))
            {
                try
                {
                    num.Add(numbers);
                    int count = num.Count;
                    Random rd = new Random();
                    int randomIndex = rd.Next(0, count);
                    string randomNumber = num[randomIndex];
                }
                catch (FormatException fe)
                {
                    // ...
                }
                catch (OverflowException oe)
                {
                    // ...
                }
            }
            ws.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (i % 2 == 0) timer1.Enabled = true;
            else
                timer1.Enabled = false;
            i++;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int count = num.Count;
            Random rd = new Random();
            int randomIndex = rd.Next(0, count);
            string randomNumber = num[randomIndex];
            winnerlbl.Text = randomNumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbl1.Text == "00000")
            {
                //textBox2.Text = textBox1.Text;
                lbl1.Text = winnerlbl.Text;
                num.Remove(lbl1.Text);
            }
            else if (lbl1.Text != "00000" && lbl2.Text == "00000")
            {
                // textBox3.Text = textBox1.Text;
                lbl2.Text = winnerlbl.Text;
                num.Remove(lbl2.Text);
            }
            else if (lbl2.Text != "00000" && lbl3.Text == "00000")
            {
                //textBox4.Text = textBox1.Text;
                lbl3.Text = winnerlbl.Text;
                num.Remove(lbl3.Text);
            }
            else if (lbl3.Text != "00000" && lbl4.Text == "00000")
            {
                // textBox3.Text = textBox1.Text;
                lbl4.Text = winnerlbl.Text;
                num.Remove(lbl4.Text);
            }
            else if (lbl4.Text != "00000" && lbl5.Text == "00000")
            {
                //textBox4.Text = textBox1.Text;
                lbl5.Text = winnerlbl.Text;
                num.Remove(lbl5.Text);
            }
            else if (lbl5.Text != "00000" && lbl6.Text == "00000")
            {
                // textBox3.Text = textBox1.Text;
                lbl6.Text = winnerlbl.Text;
                num.Remove(lbl6.Text);
            }

            else if (lbl6.Text != "00000" && lbl7.Text == "00000")
            {
                //textBox4.Text = textBox1.Text;
                lbl7.Text = winnerlbl.Text;
                num.Remove(lbl7.Text);
            }
            else if (lbl7.Text != "00000" && lbl8.Text == "00000")
            {
                // textBox3.Text = textBox1.Text;
                lbl8.Text = winnerlbl.Text;
                num.Remove(lbl8.Text);
            }
            else if (lbl8.Text != "00000" && lbl9.Text == "00000")
            {
                //textBox4.Text = textBox1.Text;
                lbl9.Text = winnerlbl.Text;
                num.Remove(lbl9.Text);
            }
            else if (lbl9.Text != "00000" && lbl10.Text == "00000")
            {
                // textBox3.Text = textBox1.Text;
                lbl10.Text = winnerlbl.Text;
                num.Remove(lbl10.Text);
            }
            else if (lbl10.Text != "00000" && lbl11.Text == "00000")
            {
                //textBox4.Text = textBox1.Text;
                lbl11.Text = winnerlbl.Text;
                num.Remove(lbl11.Text);
            }
            else if (lbl11.Text != "00000" && lbl12.Text == "00000")
            {
                // textBox3.Text = textBox1.Text;
                lbl12.Text = winnerlbl.Text;
                num.Remove(lbl12.Text);
            }
            else if (lbl12.Text != "00000" && lbl13.Text == "00000")
            {
                //textBox4.Text = textBox1.Text;
                lbl13.Text = winnerlbl.Text;
                num.Remove(lbl13.Text);
            }
            else if (lbl13.Text != "00000" && lbl14.Text == "00000")
            {
                //textBox4.Text = textBox1.Text;
                lbl14.Text = winnerlbl.Text;
                num.Remove(lbl14.Text);
            }
            else if (lbl14.Text != "00000" && lbl15.Text == "00000")
            {
                // textBox3.Text = textBox1.Text;
                lbl15.Text = winnerlbl.Text;
                num.Remove(lbl15.Text);
            }
            else if (lbl15.Text != "00000" && lbl16.Text == "00000")
            {
                //textBox4.Text = textBox1.Text;
                lbl16.Text = winnerlbl.Text;
                num.Remove(lbl16.Text);
            }
            else if (lbl16.Text != "00000" && lbl17.Text == "00000")
            {
                //textBox4.Text = textBox1.Text;
                lbl17.Text = winnerlbl.Text;
                num.Remove(lbl17.Text);
            }
            else if (lbl17.Text != "00000" && lbl18.Text == "00000")
            {
                // textBox3.Text = textBox1.Text;
                lbl18.Text = winnerlbl.Text;
                num.Remove(lbl18.Text);
            }
            else if (lbl18.Text != "00000" && lbl19.Text == "00000")
            {
                //textBox4.Text = textBox1.Text;
                lbl19.Text = winnerlbl.Text;
                num.Remove(lbl19.Text);
            }

            else if (lbl19.Text != "00000" && lbl20.Text == "00000")
            {
                // textBox3.Text = textBox1.Text;
                lbl20.Text = winnerlbl.Text;
                num.Remove(lbl20.Text);
            }
            else if (lbl20.Text != "00000" && lbl21.Text == "00000")
            {
                //textBox4.Text = textBox1.Text;
                lbl21.Text = winnerlbl.Text;
                num.Remove(lbl21.Text);
            }
            else if (lbl21.Text != "00000" && lbl22.Text == "00000")
            {
                // textBox3.Text = textBox1.Text;
                lbl22.Text = winnerlbl.Text;
                num.Remove(lbl22.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl1.Text = "00000";
            lbl2.Text = "00000";
            lbl3.Text = "00000";
            lbl4.Text = "00000";
            lbl5.Text = "00000";
            lbl6.Text = "00000";
            lbl7.Text = "00000";
            lbl8.Text = "00000";
            lbl9.Text = "00000";
            lbl10.Text = "00000";
            lbl11.Text = "00000";
            lbl12.Text = "00000";
            lbl13.Text = "00000";
            lbl14.Text = "00000";
            lbl15.Text = "00000";
            lbl16.Text = "00000";
            lbl17.Text = "00000";
            lbl18.Text = "00000";
            lbl19.Text = "00000";
            lbl20.Text = "00000";
            lbl21.Text = "00000";
            lbl22.Text = "00000";
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 0;
            lbl1.Text = "00000";
            lbl2.Text = "00000";
            lbl3.Text = "00000";
            lbl4.Text = "00000";
            lbl5.Text = "00000";
            lbl6.Text = "00000";
            lbl7.Text = "00000";
            lbl8.Text = "00000";
            lbl9.Text = "00000";
            lbl10.Text = "00000";
            lbl11.Text = "00000";
            lbl12.Text = "00000";
            lbl13.Text = "00000";
            lbl14.Text = "00000";
            lbl15.Text = "00000";
            lbl16.Text = "00000";
            lbl17.Text = "00000";
            lbl18.Text = "00000";
            lbl19.Text = "00000";
            lbl20.Text = "00000";
            lbl21.Text = "00000";
            lbl22.Text = "00000";
            
            winnerlbl.Text = "00000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form3 form1 = new Form3();

            // Show Form2
            form1.Show();

            // Hide or close Form1
            this.Hide();
        }
    }
}
