using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture13_HomeWork_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Check Entry__________________________________________________________________________
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;//dont write in text box 
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;//dont write in text box 
            }
        }
        private void txtJob_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStudy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Check Entry__________________________________________________________________________
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name;
            int age;
            string job;
            string study;

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAge.Text)||string.IsNullOrEmpty(txtStudy.Text)||string.IsNullOrEmpty(txtJob.Text) )
            {
                MessageBox.Show("Enter Valid Data in all Fields");

            }
            else
            {
                name = txtName.Text;
                age = int.Parse(txtAge.Text);
                job = txtJob.Text;
                study = txtStudy.Text;
                MessageBox.Show("Name :" + name + "\n" + "Age :" + age+"\n"+"Job"+job+"\n"+"Study"+study);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           dateTimePicker1 = new DateTimePicker();
           
        }
    } 
}
