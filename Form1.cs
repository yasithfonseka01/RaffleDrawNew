﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lottary
{
    public partial class Form1 : Form
    {
        public int i = 0;
        public List<string> num = new List<string>();

        //public string[] num = new string[5] { "032", "081", "088", "013", "150" };
        public Form1()
        {
            InitializeComponent();

            // Set form to full screen
            this.FormBorderStyle = FormBorderStyle.None; // Remove border and title bar
            this.WindowState = FormWindowState.Maximized; // Maximize the form
            this.TopMost = true; // Keep form on top of other windows

            StreamReader ws = new StreamReader("number.txt");
            String line = ws.ReadToEnd();
            line = Regex.Replace(line, @"\t|\n|\r", "");
            MessageBox.Show(line);
            char[] chars = new char[] {' ',',','"','{','}',};


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

        private void button1_Click(object sender, EventArgs e)
        {

            if (i%2==0) timer1.Enabled = true;
           else
                timer1.Enabled = false;
            i++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int count = num.Count;
            Random rd = new Random();
            int randomIndex = rd.Next(0, count);
            string randomNumber = num[randomIndex];
            label1.Text = randomNumber;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            // timer1.Enabled = false;
            // i++;
            if (label2.Text =="00000")
            {
              //textBox2.Text = textBox1.Text;
              label2.Text = label1.Text;
              num.Remove(label2.Text);
             }
            else  if (label2.Text != "00000"&& label3.Text=="00000")
            {
               // textBox3.Text = textBox1.Text;
               label3.Text = label1.Text;
               num.Remove(label3.Text);
            }
            else if (label3.Text != "00000"&& label4.Text =="00000") {
                //textBox4.Text = textBox1.Text;
                label4.Text = label1.Text;

                // Pass label4.Text to Form4
                WINNER form1 = new WINNER(label4.Text, label3.Text, label2.Text);
                form1.StartPosition = FormStartPosition.CenterScreen; // Center the form on the screen
                form1.Show();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 0;
            label1.Text = "00000";
            label2.Text = "00000";
            label3.Text = "00000";
            label4.Text = "00000";
            num.Add(label2.Text);
            num.Add(label3.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label2.Text = "00000";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label3.Text = "00000";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label4 .Text = "00000";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = !timer1.Enabled;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "00000";
        }

        private void button6_Click(object sender, EventArgs e)
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
