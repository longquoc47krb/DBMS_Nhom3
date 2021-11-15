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
        public Form_AddTrans()
        {
            InitializeComponent();
        }

        private void GridView_ProductRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Product_Search_Textbox_TextChanged(object sender, EventArgs e)
        {
            GridView_ProductRecord.DataSource = product.search_ProductName(Product_Search_Textbox.Text).Tables[0];
        }
    }
}
