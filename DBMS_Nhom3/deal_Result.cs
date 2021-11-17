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
    public partial class deal_Result : Form
    {
        private int Trans_id;
        public deal_Result(int id)
        {
            InitializeComponent();
            Trans_id = id;
        }

        private void deal_Result_Load(object sender, EventArgs e)
        {
            BLTransaction_Details transaction_Detail = new BLTransaction_Details();
            dataGridView1.DataSource = transaction_Detail.search_byTrans_ID(Trans_id).Tables[0];
        }
    }
}
