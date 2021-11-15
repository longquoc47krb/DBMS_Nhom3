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
        string name_delete = "";
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form_product_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txt_ProductName_TextChanged(object sender, EventArgs e)
        {
            GridView_ProductRecord.DataSource = product.search_ProductName(txt_ProductName.Text).Tables[0];
        }

        private void GridView_ProductRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = GridView_ProductRecord.CurrentCell.RowIndex;
                if (GridView_ProductRecord.Rows[a].Cells[0].Value != null)
                {
                    // gán model name trong datagridview đã chọn
                    name_delete = GridView_ProductRecord.Rows[a].Cells[0].Value.ToString();
                    txt_ProductName.Text = name_delete;
                    //label3.Text = Phone_Id;
                }
            }
            catch { }
        }
    }
}
