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
    public partial class Form_AddTrans : Form
    {
        BLProduct product = new BLProduct();
        string name_chosed = "";
        public Form_AddTrans()
        {
            InitializeComponent();
            LoadData();
        }

        private void GridView_ProductRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = GridView_ProductRecord.CurrentCell.RowIndex;
                if (GridView_ProductRecord.Rows[a].Cells[0].Value != null)
                {
                    // gán model name trong datagridview đã chọn
                    name_chosed = GridView_ProductRecord.Rows[a].Cells[0].Value.ToString();
                    Product_Search_Textbox.Text = name_chosed;
                    //label3.Text = Phone_Id;
                }
            }
            catch { }
        }
        void LoadData()
        {
            GridView_ProductRecord.DataSource = product.GetProduct().Tables[0];
        }

        private void Product_Search_Textbox_TextChanged(object sender, EventArgs e)
        {
            GridView_ProductRecord.DataSource = product.search_ProductName(Product_Search_Textbox.Text).Tables[0];
        }
    }
}
