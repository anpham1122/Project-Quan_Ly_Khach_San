using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quanlydatphongkhachsan
{
    public partial class frmQuanLy : DevExpress.XtraEditors.XtraForm
    {
        public delegate void GetTenPhong(string a);

        GetTenPhong gttp;

        private string TenPhong = "";
        private Button Phong = new Button();
        
        frmDangki f;
        frmLogin k;
        public frmQuanLy()
        {
            
            InitializeComponent();
            
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            k = new frmLogin();
            this.Hide();
            k.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            
        }
        public void LayTenPhong(string a)
        {
            a = btnPhong101.Text;
        }
        
        private void btnPhong101_Click(object sender, EventArgs e)
        {


                f = new frmDangki();
                f.Show();
                gttp = new GetTenPhong(f.getTenPhong);
                gttp(btnPhong101.Text);

                TenPhong = btnPhong101.Text;
                Phong = btnPhong101;
                f.DaDangKy = DangKyPhong;


        }

        private void frmQuanLy_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void DangKyPhong(bool a)
        {
            if (a == true)
                Phong.BackColor = Color.Green;
            else Phong.BackColor = Color.DeepPink;
        }

        private void btnPhong102_Click(object sender, EventArgs e)
        {
            f = new frmDangki();
            f.Show();
            gttp = new GetTenPhong(f.getTenPhong);
            gttp(btnPhong102.Text);

            TenPhong = btnPhong102.Text;
            Phong = btnPhong102;
            f.DaDangKy = DangKyPhong;
        }

        private void btnPhong103_Click(object sender, EventArgs e)
        {
            f = new frmDangki();
            f.Show();
            gttp = new GetTenPhong(f.getTenPhong);
            gttp(btnPhong103.Text);

            TenPhong = btnPhong103.Text;
            Phong = btnPhong103;
            f.DaDangKy = DangKyPhong;
        }

        private void btnPhong104_Click(object sender, EventArgs e)
        {
            f = new frmDangki();
            f.Show();
            gttp = new GetTenPhong(f.getTenPhong);
            gttp(btnPhong104.Text);

            TenPhong = btnPhong104.Text;
            Phong = btnPhong104;
            f.DaDangKy = DangKyPhong;
        }

        private void btnPhong105_Click(object sender, EventArgs e)
        {
            f = new frmDangki();
            f.Show();
            gttp = new GetTenPhong(f.getTenPhong);
            gttp(btnPhong105.Text);

            TenPhong = btnPhong105.Text;
            Phong = btnPhong105;
            f.DaDangKy = DangKyPhong;
        }
    }
}
