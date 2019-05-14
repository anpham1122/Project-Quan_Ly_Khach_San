namespace quanlydatphongkhachsan
{
    partial class frmLoaiphong
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
            this.lvLoaiphong = new System.Windows.Forms.ListView();
            this.colLPMasoloaiphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLPLoaiphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLPGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLPThem = new System.Windows.Forms.Button();
            this.btnLPSua = new System.Windows.Forms.Button();
            this.btnLPXoa = new System.Windows.Forms.Button();
            this.btnLPThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLPHuy = new System.Windows.Forms.Button();
            this.btnLPluu = new System.Windows.Forms.Button();
            this.cbLPLoaiphong = new System.Windows.Forms.ComboBox();
            this.txtLPMasoloaiphong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLPGiatien = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvLoaiphong
            // 
            this.lvLoaiphong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLPMasoloaiphong,
            this.colLPLoaiphong,
            this.colLPGia});
            this.lvLoaiphong.Location = new System.Drawing.Point(12, 207);
            this.lvLoaiphong.Name = "lvLoaiphong";
            this.lvLoaiphong.Size = new System.Drawing.Size(658, 205);
            this.lvLoaiphong.TabIndex = 5;
            this.lvLoaiphong.UseCompatibleStateImageBehavior = false;
            this.lvLoaiphong.View = System.Windows.Forms.View.Details;
            // 
            // colLPMasoloaiphong
            // 
            this.colLPMasoloaiphong.Text = "Mã số loại phòng";
            this.colLPMasoloaiphong.Width = 210;
            // 
            // colLPLoaiphong
            // 
            this.colLPLoaiphong.Text = "Loại phòng";
            this.colLPLoaiphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLPLoaiphong.Width = 229;
            // 
            // colLPGia
            // 
            this.colLPGia.Text = "Giá";
            this.colLPGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLPGia.Width = 215;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLPThem);
            this.groupBox2.Controls.Add(this.btnLPSua);
            this.groupBox2.Controls.Add(this.btnLPXoa);
            this.groupBox2.Controls.Add(this.btnLPThoat);
            this.groupBox2.Location = new System.Drawing.Point(537, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 188);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnLPThem
            // 
            this.btnLPThem.Location = new System.Drawing.Point(29, 27);
            this.btnLPThem.Name = "btnLPThem";
            this.btnLPThem.Size = new System.Drawing.Size(80, 31);
            this.btnLPThem.TabIndex = 9;
            this.btnLPThem.Text = "Thêm";
            this.btnLPThem.UseVisualStyleBackColor = true;
            // 
            // btnLPSua
            // 
            this.btnLPSua.Location = new System.Drawing.Point(29, 67);
            this.btnLPSua.Name = "btnLPSua";
            this.btnLPSua.Size = new System.Drawing.Size(80, 31);
            this.btnLPSua.TabIndex = 10;
            this.btnLPSua.Text = "Sửa";
            this.btnLPSua.UseVisualStyleBackColor = true;
            // 
            // btnLPXoa
            // 
            this.btnLPXoa.Location = new System.Drawing.Point(29, 104);
            this.btnLPXoa.Name = "btnLPXoa";
            this.btnLPXoa.Size = new System.Drawing.Size(80, 31);
            this.btnLPXoa.TabIndex = 12;
            this.btnLPXoa.Text = "Xóa";
            this.btnLPXoa.UseVisualStyleBackColor = true;
            // 
            // btnLPThoat
            // 
            this.btnLPThoat.Location = new System.Drawing.Point(29, 141);
            this.btnLPThoat.Name = "btnLPThoat";
            this.btnLPThoat.Size = new System.Drawing.Size(80, 31);
            this.btnLPThoat.TabIndex = 11;
            this.btnLPThoat.Text = "Thoát";
            this.btnLPThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLPGiatien);
            this.groupBox1.Controls.Add(this.btnLPHuy);
            this.groupBox1.Controls.Add(this.btnLPluu);
            this.groupBox1.Controls.Add(this.cbLPLoaiphong);
            this.groupBox1.Controls.Add(this.txtLPMasoloaiphong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnLPHuy
            // 
            this.btnLPHuy.Location = new System.Drawing.Point(410, 104);
            this.btnLPHuy.Name = "btnLPHuy";
            this.btnLPHuy.Size = new System.Drawing.Size(75, 37);
            this.btnLPHuy.TabIndex = 8;
            this.btnLPHuy.Text = "Hủy";
            this.btnLPHuy.UseVisualStyleBackColor = true;
            // 
            // btnLPluu
            // 
            this.btnLPluu.Location = new System.Drawing.Point(410, 33);
            this.btnLPluu.Name = "btnLPluu";
            this.btnLPluu.Size = new System.Drawing.Size(75, 36);
            this.btnLPluu.TabIndex = 7;
            this.btnLPluu.Text = "lưu";
            this.btnLPluu.UseVisualStyleBackColor = true;
            // 
            // cbLPLoaiphong
            // 
            this.cbLPLoaiphong.FormattingEnabled = true;
            this.cbLPLoaiphong.Items.AddRange(new object[] {
            "Cao Cấp",
            "Trung Bình",
            "Bình Dân"});
            this.cbLPLoaiphong.Location = new System.Drawing.Point(177, 81);
            this.cbLPLoaiphong.Name = "cbLPLoaiphong";
            this.cbLPLoaiphong.Size = new System.Drawing.Size(198, 24);
            this.cbLPLoaiphong.TabIndex = 4;
            // 
            // txtLPMasoloaiphong
            // 
            this.txtLPMasoloaiphong.Location = new System.Drawing.Point(177, 24);
            this.txtLPMasoloaiphong.Name = "txtLPMasoloaiphong";
            this.txtLPMasoloaiphong.Size = new System.Drawing.Size(198, 22);
            this.txtLPMasoloaiphong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá tiền :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số loại phòng :";
            // 
            // txtLPGiatien
            // 
            this.txtLPGiatien.Location = new System.Drawing.Point(177, 135);
            this.txtLPGiatien.Name = "txtLPGiatien";
            this.txtLPGiatien.Size = new System.Drawing.Size(144, 22);
            this.txtLPGiatien.TabIndex = 9;
            // 
            // frmLoaiphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 419);
            this.Controls.Add(this.lvLoaiphong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLoaiphong";
            this.Text = "Loại phòng";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLoaiphong;
        private System.Windows.Forms.ColumnHeader colLPMasoloaiphong;
        private System.Windows.Forms.ColumnHeader colLPLoaiphong;
        private System.Windows.Forms.ColumnHeader colLPGia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLPThem;
        private System.Windows.Forms.Button btnLPSua;
        private System.Windows.Forms.Button btnLPXoa;
        private System.Windows.Forms.Button btnLPThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLPHuy;
        private System.Windows.Forms.Button btnLPluu;
        private System.Windows.Forms.ComboBox cbLPLoaiphong;
        private System.Windows.Forms.TextBox txtLPMasoloaiphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLPGiatien;
    }
}