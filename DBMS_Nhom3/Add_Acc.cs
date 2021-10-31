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
    public partial class Add_Acc : Form
    {
        public Add_Acc()
        {
            InitializeComponent();
        }

        private void Yes_Button_Click(object sender, EventArgs e)
        {
            BLAccount bLAccount = new BLAccount();
            bLAccount.addAccount(User_Textbox.Text, Pass_Textbox.Text);
            this.Close();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            User_Textbox.Text = "";
            Pass_Textbox.Text = "";
        }
    }
}
