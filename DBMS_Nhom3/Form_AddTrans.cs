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
        string id_Currentproduct;
        string price = "";

        private int Total_cost = 0;
        // biến trỏ giá trị trong datagridvieww
        private int index;
        // biến trỏ giá trị để xoá trong datagridview
        private int index_remove;
        private List<string> product_name_buying = new List<string>();
        private List<string> product_ID_buying = new List<string>();
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
                    id_Currentproduct = GridView_ProductRecord.Rows[a].Cells[1].Value.ToString();
                    price = GridView_ProductRecord.Rows[a].Cells[2].Value.ToString();
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

        private void Form_AddTrans_Load(object sender, EventArgs e)
        {

        }
        private bool isAlready(string IDProduct) // kiểm tra sản phẩm đã có trong giỏ hàng chưa
        {
            for (int i = 0; i < GridView_Cart.Rows.Count; i++)
            {
                if (GridView_Cart.Rows[i].Cells[1].Value != null)
                {
                    if (GridView_Cart.Rows[i].Cells[1].Value.Equals(IDProduct))
                    {
                        index = i;
                        return true;
                    }
                }
            }
            return false;
        }
        private void Add_Product_Button_Click(object sender, EventArgs e)
        {
            if ((int)quantity_numericUpDown.Value > 0 && Product_Search_Textbox.Text != "")
            {
                // kiểm tra điện thoại đã đươcc thêm hay chưa
                if (!isAlready(id_Currentproduct))
                {
                    GridView_Cart.Rows.Add(Product_Search_Textbox.Text, id_Currentproduct, price, quantity_numericUpDown.Value);
                    product_name_buying.Add(Product_Search_Textbox.Text);
                    product_ID_buying.Add(id_Currentproduct.ToString());
                }
                else
                {
                    // cập nhật lại cột số lượng trong hoá đơn
                    GridView_Cart[3, index].Value = int.Parse(GridView_Cart[3, index].Value.ToString()) + (int)quantity_numericUpDown.Value;
                    //phoneID.Add(temp_phoneID);
                }
                Total_cost += int.Parse(price.ToString()) * (int)quantity_numericUpDown.Value;
                Total_Cost_Textbox.Text = Total_cost.ToString();
                ////Debug
                //label10.Text = phoneID.Count.ToString();

                // reset lại panel điện thoại
                foreach (var c in Phone_Info_Panel.Controls)
                {
                    if (c is TextBox)
                    {
                        (c as TextBox).Text = "";
                    }
                    quantity_numericUpDown.Value = 1;
                }
            }
            else
            {
                MessageBox.Show("An image Phone ?");
            }
        }
    }
}
