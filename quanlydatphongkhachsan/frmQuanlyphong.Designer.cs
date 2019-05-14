namespace quanlydatphongkhachsan
{
    partial class frmQuanlyphong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQLPMasophong = new System.Windows.Forms.TextBox();
            this.cbQLPLoaiphong = new System.Windows.Forms.ComboBox();
            this.radQLPTrong = new System.Windows.Forms.RadioButton();
            this.radQLPDadat = new System.Windows.Forms.RadioButton();
            this.btnQLPluu = new System.Windows.Forms.Button();
            this.btnQLPHuy = new System.Windows.Forms.Button();
            this.btnQLPThem = new System.Windows.Forms.Button();
            this.btnQLPSua = new System.Windows.Forms.Button();
            this.btnQLPThoat = new System.Windows.Forms.Button();
            this.btnQLPXoa = new System.Windows.Forms.Button();
            this.lvQuanlyphong = new System.Windows.Forms.ListView();
            this.colQLPMasophong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQLPLoaiphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQLPTinhtrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQLPHuy);
            this.groupBox1.Controls.Add(this.btnQLPluu);
            this.groupBox1.Controls.Add(this.radQLPDadat);
            this.groupBox1.Controls.Add(this.radQLPTrong);
            this.groupBox1.Controls.Add(this.cbQLPLoaiphong);
            this.groupBox1.Controls.Add(this.txtQLPMasophong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQLPThem);
            this.groupBox2.Controls.Add(this.btnQLPSua);
            this.groupBox2.Controls.Add(this.btnQLPXoa);
            this.groupBox2.Controls.Add(this.btnQLPThoat);
            this.groupBox2.Location = new System.Drawing.Point(537, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số phòng :";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tình trạng :";
            // 
            // txtQLPMasophong
            // 
            this.txtQLPMasophong.Location = new System.Drawing.Point(144, 24);
            this.txtQLPMasophong.Name = "txtQLPMasophong";
            this.txtQLPMasophong.Size = new System.Drawing.Size(144, 22);
            this.txtQLPMasophong.TabIndex = 3;
            // 
            // cbQLPLoaiphong
            // 
            this.cbQLPLoaiphong.FormattingEnabled = true;
            this.cbQLPLoaiphong.Items.AddRange(new object[] {
            "Cao Cấp",
            "Trung Bình",
            "Bình Dân"});
            this.cbQLPLoaiphong.Location = new System.Drawing.Point(144, 81);
            this.cbQLPLoaiphong.Name = "cbQLPLoaiphong";
            this.cbQLPLoaiphong.Size = new System.Drawing.Size(198, 24);
            this.cbQLPLoaiphong.TabIndex = 4;
            // 
            // radQLPTrong
            // 
            this.radQLPTrong.AutoSize = true;
            this.radQLPTrong.Location = new System.Drawing.Point(160, 136);
            this.radQLPTrong.Name = "radQLPTrong";
            this.radQLPTrong.Size = new System.Drawing.Size(67, 21);
            this.radQLPTrong.TabIndex = 5;
            this.radQLPTrong.TabStop = true;
            this.radQLPTrong.Text = "Trống";
            this.radQLPTrong.UseVisualStyleBackColor = true;
            // 
            // radQLPDadat
            // 
            this.radQLPDadat.AutoSize = true;
            this.radQLPDadat.Location = new System.Drawing.Point(273, 136);
            this.radQLPDadat.Name = "radQLPDadat";
            this.radQLPDadat.Size = new System.Drawing.Size(69, 21);
            this.radQLPDadat.TabIndex = 6;
            this.radQLPDadat.TabStop = true;
            this.radQLPDadat.Text = "đã đặt";
            this.radQLPDadat.UseVisualStyleBackColor = true;
            // 
            // btnQLPluu
            // 
            this.btnQLPluu.Location = new System.Drawing.Point(410, 33);
            this.btnQLPluu.Name = "btnQLPluu";
            this.btnQLPluu.Size = new System.Drawing.Size(75, 36);
            this.btnQLPluu.TabIndex = 7;
            this.btnQLPluu.Text = "lưu";
            this.btnQLPluu.UseVisualStyleBackColor = true;
            // 
            // btnQLPHuy
            // 
            this.btnQLPHuy.Location = new System.Drawing.Point(410, 104);
            this.btnQLPHuy.Name = "btnQLPHuy";
            this.btnQLPHuy.Size = new System.Drawing.Size(75, 37);
            this.btnQLPHuy.TabIndex = 8;
            this.btnQLPHuy.Text = "Hủy";
            this.btnQLPHuy.UseVisualStyleBackColor = true;
            // 
            // btnQLPThem
            // 
            this.btnQLPThem.Location = new System.Drawing.Point(29, 27);
            this.btnQLPThem.Name = "btnQLPThem";
            this.btnQLPThem.Size = new System.Drawing.Size(80, 31);
            this.btnQLPThem.TabIndex = 9;
            this.btnQLPThem.Text = "Thêm";
            this.btnQLPThem.UseVisualStyleBackColor = true;
            // 
            // btnQLPSua
            // 
            this.btnQLPSua.Location = new System.Drawing.Point(29, 67);
            this.btnQLPSua.Name = "btnQLPSua";
            this.btnQLPSua.Size = new System.Drawing.Size(80, 31);
            this.btnQLPSua.TabIndex = 10;
            this.btnQLPSua.Text = "Sửa";
            this.btnQLPSua.UseVisualStyleBackColor = true;
            // 
            // btnQLPThoat
            // 
            this.btnQLPThoat.Location = new System.Drawing.Point(29, 141);
            this.btnQLPThoat.Name = "btnQLPThoat";
            this.btnQLPThoat.Size = new System.Drawing.Size(80, 31);
            this.btnQLPThoat.TabIndex = 11;
            this.btnQLPThoat.Text = "Thoát";
            this.btnQLPThoat.UseVisualStyleBackColor = true;
            // 
            // btnQLPXoa
            // 
            this.btnQLPXoa.Location = new System.Drawing.Point(29, 104);
            this.btnQLPXoa.Name = "btnQLPXoa";
            this.btnQLPXoa.Size = new System.Drawing.Size(80, 31);
            this.btnQLPXoa.TabIndex = 12;
            this.btnQLPXoa.Text = "Xóa";
            this.btnQLPXoa.UseVisualStyleBackColor = true;
            // 
            // lvQuanlyphong
            // 
            this.lvQuanlyphong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colQLPMasophong,
            this.colQLPLoaiphong,
            this.colQLPTinhtrang});
            this.lvQuanlyphong.Location = new System.Drawing.Point(12, 235);
            this.lvQuanlyphong.Name = "lvQuanlyphong";
            this.lvQuanlyphong.Size = new System.Drawing.Size(658, 205);
            this.lvQuanlyphong.TabIndex = 2;
            this.lvQuanlyphong.UseCompatibleStateImageBehavior = false;
            this.lvQuanlyphong.View = System.Windows.Forms.View.Details;
            // 
            // colQLPMasophong
            // 
            this.colQLPMasophong.Text = "Mã số phòng";
            this.colQLPMasophong.Width = 210;
            // 
            // colQLPLoaiphong
            // 
            this.colQLPLoaiphong.Text = "Loại phòng";
            this.colQLPLoaiphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colQLPLoaiphong.Width = 229;
            // 
            // colQLPTinhtrang
            // 
            this.colQLPTinhtrang.Text = "Tình trạng";
            this.colQLPTinhtrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colQLPTinhtrang.Width = 215;
            // 
            // frmQuanlyphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 452);
            this.Controls.Add(this.lvQuanlyphong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanlyphong";
            this.Text = "Quản Lý Phòng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQLPHuy;
        private System.Windows.Forms.Button btnQLPluu;
        private System.Windows.Forms.RadioButton radQLPDadat;
        private System.Windows.Forms.RadioButton radQLPTrong;
        private System.Windows.Forms.ComboBox cbQLPLoaiphong;
        private System.Windows.Forms.TextBox txtQLPMasophong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQLPThem;
        private System.Windows.Forms.Button btnQLPSua;
        private System.Windows.Forms.Button btnQLPXoa;
        private System.Windows.Forms.Button btnQLPThoat;
        private System.Windows.Forms.ListView lvQuanlyphong;
        private System.Windows.Forms.ColumnHeader colQLPMasophong;
        private System.Windows.Forms.ColumnHeader colQLPLoaiphong;
        private System.Windows.Forms.ColumnHeader colQLPTinhtrang;
    }
}