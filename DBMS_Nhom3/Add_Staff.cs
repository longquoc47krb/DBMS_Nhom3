using DBMS_Nhom3.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBMS_Nhom3
{
    public partial class Add_Staff : Form
    {
        public Add_Staff()
        {
            InitializeComponent();
        }
        

        private void Yes_Button_Click(object sender, EventArgs e)
        {
            BLStaff staff = new BLStaff();
            staff.addStaff(User_Textbox.Text, Pass_Textbox.Text,staffname_Textbox.Text,phone_Textbox.Text,address_Textbox.Text,position_Textbox.Text,gender_Textbox.Text);
            reset();
        }

        private void reset()
        {
            User_Textbox.Text = "";
            Pass_Textbox.Text = "";
            Pass_Textbox.Text = "";
            staffname_Textbox.Text = "";
            phone_Textbox.Text = "";
            address_Textbox.Text = "";
            position_Textbox.Text = "";
            gender_Textbox.Text = "";
        }
        private void Reset_Button_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
