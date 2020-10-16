using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string SecondNumber;
        string FirstNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button_Click(object sender, EventArgs e)
        {
            
      
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            //if(label1.Text.Length>8)
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SecondNumber=label1.Text;
            label2.Text = label2.Text + SecondNumber;
            int x = int.Parse(FirstNumber) + int.Parse(SecondNumber);
            label1.Text = x.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FirstNumber = label1.Text;
            Button btn = (Button)sender;
            label2.Text = FirstNumber+ btn.Text;
            label1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
