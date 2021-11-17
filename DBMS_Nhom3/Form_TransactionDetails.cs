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
    public partial class Form_TransactionDetails : Form
    {
        BLTransaction_Details transaction_Detail = new BLTransaction_Details();
        private string idtrans;
        private string x = " ";
        public Form_TransactionDetails()
        {
            InitializeComponent();
        }

        private void Form_TransactionDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            GridView_Details_Trans.DataSource = transaction_Detail.getTransaction_details().Tables[0];
            GridView_Details_Trans.Columns[14].HeaderText = "Seller";

            //// Ẩn các dòng ko cần thiết

            GridView_Details_Trans.Columns[9].Visible = false;
            GridView_Details_Trans.Columns[10].Visible = false;
            GridView_Details_Trans.Columns[11].Visible = false;
            GridView_Details_Trans.Columns[12].Visible = false;
            GridView_Details_Trans.Columns[13].Visible = false;

            GridView_Details_Trans.AutoResizeColumns();
        }

        private void GridView_Details_Trans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = GridView_Details_Trans.CurrentCell.RowIndex;
                if (GridView_Details_Trans.Rows[a].Cells[8].Value != null)
                {
                    // gán model name trong datagridview đã chọn
                    idtrans = GridView_Details_Trans.Rows[a].Cells[8].Value.ToString();
                    txt_PhoneFind.Text = GridView_Details_Trans.Rows[a].Cells[1].Value.ToString();
                    GridView_Details_Trans.Rows.Clear();
                    GridView_Details_Trans.Refresh();
                }

            }
            catch { }
        }

        private void txt_PhoneFind_TextChanged(object sender, EventArgs e)
        {
            GridView_Details_Trans.DataSource = transaction_Detail.search_byPhone(txt_PhoneFind.Text).Tables[0];
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            transaction_Detail.deleteTransaction_details(idtrans);
            txt_PhoneFind.Text = "";
            LoadData();
        }
    }
}
