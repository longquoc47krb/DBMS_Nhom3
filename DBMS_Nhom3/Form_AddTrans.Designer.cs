
namespace DBMS_Nhom3
{
    partial class Form_AddTrans
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddTrans));
            this.label5 = new System.Windows.Forms.Label();
            this.dtpk_BuyDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Phone_Number_Textbox = new System.Windows.Forms.TextBox();
            this.product_label = new System.Windows.Forms.Label();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.Phone_Number_Label = new System.Windows.Forms.Label();
            this.Product_Search_Textbox = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Customer_Inf_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.Total_Cost_Textbox = new System.Windows.Forms.TextBox();
            this.Total_Price_Label = new System.Windows.Forms.Label();
            this.GridView_Cart = new System.Windows.Forms.DataGridView();
            this.Product_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Export_Button = new System.Windows.Forms.Button();
            this.Phone_Info_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GridView_ProductRecord = new System.Windows.Forms.DataGridView();
            this.Add_Product_Button = new System.Windows.Forms.Button();
            this.Phone_Inf_Label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Cart)).BeginInit();
            this.Customer_Panel.SuspendLayout();
            this.Phone_Info_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ProductRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(26, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date:";
            // 
            // dtpk_BuyDate
            // 
            this.dtpk_BuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_BuyDate.Location = new System.Drawing.Point(68, 119);
            this.dtpk_BuyDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpk_BuyDate.Name = "dtpk_BuyDate";
            this.dtpk_BuyDate.Size = new System.Drawing.Size(151, 20);
            this.dtpk_BuyDate.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Phone_Number_Textbox
            // 
            this.Phone_Number_Textbox.BackColor = System.Drawing.SystemColors.Control;
            this.Phone_Number_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phone_Number_Textbox.Location = new System.Drawing.Point(69, 90);
            this.Phone_Number_Textbox.Name = "Phone_Number_Textbox";
            this.Phone_Number_Textbox.Size = new System.Drawing.Size(270, 13);
            this.Phone_Number_Textbox.TabIndex = 10;
            // 
            // product_label
            // 
            this.product_label.AutoSize = true;
            this.product_label.Location = new System.Drawing.Point(10, 32);
            this.product_label.Name = "product_label";
            this.product_label.Size = new System.Drawing.Size(75, 13);
            this.product_label.TabIndex = 15;
            this.product_label.Text = "Product Name";
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.BackColor = System.Drawing.SystemColors.Control;
            this.Name_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_Textbox.Location = new System.Drawing.Point(68, 53);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(270, 13);
            this.Name_Textbox.TabIndex = 8;
            // 
            // Phone_Number_Label
            // 
            this.Phone_Number_Label.AutoSize = true;
            this.Phone_Number_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Number_Label.ForeColor = System.Drawing.Color.Blue;
            this.Phone_Number_Label.Location = new System.Drawing.Point(30, 90);
            this.Phone_Number_Label.Name = "Phone_Number_Label";
            this.Phone_Number_Label.Size = new System.Drawing.Size(36, 13);
            this.Phone_Number_Label.TabIndex = 2;
            this.Phone_Number_Label.Text = "Call :";
            // 
            // Product_Search_Textbox
            // 
            this.Product_Search_Textbox.Location = new System.Drawing.Point(102, 29);
            this.Product_Search_Textbox.Name = "Product_Search_Textbox";
            this.Product_Search_Textbox.Size = new System.Drawing.Size(254, 20);
            this.Product_Search_Textbox.TabIndex = 13;
            this.Product_Search_Textbox.TextChanged += new System.EventHandler(this.Product_Search_Textbox_TextChanged);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.ForeColor = System.Drawing.Color.Blue;
            this.Name_Label.Location = new System.Drawing.Point(23, 52);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(47, 13);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(68, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 1);
            this.panel1.TabIndex = 7;
            // 
            // Customer_Inf_Label
            // 
            this.Customer_Inf_Label.AutoSize = true;
            this.Customer_Inf_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Inf_Label.ForeColor = System.Drawing.Color.Blue;
            this.Customer_Inf_Label.Location = new System.Drawing.Point(105, 4);
            this.Customer_Inf_Label.Name = "Customer_Inf_Label";
            this.Customer_Inf_Label.Size = new System.Drawing.Size(148, 16);
            this.Customer_Inf_Label.TabIndex = 3;
            this.Customer_Inf_Label.Text = "Customer Infomation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cart";
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(594, 297);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(75, 46);
            this.Reset_Button.TabIndex = 35;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(387, 297);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(75, 46);
            this.Remove_Button.TabIndex = 34;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // Total_Cost_Textbox
            // 
            this.Total_Cost_Textbox.Enabled = false;
            this.Total_Cost_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Cost_Textbox.Location = new System.Drawing.Point(391, 392);
            this.Total_Cost_Textbox.Name = "Total_Cost_Textbox";
            this.Total_Cost_Textbox.Size = new System.Drawing.Size(312, 27);
            this.Total_Cost_Textbox.TabIndex = 32;
            // 
            // Total_Price_Label
            // 
            this.Total_Price_Label.AutoSize = true;
            this.Total_Price_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Price_Label.Location = new System.Drawing.Point(387, 366);
            this.Total_Price_Label.Name = "Total_Price_Label";
            this.Total_Price_Label.Size = new System.Drawing.Size(56, 24);
            this.Total_Price_Label.TabIndex = 31;
            this.Total_Price_Label.Text = "Total";
            // 
            // GridView_Cart
            // 
            this.GridView_Cart.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridView_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Column,
            this.ID,
            this.Price_Column,
            this.Quantity_Column});
            this.GridView_Cart.Location = new System.Drawing.Point(6, 202);
            this.GridView_Cart.Name = "GridView_Cart";
            this.GridView_Cart.RowHeadersVisible = false;
            this.GridView_Cart.RowHeadersWidth = 51;
            this.GridView_Cart.Size = new System.Drawing.Size(375, 229);
            this.GridView_Cart.TabIndex = 30;
            this.GridView_Cart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Cart_CellClick);
            // 
            // Product_Column
            // 
            this.Product_Column.HeaderText = "Product";
            this.Product_Column.MinimumWidth = 6;
            this.Product_Column.Name = "Product_Column";
            this.Product_Column.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Price_Column
            // 
            this.Price_Column.HeaderText = "Price (vnđ)";
            this.Price_Column.MinimumWidth = 6;
            this.Price_Column.Name = "Price_Column";
            this.Price_Column.ReadOnly = true;
            this.Price_Column.Width = 125;
            // 
            // Quantity_Column
            // 
            this.Quantity_Column.HeaderText = "Quantity";
            this.Quantity_Column.MinimumWidth = 6;
            this.Quantity_Column.Name = "Quantity_Column";
            this.Quantity_Column.ReadOnly = true;
            this.Quantity_Column.Width = 50;
            // 
            // Customer_Panel
            // 
            this.Customer_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Customer_Panel.Controls.Add(this.label5);
            this.Customer_Panel.Controls.Add(this.dtpk_BuyDate);
            this.Customer_Panel.Controls.Add(this.pictureBox1);
            this.Customer_Panel.Controls.Add(this.Phone_Number_Textbox);
            this.Customer_Panel.Controls.Add(this.Name_Textbox);
            this.Customer_Panel.Controls.Add(this.panel3);
            this.Customer_Panel.Controls.Add(this.panel1);
            this.Customer_Panel.Controls.Add(this.Customer_Inf_Label);
            this.Customer_Panel.Controls.Add(this.Name_Label);
            this.Customer_Panel.Controls.Add(this.Phone_Number_Label);
            this.Customer_Panel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Customer_Panel.Location = new System.Drawing.Point(6, 12);
            this.Customer_Panel.Name = "Customer_Panel";
            this.Customer_Panel.Size = new System.Drawing.Size(375, 153);
            this.Customer_Panel.TabIndex = 28;
            this.Customer_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Customer_Panel_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(72, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 1);
            this.panel3.TabIndex = 7;
            // 
            // Export_Button
            // 
            this.Export_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Export_Button.BackgroundImage")));
            this.Export_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Export_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_Button.Location = new System.Drawing.Point(709, 320);
            this.Export_Button.Name = "Export_Button";
            this.Export_Button.Size = new System.Drawing.Size(85, 99);
            this.Export_Button.TabIndex = 33;
            this.Export_Button.Text = "OK - Deal";
            this.Export_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Export_Button.UseVisualStyleBackColor = true;
            this.Export_Button.Click += new System.EventHandler(this.Export_Button_Click);
            // 
            // Phone_Info_Panel
            // 
            this.Phone_Info_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Phone_Info_Panel.Controls.Add(this.label1);
            this.Phone_Info_Panel.Controls.Add(this.quantity_numericUpDown);
            this.Phone_Info_Panel.Controls.Add(this.GridView_ProductRecord);
            this.Phone_Info_Panel.Controls.Add(this.product_label);
            this.Phone_Info_Panel.Controls.Add(this.Product_Search_Textbox);
            this.Phone_Info_Panel.Controls.Add(this.Add_Product_Button);
            this.Phone_Info_Panel.Controls.Add(this.Phone_Inf_Label);
            this.Phone_Info_Panel.Location = new System.Drawing.Point(387, 12);
            this.Phone_Info_Panel.Name = "Phone_Info_Panel";
            this.Phone_Info_Panel.Size = new System.Drawing.Size(407, 279);
            this.Phone_Info_Panel.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Quantity_label";
            // 
            // quantity_numericUpDown
            // 
            this.quantity_numericUpDown.Location = new System.Drawing.Point(123, 251);
            this.quantity_numericUpDown.Name = "quantity_numericUpDown";
            this.quantity_numericUpDown.Size = new System.Drawing.Size(69, 20);
            this.quantity_numericUpDown.TabIndex = 67;
            this.quantity_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GridView_ProductRecord
            // 
            this.GridView_ProductRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_ProductRecord.GridColor = System.Drawing.SystemColors.Control;
            this.GridView_ProductRecord.Location = new System.Drawing.Point(2, 55);
            this.GridView_ProductRecord.Name = "GridView_ProductRecord";
            this.GridView_ProductRecord.RowHeadersVisible = false;
            this.GridView_ProductRecord.Size = new System.Drawing.Size(400, 185);
            this.GridView_ProductRecord.TabIndex = 66;
            this.GridView_ProductRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_ProductRecord_CellClick);
            // 
            // Add_Product_Button
            // 
            this.Add_Product_Button.Location = new System.Drawing.Point(317, 246);
            this.Add_Product_Button.Name = "Add_Product_Button";
            this.Add_Product_Button.Size = new System.Drawing.Size(85, 25);
            this.Add_Product_Button.TabIndex = 9;
            this.Add_Product_Button.Text = "Add";
            this.Add_Product_Button.UseVisualStyleBackColor = true;
            this.Add_Product_Button.Click += new System.EventHandler(this.Add_Product_Button_Click);
            // 
            // Phone_Inf_Label
            // 
            this.Phone_Inf_Label.AutoSize = true;
            this.Phone_Inf_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Phone_Inf_Label.Location = new System.Drawing.Point(145, 7);
            this.Phone_Inf_Label.Name = "Phone_Inf_Label";
            this.Phone_Inf_Label.Size = new System.Drawing.Size(136, 16);
            this.Phone_Inf_Label.TabIndex = 8;
            this.Phone_Inf_Label.Text = "Product Infomation";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Form_AddTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 443);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Total_Cost_Textbox);
            this.Controls.Add(this.Total_Price_Label);
            this.Controls.Add(this.GridView_Cart);
            this.Controls.Add(this.Customer_Panel);
            this.Controls.Add(this.Export_Button);
            this.Controls.Add(this.Phone_Info_Panel);
            this.Name = "Form_AddTrans";
            this.Text = "Form_AddTrans";
            this.Load += new System.EventHandler(this.Form_AddTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Cart)).EndInit();
            this.Customer_Panel.ResumeLayout(false);
            this.Customer_Panel.PerformLayout();
            this.Phone_Info_Panel.ResumeLayout(false);
            this.Phone_Info_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_ProductRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpk_BuyDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Phone_Number_Textbox;
        private System.Windows.Forms.Label product_label;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.Label Phone_Number_Label;
        private System.Windows.Forms.TextBox Product_Search_Textbox;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Customer_Inf_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.TextBox Total_Cost_Textbox;
        private System.Windows.Forms.Label Total_Price_Label;
        private System.Windows.Forms.DataGridView GridView_Cart;
        private System.Windows.Forms.Panel Customer_Panel;
        private System.Windows.Forms.Button Export_Button;
        private System.Windows.Forms.Panel Phone_Info_Panel;
        private System.Windows.Forms.Button Add_Product_Button;
        private System.Windows.Forms.Label Phone_Inf_Label;
        private System.Windows.Forms.DataGridView GridView_ProductRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown quantity_numericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Column;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}