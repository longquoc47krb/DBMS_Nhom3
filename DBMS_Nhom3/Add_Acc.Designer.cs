
namespace DBMS_Nhom3
{
    partial class Add_Acc
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
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Yes_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Pass_Textbox = new System.Windows.Forms.TextBox();
            this.User_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(210, 153);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(75, 23);
            this.Reset_Button.TabIndex = 15;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Yes_Button
            // 
            this.Yes_Button.Location = new System.Drawing.Point(42, 154);
            this.Yes_Button.Name = "Yes_Button";
            this.Yes_Button.Size = new System.Drawing.Size(75, 23);
            this.Yes_Button.TabIndex = 14;
            this.Yes_Button.Text = "Yes";
            this.Yes_Button.UseVisualStyleBackColor = true;
            this.Yes_Button.Click += new System.EventHandler(this.Yes_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thêm Tài Khoản";
            // 
            // Pass_Textbox
            // 
            this.Pass_Textbox.Location = new System.Drawing.Point(158, 111);
            this.Pass_Textbox.Name = "Pass_Textbox";
            this.Pass_Textbox.Size = new System.Drawing.Size(168, 20);
            this.Pass_Textbox.TabIndex = 12;
            // 
            // User_Textbox
            // 
            this.User_Textbox.Location = new System.Drawing.Point(158, 69);
            this.User_Textbox.Name = "User_Textbox";
            this.User_Textbox.Size = new System.Drawing.Size(168, 20);
            this.User_Textbox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "PassWord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "User Name";
            // 
            // Add_Acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 207);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Yes_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pass_Textbox);
            this.Controls.Add(this.User_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Acc";
            this.Text = "Add_Acc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Yes_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pass_Textbox;
        private System.Windows.Forms.TextBox User_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}