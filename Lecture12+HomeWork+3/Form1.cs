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
        string op;
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
            button11.Click += new EventHandler(My_Custom_Handler2);
            button12.Click += new EventHandler(My_Custom_Handler2);
            button13.Click += new EventHandler(My_Custom_Handler2);
            button14.Click += new EventHandler(My_Custom_Handler2);


        }
        private void My_Custom_Handler(object sender, EventArgs e)
        {
            
           txtScreen.Text = txtScreen.Text+((Button)sender).Text;
        }

        private void My_Custom_Handler2(object sender, EventArgs e)
        {
            
            Result =double.Parse(txtScreen.Text);
            txtScreen.Text = "0";
            op = ((Button)sender).Text;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            op = "";
            Result = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AHMED ALTAMARI AF0530");
        }

        private void button15_Click(object sender, EventArgs e)
        {

            switch (op)
            {
                case "+":
                    Result = Result + (double.Parse(txtScreen.Text));
                    txtScreen.Text = Result.ToString();
                    break;
                    case "-":
                    Result = Result - (double.Parse(txtScreen.Text));
                    txtScreen.Text = Result.ToString();
                    break;
                    case "*":
                    Result = Result * (double.Parse(txtScreen.Text));
                    txtScreen.Text = Result.ToString();
                    break;
                    case "/":
                    Result = Result / (double.Parse(txtScreen.Text));
                    txtScreen.Text = Result.ToString();
                    break;
                default:
                    break;
            }
                    
        }
                 
    }
}
