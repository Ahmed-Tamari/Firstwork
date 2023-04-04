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
        private List<Users> User = new List<Users>();
        private Users User0, User1, User2, User3, User4;

        private void button1_Click(object sender, EventArgs e)
        {
            Users result = User.Find(User => User.UserName == txtUserName.Text);
            if (result.ToString() == txtUserName.Text)
            {
                MessageBox.Show("Wellcome " + result.FullName);
            }
            else
            {
                MessageBox.Show("User Doenst Exist");
            }


        }

        public frmLogin()
        {
            InitializeComponent();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            User0 = new Users();
            User0.UserId = 0;
            User0.UserName = "AT";
            User0.FullName = "AHMED ALTAMARI";
            User0.Password = "016";
            //===================================
            User1 = new Users();
            User1.UserId = 1;
            User1.UserName = "YE";
            User1.FullName = "Yousef Yaser";
            User1.Password = "2018";
            //===================================
            User2 = new Users();
            User2.UserId = 2;
            User2.UserName = "AS";
            User2.FullName = "Ala Souhail";
            User2.Password = "1996";
            //===================================
            User3 = new Users();
            User3.UserId = 3;
            User3.UserName = "HM";
            User3.FullName = "Hassan Malik";
            User3.Password = "2000";
            //===================================
            User4 = new Users();
            User4.UserId = 4;
            User4.UserName = "SM";
            User4.FullName = "Shadi Mohamed";
            User4.Password = "2002";

            User.Add(User0);
            User.Add(User1);
            User.Add(User2);
            User.Add(User3);
            User.Add(User4);


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (User[i].UserName != txtUserName.Text)
                {
                    MessageBox.Show("User Doenst Exist");
                }
                else
                {
                    if (User[i].Password == txtPassword.Text)
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
