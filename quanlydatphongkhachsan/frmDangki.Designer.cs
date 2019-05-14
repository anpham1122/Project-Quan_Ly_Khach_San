namespace quanlydatphongkhachsan
{
    partial class frmDangki
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bia",
            "25000",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nước ngọt",
            "18000",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Gà nướng",
            "50000",
            "0"}, -1);
            this.grNhap = new System.Windows.Forms.Panel();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grDV = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongDV = new System.Windows.Forms.TextBox();
            this.grTTKH = new System.Windows.Forms.GroupBox();
            this.txtSoNgayThue = new System.Windows.Forms.TextBox();
            this.txtDKCMND = new System.Windows.Forms.TextBox();
            this.txtDKDiachi = new System.Windows.Forms.TextBox();
            this.txtDKDienthoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgayThue = new System.Windows.Forms.DateTimePicker();
            this.txtDKHoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radDKnu = new System.Windows.Forms.RadioButton();
            this.radDKnam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDKXoa = new System.Windows.Forms.Button();
            this.btnDKSua = new System.Windows.Forms.Button();
            this.btnDKthue = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lvDSKH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDSDV = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHierThi = new System.Windows.Forms.Button();
            this.grTT = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grNhap.SuspendLayout();
            this.grDV.SuspendLayout();
            this.grTTKH.SuspendLayout();
            this.grTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // grNhap
            // 
            this.grNhap.Controls.Add(this.btnThemDV);
            this.grNhap.Controls.Add(this.btnThem);
            this.grNhap.Controls.Add(this.grDV);
            this.grNhap.Controls.Add(this.grTTKH);
            this.grNhap.Location = new System.Drawing.Point(4, 62);
            this.grNhap.Name = "grNhap";
            this.grNhap.Size = new System.Drawing.Size(718, 385);
            this.grNhap.TabIndex = 1;
            this.grNhap.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemDV.Location = new System.Drawing.Point(474, 339);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(121, 37);
            this.btnThemDV.TabIndex = 24;
            this.btnThemDV.Text = "Thêm dịch vụ";
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem.Location = new System.Drawing.Point(23, 337);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 37);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm khách hàng";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grDV
            // 
            this.grDV.Controls.Add(this.label1);
            this.grDV.Controls.Add(this.txtSoLuongDV);
            this.grDV.Location = new System.Drawing.Point(474, 84);
            this.grDV.Name = "grDV";
            this.grDV.Size = new System.Drawing.Size(227, 238);
            this.grDV.TabIndex = 23;
            this.grDV.TabStop = false;
            this.grDV.Text = "Dịch vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Số lượng";
            // 
            // txtSoLuongDV
            // 
            this.txtSoLuongDV.Location = new System.Drawing.Point(19, 98);
            this.txtSoLuongDV.Name = "txtSoLuongDV";
            this.txtSoLuongDV.Size = new System.Drawing.Size(160, 23);
            this.txtSoLuongDV.TabIndex = 21;
            // 
            // grTTKH
            // 
            this.grTTKH.Controls.Add(this.textBox1);
            this.grTTKH.Controls.Add(this.label9);
            this.grTTKH.Controls.Add(this.txtSoNgayThue);
            this.grTTKH.Controls.Add(this.txtDKCMND);
            this.grTTKH.Controls.Add(this.txtDKDiachi);
            this.grTTKH.Controls.Add(this.txtDKDienthoai);
            this.grTTKH.Controls.Add(this.label3);
            this.grTTKH.Controls.Add(this.txtNgayThue);
            this.grTTKH.Controls.Add(this.txtDKHoten);
            this.grTTKH.Controls.Add(this.label2);
            this.grTTKH.Controls.Add(this.radDKnu);
            this.grTTKH.Controls.Add(this.radDKnam);
            this.grTTKH.Controls.Add(this.label8);
            this.grTTKH.Controls.Add(this.label7);
            this.grTTKH.Controls.Add(this.label6);
            this.grTTKH.Controls.Add(this.label5);
            this.grTTKH.Controls.Add(this.label4);
            this.grTTKH.Location = new System.Drawing.Point(23, 19);
            this.grTTKH.Name = "grTTKH";
            this.grTTKH.Size = new System.Drawing.Size(432, 303);
            this.grTTKH.TabIndex = 8;
            this.grTTKH.TabStop = false;
            this.grTTKH.Text = "Thông tin khách hàng";
            // 
            // txtSoNgayThue
            // 
            this.txtSoNgayThue.Location = new System.Drawing.Point(124, 139);
            this.txtSoNgayThue.Name = "txtSoNgayThue";
            this.txtSoNgayThue.Size = new System.Drawing.Size(176, 23);
            this.txtSoNgayThue.TabIndex = 20;
            // 
            // txtDKCMND
            // 
            this.txtDKCMND.Location = new System.Drawing.Point(123, 203);
            this.txtDKCMND.Name = "txtDKCMND";
            this.txtDKCMND.Size = new System.Drawing.Size(167, 23);
            this.txtDKCMND.TabIndex = 19;
            // 
            // txtDKDiachi
            // 
            this.txtDKDiachi.Location = new System.Drawing.Point(124, 72);
            this.txtDKDiachi.Name = "txtDKDiachi";
            this.txtDKDiachi.Size = new System.Drawing.Size(268, 23);
            this.txtDKDiachi.TabIndex = 18;
            // 
            // txtDKDienthoai
            // 
            this.txtDKDienthoai.Location = new System.Drawing.Point(123, 241);
            this.txtDKDienthoai.Name = "txtDKDienthoai";
            this.txtDKDienthoai.Size = new System.Drawing.Size(167, 23);
            this.txtDKDienthoai.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số ngày thuê:";
            // 
            // txtNgayThue
            // 
            this.txtNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayThue.Location = new System.Drawing.Point(124, 107);
            this.txtNgayThue.Name = "txtNgayThue";
            this.txtNgayThue.Size = new System.Drawing.Size(176, 23);
            this.txtNgayThue.TabIndex = 10;
            // 
            // txtDKHoten
            // 
            this.txtDKHoten.Location = new System.Drawing.Point(123, 36);
            this.txtDKHoten.Name = "txtDKHoten";
            this.txtDKHoten.Size = new System.Drawing.Size(269, 23);
            this.txtDKHoten.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày thuê";
            // 
            // radDKnu
            // 
            this.radDKnu.AutoSize = true;
            this.radDKnu.Location = new System.Drawing.Point(258, 177);
            this.radDKnu.Name = "radDKnu";
            this.radDKnu.Size = new System.Drawing.Size(47, 21);
            this.radDKnu.TabIndex = 14;
            this.radDKnu.TabStop = true;
            this.radDKnu.Text = "Nữ";
            this.radDKnu.UseVisualStyleBackColor = true;
            this.radDKnu.CheckedChanged += new System.EventHandler(this.radDKnu_CheckedChanged);
            // 
            // radDKnam
            // 
            this.radDKnam.AutoSize = true;
            this.radDKnam.Location = new System.Drawing.Point(137, 175);
            this.radDKnam.Name = "radDKnam";
            this.radDKnam.Size = new System.Drawing.Size(61, 21);
            this.radDKnam.TabIndex = 13;
            this.radDKnam.TabStop = true;
            this.radDKnam.Text = "Nam ";
            this.radDKnam.UseVisualStyleBackColor = true;
            this.radDKnam.CheckedChanged += new System.EventHandler(this.radDKnam_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Giới tính :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Điện thoại :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "CMND :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Họ tên :";
            // 
            // btnDKXoa
            // 
            this.btnDKXoa.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDKXoa.Location = new System.Drawing.Point(288, 193);
            this.btnDKXoa.Name = "btnDKXoa";
            this.btnDKXoa.Size = new System.Drawing.Size(124, 34);
            this.btnDKXoa.TabIndex = 22;
            this.btnDKXoa.Text = "Xóa";
            this.btnDKXoa.UseVisualStyleBackColor = false;
            this.btnDKXoa.Click += new System.EventHandler(this.btnDKXoa_Click);
            // 
            // btnDKSua
            // 
            this.btnDKSua.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDKSua.Location = new System.Drawing.Point(164, 193);
            this.btnDKSua.Name = "btnDKSua";
            this.btnDKSua.Size = new System.Drawing.Size(119, 34);
            this.btnDKSua.TabIndex = 21;
            this.btnDKSua.Text = "Sửa";
            this.btnDKSua.UseVisualStyleBackColor = false;
            this.btnDKSua.Click += new System.EventHandler(this.btnDKSua_Click);
            // 
            // btnDKthue
            // 
            this.btnDKthue.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDKthue.Location = new System.Drawing.Point(48, 193);
            this.btnDKthue.Name = "btnDKthue";
            this.btnDKthue.Size = new System.Drawing.Size(113, 34);
            this.btnDKthue.TabIndex = 3;
            this.btnDKthue.Text = "Đăng Kí Thuê";
            this.btnDKthue.UseVisualStyleBackColor = false;
            this.btnDKthue.Click += new System.EventHandler(this.btnDKthue_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThoat.Location = new System.Drawing.Point(417, 193);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 34);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lvDSKH
            // 
            this.lvDSKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvDSKH.FullRowSelect = true;
            this.lvDSKH.Location = new System.Drawing.Point(8, 14);
            this.lvDSKH.Name = "lvDSKH";
            this.lvDSKH.Size = new System.Drawing.Size(456, 165);
            this.lvDSKH.TabIndex = 5;
            this.lvDSKH.UseCompatibleStateImageBehavior = false;
            this.lvDSKH.View = System.Windows.Forms.View.Details;
            this.lvDSKH.SelectedIndexChanged += new System.EventHandler(this.lvDSKH_SelectedIndexChanged);
            this.lvDSKH.Click += new System.EventHandler(this.lvDSKH_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Địa chỉ";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày thuê";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số ngày thuê";
            this.columnHeader4.Width = 48;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giới tính";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CMND";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Điện thoại";
            // 
            // lvDSDV
            // 
            this.lvDSDV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader8});
            this.lvDSDV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvDSDV.Location = new System.Drawing.Point(468, 14);
            this.lvDSDV.Name = "lvDSDV";
            this.lvDSDV.Size = new System.Drawing.Size(259, 165);
            this.lvDSDV.TabIndex = 6;
            this.lvDSDV.UseCompatibleStateImageBehavior = false;
            this.lvDSDV.View = System.Windows.Forms.View.Details;
            this.lvDSDV.Click += new System.EventHandler(this.lvDSDV_Click);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Tên dịch vụ";
            this.columnHeader15.Width = 119;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Giá";
            this.columnHeader16.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số lượng";
            // 
            // btnHierThi
            // 
            this.btnHierThi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHierThi.Location = new System.Drawing.Point(4, 5);
            this.btnHierThi.Name = "btnHierThi";
            this.btnHierThi.Size = new System.Drawing.Size(718, 51);
            this.btnHierThi.TabIndex = 25;
            this.btnHierThi.Text = "HIển thị";
            this.btnHierThi.UseVisualStyleBackColor = false;
            this.btnHierThi.Click += new System.EventHandler(this.btnHierThi_Click);
            // 
            // grTT
            // 
            this.grTT.Controls.Add(this.btnThanhToan);
            this.grTT.Controls.Add(this.lvDSKH);
            this.grTT.Controls.Add(this.lvDSDV);
            this.grTT.Controls.Add(this.btnDKthue);
            this.grTT.Controls.Add(this.btnDKXoa);
            this.grTT.Controls.Add(this.btnDKSua);
            this.grTT.Controls.Add(this.btnThoat);
            this.grTT.Location = new System.Drawing.Point(4, 453);
            this.grTT.Name = "grTT";
            this.grTT.Size = new System.Drawing.Size(737, 243);
            this.grTT.TabIndex = 23;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Location = new System.Drawing.Point(540, 193);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(113, 34);
            this.btnThanhToan.TabIndex = 23;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(124, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 23);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "200000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Giá phòng :";
            // 
            // frmDangki
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 701);
            this.Controls.Add(this.btnHierThi);
            this.Controls.Add(this.grTT);
            this.Controls.Add(this.grNhap);
            this.Name = "frmDangki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Kí";
            this.Load += new System.EventHandler(this.frmDangki_Load);
            this.grNhap.ResumeLayout(false);
            this.grDV.ResumeLayout(false);
            this.grDV.PerformLayout();
            this.grTTKH.ResumeLayout(false);
            this.grTTKH.PerformLayout();
            this.grTT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel grNhap;
        private System.Windows.Forms.GroupBox grTTKH;
        private System.Windows.Forms.Button btnDKXoa;
        private System.Windows.Forms.Button btnDKSua;
        private System.Windows.Forms.TextBox txtDKCMND;
        private System.Windows.Forms.TextBox txtDKDiachi;
        private System.Windows.Forms.TextBox txtDKDienthoai;
        private System.Windows.Forms.TextBox txtDKHoten;
        private System.Windows.Forms.RadioButton radDKnu;
        private System.Windows.Forms.RadioButton radDKnam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDKthue;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grDV;
        private System.Windows.Forms.ListView lvDSKH;
        private System.Windows.Forms.DateTimePicker txtNgayThue;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lvDSDV;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoNgayThue;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuongDV;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnHierThi;
        private System.Windows.Forms.Panel grTT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}