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
    public partial class Form_monthRevenue : Form
    {
        BLUtils re = new BLUtils();
        public Form_monthRevenue()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            dataGridView1.DataSource = re.GetRevenueView().Tables[0];
            dataGridView1.AutoResizeColumns();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_monthRevenue_Load(object sender, EventArgs e)
        {

        }
    }
}
