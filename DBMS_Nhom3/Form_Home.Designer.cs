
namespace DBMS_Nhom3
{
    partial class Form_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.menu_Home = new System.Windows.Forms.MenuStrip();
            this.addTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warrantyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Home
            // 
            this.menu_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionToolStripMenuItem,
            this.transactionDetailToolStripMenuItem,
            this.addNewProductToolStripMenuItem,
            this.phoneDetailsToolStripMenuItem,
            this.warrantyToolStripMenuItem,
            this.revenueToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menu_Home.Location = new System.Drawing.Point(0, 0);
            this.menu_Home.Name = "menu_Home";
            this.menu_Home.Size = new System.Drawing.Size(1081, 29);
            this.menu_Home.TabIndex = 2;
            this.menu_Home.Text = "menuStrip1";
            // 
            // addTransactionToolStripMenuItem
            // 
            this.addTransactionToolStripMenuItem.Name = "addTransactionToolStripMenuItem";
            this.addTransactionToolStripMenuItem.Size = new System.Drawing.Size(143, 25);
            this.addTransactionToolStripMenuItem.Text = "Add transaction";
            this.addTransactionToolStripMenuItem.Click += new System.EventHandler(this.addTransactionToolStripMenuItem_Click);
            // 
            // transactionDetailToolStripMenuItem
            // 
            this.transactionDetailToolStripMenuItem.Name = "transactionDetailToolStripMenuItem";
            this.transactionDetailToolStripMenuItem.Size = new System.Drawing.Size(165, 25);
            this.transactionDetailToolStripMenuItem.Text = "Transaction details";
            this.transactionDetailToolStripMenuItem.Click += new System.EventHandler(this.transactionDetailToolStripMenuItem_Click);
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(252, 25);
            this.addNewProductToolStripMenuItem.Text = "Add new product components";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewPhoneToolStripMenuItem_Click);
            // 
            // phoneDetailsToolStripMenuItem
            // 
            this.phoneDetailsToolStripMenuItem.Name = "phoneDetailsToolStripMenuItem";
            this.phoneDetailsToolStripMenuItem.Size = new System.Drawing.Size(236, 25);
            this.phoneDetailsToolStripMenuItem.Text = "product components details";
            this.phoneDetailsToolStripMenuItem.Click += new System.EventHandler(this.phoneDetailsToolStripMenuItem_Click);
            // 
            // warrantyToolStripMenuItem
            // 
            this.warrantyToolStripMenuItem.Name = "warrantyToolStripMenuItem";
            this.warrantyToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.warrantyToolStripMenuItem.Text = "warranty";
            this.warrantyToolStripMenuItem.Click += new System.EventHandler(this.warrantyToolStripMenuItem_Click);
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.revenueToolStripMenuItem.Text = "Revenue";
            this.revenueToolStripMenuItem.Click += new System.EventHandler(this.revenueToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePassWordToolStripMenuItem,
            this.addNewAccountToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // changePassWordToolStripMenuItem
            // 
            this.changePassWordToolStripMenuItem.Name = "changePassWordToolStripMenuItem";
            this.changePassWordToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.changePassWordToolStripMenuItem.Text = "ChangePassWord";
            this.changePassWordToolStripMenuItem.Click += new System.EventHandler(this.changePassWordToolStripMenuItem_Click);
            // 
            // addNewAccountToolStripMenuItem
            // 
            this.addNewAccountToolStripMenuItem.Name = "addNewAccountToolStripMenuItem";
            this.addNewAccountToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.addNewAccountToolStripMenuItem.Text = "Add New Staff";
            this.addNewAccountToolStripMenuItem.Click += new System.EventHandler(this.addNewAccountToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.menu_Home);
            this.Name = "Form_Home";
            this.Text = "Form_Home";
            this.menu_Home.ResumeLayout(false);
            this.menu_Home.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Home;
        private System.Windows.Forms.ToolStripMenuItem addTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePassWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warrantyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}