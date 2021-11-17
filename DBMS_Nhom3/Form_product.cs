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
        string id_delete = "";
        string id_pro = "";
        string chosed_name = "";
        string chosed_price = "";
        string id_com = "";
        string x="";
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
            product.deleteProduct(ref x, id_delete);
            this.Controls.Clear();
            this.InitializeComponent();
            LoadData();

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form_Edit_product edit_pro = new Form_Edit_product(id_pro,chosed_name,chosed_price,id_com);
            edit_pro.ShowDialog();
            this.Controls.Clear();
            this.InitializeComponent();
            LoadData();
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
                    id_delete = GridView_ProductRecord.Rows[a].Cells[1].Value.ToString();
                    id_pro = id_delete;
                    chosed_name = GridView_ProductRecord.Rows[a].Cells[0].Value.ToString();
                    chosed_price = GridView_ProductRecord.Rows[a].Cells[2].Value.ToString();
                    id_com = GridView_ProductRecord.Rows[a].Cells[3].Value.ToString();
                    txt_ProductName.Text = GridView_ProductRecord.Rows[a].Cells[0].Value.ToString();
                    
                    //label3.Text = Phone_Id;
                }
            }
            catch { }
        }
    }
}
