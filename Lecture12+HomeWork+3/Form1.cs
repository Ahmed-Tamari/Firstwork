using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture12_HomeWork_3
{
    public partial class Form1 : Form
    {
        double Result=0;
        int op;
        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(My_Custom_Handler);
            button2.Click += new EventHandler(My_Custom_Handler);
            button3.Click += new EventHandler(My_Custom_Handler);
            button4.Click += new EventHandler(My_Custom_Handler);
            button5.Click += new EventHandler(My_Custom_Handler);
            button6.Click += new EventHandler(My_Custom_Handler);
            button7.Click += new EventHandler(My_Custom_Handler);
            button8.Click += new EventHandler(My_Custom_Handler);
            button9.Click += new EventHandler(My_Custom_Handler);
            button10.Click += new EventHandler(My_Custom_Handler);
            button18.Click += new EventHandler(My_Custom_Handler);


        }
        private void My_Custom_Handler(object sender, EventArgs e)
        {
            
           txtScreen.Text = txtScreen.Text+((Button)sender).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            Result =double.Parse(txtScreen.Text);
            txtScreen.Text = "";
            op = 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {

            switch (op)
            {
                case 1:
                    Result = Result + (double.Parse(txtScreen.Text));
                    txtScreen.Text = Result.ToString();
                    break;
                    case 2:
                    Result = Result - (double.Parse(txtScreen.Text));
                    txtScreen.Text = Result.ToString();
                    break;
                    case 3:
                    Result = Result * (double.Parse(txtScreen.Text));
                    txtScreen.Text = Result.ToString();
                    break;
                    case 4:
                    Result = Result / (double.Parse(txtScreen.Text));
                    txtScreen.Text = Result.ToString();
                    break;
                default:
                    break;
            }
                    
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Result = (double.Parse(txtScreen.Text));
            txtScreen.Text = "";
            op = 2;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Result = double.Parse(txtScreen.Text);
            txtScreen.Text = "";
            op = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Result = double.Parse(txtScreen.Text);
            txtScreen.Text = "";
            op = 4;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "";
            op = 0;
            Result = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AHMED ALTAMARI AF0530");
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void txtScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}
