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
    public partial class Form_product : Form
    {
        BLProduct product = new BLProduct();
        public Form_product()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            GridView_ProductRecord.DataSource = product.GetProduct().Tables[0];
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void GridView_PhoneRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form_product_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txt_ProductName_TextChanged(object sender, EventArgs e)
        {
            GridView_ProductRecord.DataSource = product.search_ProductName(Name_Textbox.Text).Tables[0];
        }
    }
}
