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
    public partial class Manage_Staff : Form
    {
        public Manage_Staff()
        {
            InitializeComponent();
        }
        string name_delete = "";
        string x = "";
        BLStaff acc = new BLStaff();
        void LoadData()
        {
            dataGridView1.DataSource = acc.GetStaff().Tables[0];
        }
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            acc.deleteAccount(ref x, name_delete);
            LoadData();
        }

        private void Manage_Staff_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int a = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1.Rows[a].Cells[0].Value != null)
                {
                    // gán model name trong datagridview đã chọn
                    name_delete = dataGridView1.Rows[a].Cells[0].Value.ToString();
                    Name_Textbox.Text = name_delete;
                    //label3.Text = Phone_Id;
                }
            }
            catch { }
        }

        private void Name_Textbox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = acc.FindStaff(Name_Textbox.Text).Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
