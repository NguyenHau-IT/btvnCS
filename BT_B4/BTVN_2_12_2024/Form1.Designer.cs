namespace BT_B4
{
    partial class Form1
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
            this.dtg_quanlyNV = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_quanlyNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_quanlyNV
            // 
            this.dtg_quanlyNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_quanlyNV.Location = new System.Drawing.Point(12, 12);
            this.dtg_quanlyNV.Name = "dtg_quanlyNV";
            this.dtg_quanlyNV.RowHeadersWidth = 51;
            this.dtg_quanlyNV.RowTemplate.Height = 24;
            this.dtg_quanlyNV.Size = new System.Drawing.Size(567, 426);
            this.dtg_quanlyNV.TabIndex = 0;
            this.dtg_quanlyNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_quanlyNV_CellClick);
            this.dtg_quanlyNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_quanlysinhvien_CellContentClick);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(632, 27);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(118, 32);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(632, 81);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(118, 32);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(632, 140);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(118, 32);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(632, 194);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(118, 32);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtg_quanlyNV);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List View";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_quanlyNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_quanlyNV;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_close;
    }
}

