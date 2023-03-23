using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wellcome " +txt1.Text);
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            lbl1.Text = txt1.Text.Length.ToString();
        }
    }
}
