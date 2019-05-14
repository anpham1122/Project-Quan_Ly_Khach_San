using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydatphongkhachsan
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?","Thông Báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        
        private void btnDangnhap_Click(object sender, EventArgs e)
        {

            string username = txtTaikhoan.Text;
            string password = txtMatkhau.Text;
            if (username == "admin" && password == "123")
            {
                frmQuanLy f = new frmQuanLy();
                this.Hide();
                f.ShowDialog();
            }
            else if (username == "")
            {
                MessageBox.Show("bạn chưa nhập tài khoản!");
                txtTaikhoan.Focus();
            }
            else if (password == "" && username == "admin")
            {
                MessageBox.Show("bạn chưa nhập mật khẩu!");
                txtMatkhau.Focus();
            }
            else if (password != "123")
            {
                MessageBox.Show("bạn đã nhập sai mật khẩu!");
                txtMatkhau.Clear();
                txtMatkhau.Focus();
            }
            else if (username != "admin")
            {
                MessageBox.Show("bạn đã nhập sai tài khoản!");
                txtTaikhoan.Clear();
                txtMatkhau.Clear();
                txtTaikhoan.Focus();
            }


        }

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
