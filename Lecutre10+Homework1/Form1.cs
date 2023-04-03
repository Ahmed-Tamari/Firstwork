using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecutre10_Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreatcontols_Click(object sender, EventArgs e)
        {
           
            int numberofcontrols = int.Parse(txtControlNumber.Text);
            if (cbxControltype.SelectedItem.ToString() == "Button") 


            {
                plnControls.Controls.Clear();
                for (int i = 0; i < numberofcontrols; i++)
                {
                    Button newButton = new Button();
                    newButton.Text = "Button " + (i + 1);
                    newButton.Name = "Button " + (i + 1);
                    newButton.Size = new Size(120, 40);
                    newButton.Location = new Point(0, (i * 50));
                    newButton.BackColor = Color.Red;
                    plnControls.Controls.Add(newButton);

                }


            }


            else if ((cbxControltype.SelectedItem.ToString() == "TextBox"))
            {
                plnControls.Controls.Clear();
                for (int i = 0; i < numberofcontrols; i++)
                {
                    TextBox newTextBox = new TextBox();
                    newTextBox.Text = "Text Box " + (i + 1);
                    newTextBox.Name = "Text Box " + (i + 1);
                    newTextBox.Size = new Size(120, 40);
                    newTextBox.Location = new Point(0, (i * 50));
                    plnControls.Controls.Add(newTextBox);

                }

            }
            else if  (cbxControltype.Items.Contains("Label")  )
            {
                plnControls.Controls.Clear();
                for (int i = 0; i < numberofcontrols; i++)
                {
                    Label newLabel = new Label();
                    newLabel.Text = "Label " + (i + 1);
                    newLabel.Name = "Label" + (i + 1);
                    newLabel.Size = new Size(120, 40);
                    newLabel.Location = new Point(0, (i * 50));
                    newLabel.BackColor = Color.Green;
                    plnControls.Controls.Add(newLabel);

                }

            }
            else
            {
                MessageBox.Show("Please select Control Type and Number of Controls ");
            }


        }

        private void cbxControltype_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student : Ahmed Altamari \n ID : AF0530 ");
        }
    }
}
