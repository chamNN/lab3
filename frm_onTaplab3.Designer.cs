namespace onTapLab3
{
    partial class frm_onTaplab3
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
            this.lstB_chonLop = new System.Windows.Forms.ComboBox();
            this.lstv_danhSachLop = new System.Windows.Forms.ListView();
            this.lbl_chonLop = new System.Windows.Forms.Label();
            this.btn_xuatThongTin = new System.Windows.Forms.Button();
            this.lbl_ds = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstB_chonLop
            // 
            this.lstB_chonLop.FormattingEnabled = true;
            this.lstB_chonLop.Location = new System.Drawing.Point(303, 86);
            this.lstB_chonLop.Name = "lstB_chonLop";
            this.lstB_chonLop.Size = new System.Drawing.Size(181, 24);
            this.lstB_chonLop.TabIndex = 0;
            this.lstB_chonLop.SelectedIndexChanged += new System.EventHandler(this.lstB_chonLop_SelectedIndexChanged);
            // 
            // lstv_danhSachLop
            // 
            this.lstv_danhSachLop.GridLines = true;
            this.lstv_danhSachLop.HideSelection = false;
            this.lstv_danhSachLop.Location = new System.Drawing.Point(51, 167);
            this.lstv_danhSachLop.Name = "lstv_danhSachLop";
            this.lstv_danhSachLop.Size = new System.Drawing.Size(701, 256);
            this.lstv_danhSachLop.TabIndex = 1;
            this.lstv_danhSachLop.UseCompatibleStateImageBehavior = false;
            this.lstv_danhSachLop.View = System.Windows.Forms.View.Details;
            this.lstv_danhSachLop.SelectedIndexChanged += new System.EventHandler(this.lstv_danhSachLop_SelectedIndexChanged);
            // 
            // lbl_chonLop
            // 
            this.lbl_chonLop.AutoSize = true;
            this.lbl_chonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chonLop.Location = new System.Drawing.Point(198, 90);
            this.lbl_chonLop.Name = "lbl_chonLop";
            this.lbl_chonLop.Size = new System.Drawing.Size(80, 20);
            this.lbl_chonLop.TabIndex = 2;
            this.lbl_chonLop.Text = "Chọn lớp:";
            // 
            // btn_xuatThongTin
            // 
            this.btn_xuatThongTin.Location = new System.Drawing.Point(320, 454);
            this.btn_xuatThongTin.Name = "btn_xuatThongTin";
            this.btn_xuatThongTin.Size = new System.Drawing.Size(122, 35);
            this.btn_xuatThongTin.TabIndex = 3;
            this.btn_xuatThongTin.Text = "xuất thông tin";
            this.btn_xuatThongTin.UseVisualStyleBackColor = true;
            this.btn_xuatThongTin.Click += new System.EventHandler(this.btn_xuatThongTin_Click);
            // 
            // lbl_ds
            // 
            this.lbl_ds.AutoSize = true;
            this.lbl_ds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ds.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_ds.Location = new System.Drawing.Point(196, 24);
            this.lbl_ds.Name = "lbl_ds";
            this.lbl_ds.Size = new System.Drawing.Size(342, 32);
            this.lbl_ds.TabIndex = 4;
            this.lbl_ds.Text = "DANH SÁCH SINH VIÊN";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(524, 454);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(122, 35);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // frm_onTaplab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 510);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.lbl_ds);
            this.Controls.Add(this.btn_xuatThongTin);
            this.Controls.Add(this.lbl_chonLop);
            this.Controls.Add(this.lstv_danhSachLop);
            this.Controls.Add(this.lstB_chonLop);
            this.Name = "frm_onTaplab3";
            this.Text = "bài làm";
            this.Load += new System.EventHandler(this.frm_onTaplab3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstB_chonLop;
        private System.Windows.Forms.ListView lstv_danhSachLop;
        private System.Windows.Forms.Label lbl_chonLop;
        private System.Windows.Forms.Button btn_xuatThongTin;
        private System.Windows.Forms.Label lbl_ds;
        private System.Windows.Forms.Button btn_xoa;
    }
}

