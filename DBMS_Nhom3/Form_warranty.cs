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
    public partial class Form_warranty : Form
    {
        BLUtils utils = new BLUtils();
        public Form_warranty()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dataGridView1.DataSource = utils.GetWarrantyView().Tables[0];
        }
        private void Form_warranty_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = utils.searchWarranty_byPhone(textBox1.Text).Tables[0];
        }
    }
}
