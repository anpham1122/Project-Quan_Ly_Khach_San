namespace quanlydatphongkhachsan
{
    partial class frmThanhtoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colTendichvu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaysudung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTTXem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnTTThanhtoan = new System.Windows.Forms.Button();
            this.btnTTLuu = new System.Windows.Forms.Button();
            this.btnTTHoadon = new System.Windows.Forms.Button();
            this.btnTTThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTTThoat);
            this.panel1.Controls.Add(this.btnTTHoadon);
            this.panel1.Controls.Add(this.btnTTLuu);
            this.panel1.Controls.Add(this.btnTTThanhtoan);
            this.panel1.Controls.Add(this.btnTTXem);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 599);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Hóa Đơn";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTendichvu,
            this.colNgaysudung,
            this.colSoluong,
            this.colGia});
            this.listView1.Location = new System.Drawing.Point(9, 368);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(596, 168);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colTendichvu
            // 
            this.colTendichvu.Text = "Tên dịch vụ";
            this.colTendichvu.Width = 223;
            // 
            // colNgaysudung
            // 
            this.colNgaysudung.Text = "Ngày sử dụng";
            this.colNgaysudung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNgaysudung.Width = 174;
            // 
            // colSoluong
            // 
            this.colSoluong.Text = "Số lượng";
            this.colSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoluong.Width = 95;
            // 
            // colGia
            // 
            this.colGia.Text = "Giá";
            this.colGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGia.Width = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên thanh toán :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn Mã Phòng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã số phòng thuê :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày thuê :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày trả :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phí thuê phòng :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Phí sử dụng dịch vụ :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tổng cộng :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // btnTTXem
            // 
            this.btnTTXem.Location = new System.Drawing.Point(432, 14);
            this.btnTTXem.Name = "btnTTXem";
            this.btnTTXem.Size = new System.Drawing.Size(75, 37);
            this.btnTTXem.TabIndex = 4;
            this.btnTTXem.Text = "Xem";
            this.btnTTXem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(257, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(264, 22);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(258, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(264, 22);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(257, 180);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(264, 22);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(258, 220);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(264, 22);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(257, 253);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(264, 22);
            this.textBox7.TabIndex = 15;
            // 
            // btnTTThanhtoan
            // 
            this.btnTTThanhtoan.Location = new System.Drawing.Point(35, 553);
            this.btnTTThanhtoan.Name = "btnTTThanhtoan";
            this.btnTTThanhtoan.Size = new System.Drawing.Size(120, 35);
            this.btnTTThanhtoan.TabIndex = 5;
            this.btnTTThanhtoan.Text = "Thanh Toán";
            this.btnTTThanhtoan.UseVisualStyleBackColor = true;
            // 
            // btnTTLuu
            // 
            this.btnTTLuu.Location = new System.Drawing.Point(189, 553);
            this.btnTTLuu.Name = "btnTTLuu";
            this.btnTTLuu.Size = new System.Drawing.Size(65, 35);
            this.btnTTLuu.TabIndex = 6;
            this.btnTTLuu.Text = "Lưu";
            this.btnTTLuu.UseVisualStyleBackColor = true;
            // 
            // btnTTHoadon
            // 
            this.btnTTHoadon.Location = new System.Drawing.Point(285, 553);
            this.btnTTHoadon.Name = "btnTTHoadon";
            this.btnTTHoadon.Size = new System.Drawing.Size(103, 35);
            this.btnTTHoadon.TabIndex = 7;
            this.btnTTHoadon.Text = "Hóa Đơn";
            this.btnTTHoadon.UseVisualStyleBackColor = true;
            // 
            // btnTTThoat
            // 
            this.btnTTThoat.Location = new System.Drawing.Point(474, 553);
            this.btnTTThoat.Name = "btnTTThoat";
            this.btnTTThoat.Size = new System.Drawing.Size(88, 35);
            this.btnTTThoat.TabIndex = 8;
            this.btnTTThoat.Text = "Thoát";
            this.btnTTThoat.UseVisualStyleBackColor = true;
            // 
            // frmThanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 608);
            this.Controls.Add(this.panel1);
            this.Name = "frmThanhtoan";
            this.Text = "Thanh Toán";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTTThoat;
        private System.Windows.Forms.Button btnTTHoadon;
        private System.Windows.Forms.Button btnTTLuu;
        private System.Windows.Forms.Button btnTTThanhtoan;
        private System.Windows.Forms.Button btnTTXem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colTendichvu;
        private System.Windows.Forms.ColumnHeader colNgaysudung;
        private System.Windows.Forms.ColumnHeader colSoluong;
        private System.Windows.Forms.ColumnHeader colGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}