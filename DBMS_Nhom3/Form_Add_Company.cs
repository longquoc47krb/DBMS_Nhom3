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
    public partial class Form_Add_Company : Form
    {
        CongTySX new_comp = new CongTySX();
        public Form_Add_Company()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
                if (c is ComboBox)
                {
                    (c as ComboBox).SelectedIndex = -1;
                    (c as ComboBox).Text = "--Select--";
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if((txt_address.Text=="") || (txt_CompName.Text == "") ||(txt_CompName.Text==""))
            {
                MessageBox.Show("Please, fill all attributes.");
            }
            else
            {
                new_comp.addCompany(txt_CompName.Text, txt_address.Text);
                this.Close();
                
            }
        }
    }
}
