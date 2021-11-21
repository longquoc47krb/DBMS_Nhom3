using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBMS_Nhom3
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }


        private void addTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddTrans addtrans = new Form_AddTrans();
            addtrans.ShowDialog();
        }

        private void transactionDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TransactionDetails trans_details = new Form_TransactionDetails();
            trans_details.ShowDialog();
        }

        private void addNewPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_add_Product add_Product = new Form_add_Product();
            add_Product.ShowDialog();
        }

        private void phoneDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_product f_product = new Form_product();
            f_product.ShowDialog();
        }

        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Pass_frm changepass = new Change_Pass_frm();
            changepass.ShowDialog();
        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form_Login.isAdmin)
            {
                Add_Staff add_Acc = new Add_Staff();
                add_Acc.ShowDialog();
            }
            else
            {
                MessageBox.Show("You are not the Administrator");
            }
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form_Login.isAdmin)
            {
                Manage_Staff acc = new Manage_Staff();
                acc.ShowDialog();
            }
            else
            {
                MessageBox.Show("You are not the Administrator");
            }

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_monthRevenue frmRe = new Form_monthRevenue();
            frmRe.ShowDialog();
        }

        private void warrantyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_warranty warranty = new Form_warranty();
            warranty.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
