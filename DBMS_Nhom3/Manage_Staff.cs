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

        }

        private void Manage_Staff_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
