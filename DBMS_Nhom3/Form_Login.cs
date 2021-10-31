using DBMS_Nhom3.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBMS_Nhom3
{
    public partial class Form_Login : Form
    {
        public static string currentAccount = "";
        public static string currentPass = "";
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = txt_Username.Text;
            string pass = txt_Password.Text;
            BLAccount acc = new BLAccount();

            if (acc.checkAccount(user, pass))
            {

                currentAccount = user;
                currentPass = pass;
                this.Visible = false;
                Form_Home obj2 = new Form_Home();
                obj2.ShowDialog();
            }
            else
            {

                MessageBox.Show("Invalid username and Password.");

            }
        }

        private void txt_Password_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string user = txt_Username.Text;
                string pass = txt_Password.Text;
                BLAccount acc = new BLAccount();

                if (acc.checkAccount(user, pass))
                {

                    currentAccount = user;
                    currentPass = pass;
                    this.Visible = false;
                    Form_Home obj2 = new Form_Home();
                    obj2.ShowDialog();
                }
                else
                {

                    MessageBox.Show("Invalid username and Password.");

                }
            }
        }
    }
}
