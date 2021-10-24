
namespace DBMS_Nhom3
{
    partial class Customer_Details
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
            this.Reload_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SDT_Textbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reload_Button
            // 
            this.Reload_Button.Location = new System.Drawing.Point(535, 72);
            this.Reload_Button.Name = "Reload_Button";
            this.Reload_Button.Size = new System.Drawing.Size(75, 23);
            this.Reload_Button.TabIndex = 7;
            this.Reload_Button.Text = "Reload";
            this.Reload_Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm Khách Hàng";
            // 
            // SDT_Textbox
            // 
            this.SDT_Textbox.Location = new System.Drawing.Point(347, 41);
            this.SDT_Textbox.Name = "SDT_Textbox";
            this.SDT_Textbox.Size = new System.Drawing.Size(263, 20);
            this.SDT_Textbox.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(508, 300);
            this.dataGridView1.TabIndex = 4;
            // 
            // Custom_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reload_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SDT_Textbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Custom_Details";
            this.Text = "Custom_Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reload_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SDT_Textbox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}