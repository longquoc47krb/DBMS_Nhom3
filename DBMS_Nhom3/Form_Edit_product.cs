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
    public partial class Form_Edit_product : Form
    {
        BLProduct edit_pro = new BLProduct();
        CongTySX com = new CongTySX();
        string ID_product = "";
        string name_product = "";
        string price = "";
        string id_company = "";
        string warranty_month = "";
        public Form_Edit_product(string id_pro, string name_pro, string price, string id_com,string warranty)
        {
            InitializeComponent();
            this.ID_product = id_pro;
            this.name_product = name_pro;
            this.price = price;
            this.id_company = id_com;
            this.warranty_month = warranty;
            txt_ProductName.Text = name_pro;
            txt_Price.Text = price;
            txt_IDCompany.Text = id_com;
            txt_ProductName.Enabled = false;
            warrantyTxt.Text = warranty;
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            edit_pro.updateProduct(this.ID_product, name_product, txt_Price.Text, id_company,warrantyTxt.Text);
            this.Close();
        }

        private void Form_Edit_product_Load(object sender, EventArgs e)
        {

        }

        private void txt_IDCompany_TextChanged(object sender, EventArgs e)
        {
            if(txt_IDCompany.Text=="")
            {
                dataGridView_comp.DataSource = com.GetCompany().Tables[0];
            }
            else
            {
                dataGridView_comp.DataSource = com.FindCongTySX_byID(txt_IDCompany.Text).Tables[0];
            }
            
        }

        private void dataGridView_comp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = dataGridView_comp.CurrentCell.RowIndex;
                if (dataGridView_comp.Rows[a].Cells[0].Value != null)
                {
                    // gán model name trong datagridview đã chọn
                    id_company = dataGridView_comp.Rows[a].Cells[0].Value.ToString();
                    txt_IDCompany.Text = id_company;

                    //label3.Text = Phone_Id;
                }
            }
            catch { }
        }
    }
}
