using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture11_Homework2
{
    public partial class frmLogin : Form
    {
        public Users[] User = new Users[5];
        

        public frmLogin()
        {
            InitializeComponent();
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            User[0]=new Users();
            User[0].UserId = 0;
            User[0].UserName = "AT";
            User[0].FullName = "AHMED ALTAMARI";
            User[0].Password = "016";
            //===================================
            User[1] = new Users();
            User[1].UserId = 1;
            User[1].UserName = "YE";
            User[1].FullName = "Yousef Yaser";
            User[1].Password = "2018";
            //===================================
            User[2] = new Users();
            User[2].UserId = 2;
            User[2].UserName = "AS";
            User[2].FullName = "Ala Souhail";
            User[2].Password = "1996";
            //===================================
            User[3] = new Users();
            User[3].UserId = 1;
            User[3].UserName = "HM";
            User[3].FullName = "Hassan Malik";
            User[3].Password = "2000";
            //===================================
            User[4] = new Users();
            User[4].UserId = 1;
            User[4].UserName = "SM";
            User[4].FullName = "Shadi Mohamed";
            User[4].Password = "2002";

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            for (int i=0;i<5; i++)
            {
                if (User[i].UserName !=txtUserName.Text )
                {
                    MessageBox.Show("User Doenst Exist");
                }
                else
                {
                    if (User[i].Password==txtPassword.Text)
                    {
                        MessageBox.Show("Wellcome " + User[i].FullName);
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
            }
        }
    }
}
