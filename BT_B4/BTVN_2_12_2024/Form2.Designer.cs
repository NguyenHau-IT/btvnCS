namespace BT_B4
{
    partial class Form2
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_msnv = new System.Windows.Forms.TextBox();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(220, 70);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(213, 22);
            this.txt_name.TabIndex = 1;
            // 
            // txt_msnv
            // 
            this.txt_msnv.Location = new System.Drawing.Point(220, 28);
            this.txt_msnv.Name = "txt_msnv";
            this.txt_msnv.Size = new System.Drawing.Size(128, 22);
            this.txt_msnv.TabIndex = 0;
            // 
            // txt_luong
            // 
            this.txt_luong.Location = new System.Drawing.Point(220, 110);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(139, 22);
            this.txt_luong.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "MSNV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên nhân viên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lương CB:";
            // 
            // btn_yes
            // 
            this.btn_yes.Location = new System.Drawing.Point(158, 169);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(105, 34);
            this.btn_yes.TabIndex = 6;
            this.btn_yes.Text = "Đồng Ý";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(358, 169);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 34);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Bỏ Qua";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 241);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_luong);
            this.Controls.Add(this.txt_msnv);
            this.Controls.Add(this.txt_name);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân VIên";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_msnv;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_cancel;
    }
}