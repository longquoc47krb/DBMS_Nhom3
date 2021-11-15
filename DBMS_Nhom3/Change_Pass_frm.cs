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
    public partial class Change_Pass_frm : Form
    {
        public Change_Pass_frm()
        {
            InitializeComponent();
        }
        string x = "";
        private void Yes_Butoon_Click(object sender, EventArgs e)
        {
            BLStaff bLStaff = new BLStaff();
            if (Form_Login.currentPass == Old_pass_textbox.Text)
            {
                bLStaff.updateAccount(Form_Login.currentAccount, New_pass_textbox.Text, ref x);
                MessageBox.Show("Doi Thanh Cong");
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Old Password");
            }

        }
    }
}
