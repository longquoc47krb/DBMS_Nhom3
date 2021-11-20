using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DBMS_Nhom3.BSLayer;
namespace DBMS_Nhom3
{
    public partial class Form_add_Product : Form
    {
        CongTySX comp = new CongTySX();
        BLProduct new_pro = new BLProduct();
        string idcom = "";
        public Form_add_Product()
        {
            InitializeComponent();
            LoadData();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            new_pro.addProduct(txt_ProductName.Text, txt_Price.Text,idcom,warrantyTxt.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            LoadData();

        }
        void LoadData()
        {
            dataGridView_comp.DataSource = comp.GetCompany().Tables[0];
        }

        private void dataGridView_comp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = dataGridView_comp.CurrentCell.RowIndex;
                if (dataGridView_comp.Rows[a].Cells[0].Value != null)
                {
                    // gán model name trong datagridview đã chọn
                    idcom = dataGridView_comp.Rows[a].Cells[0].Value.ToString();
                    txt_Company.Text = dataGridView_comp.Rows[a].Cells[1].Value.ToString();
                    dataGridView_comp.Rows.Clear();
                    dataGridView_comp.Refresh();
                }

            }
            catch { }
        }

        private void txt_Company_TextChanged(object sender, EventArgs e)
        {
            dataGridView_comp.DataSource = comp.FindCongTySX(txt_Company.Text).Tables[0];
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

                this.Controls.Clear();
                this.InitializeComponent();
                LoadData();
            }

        }

        private void add_company_Click(object sender, EventArgs e)
        {
            Form_Add_Company add_com = new Form_Add_Company();
            add_com.ShowDialog();
        }

        private void Form_add_Product_Load(object sender, EventArgs e)
        {

        }
    }
}
