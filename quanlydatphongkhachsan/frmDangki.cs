using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace quanlydatphongkhachsan
{

    public partial class frmDangki : DevExpress.XtraEditors.XtraForm
    {

        private string TenDV = "";
        private string GioiTinh = "";
        private string TenPhong;
        public delegate void DangKy(bool a);
        public DangKy DaDangKy;

        public delegate void gettdulieu(string a);

        gettdulieu gtd;
        frmQuanLy frmql;

        public void copy(frmQuanLy frm)
        {
            frmql = frm;
        }
        public void dulieu()
        {

        }

        public frmDangki()
        {

            InitializeComponent();
        }



        public void getTenPhong(string tenphong)
        {
            TenPhong = tenphong;
        }

        private void btnDKthue_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + @"/Phong/" + TenPhong + ".txt";
            StreamWriter wr = new StreamWriter(filePath);
            string valueFile = "";
            for (int j = 0; j < lvDSDV.Items.Count; j++)
            {
                ListViewItem lvDV = lvDSDV.Items[j];

                valueFile += lvDV.SubItems[2].Text + "|";
            }
            valueFile += "\n";
            for (int i = 0; i < lvDSKH.Items.Count; i++)
            {
                ListViewItem lvItem = lvDSKH.Items[i];

                valueFile += lvItem.SubItems[0].Text + "|";
                valueFile += lvItem.SubItems[1].Text + "|";
                valueFile += lvItem.SubItems[2].Text + "|";
                valueFile += lvItem.SubItems[3].Text + "|";
                valueFile += lvItem.SubItems[4].Text + "|";
                valueFile += lvItem.SubItems[5].Text + "|";
                valueFile += lvItem.SubItems[6].Text + "|";


                wr.WriteLine(valueFile);
            }
            wr.Flush();
            wr.Close();
            DaDangKy(true);
            btnDKthue.Enabled = false;
            btnThanhToan.Enabled = true;
            frmDangki f = new frmDangki();



        }
        private void loadTTPhong()
        {

        }
        private void frmDangki_Load(object sender, EventArgs e)
        {

        }
        private void btnDKThem_Click(object sender, EventArgs e)
        {

        }

        private void btnDKXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemm in lvDSKH.Items)
            {
                if (itemm.Checked)
                {
                    itemm.Remove();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("" + TenPhong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem lvItem = new ListViewItem(txtDKHoten.Text);
            lvItem.SubItems.Add(txtDKDiachi.Text);
            lvItem.SubItems.Add(txtNgayThue.Text);
            lvItem.SubItems.Add(txtSoNgayThue.Text);
            lvItem.SubItems.Add(GioiTinh);
            lvItem.SubItems.Add(txtDKCMND.Text);
            lvItem.SubItems.Add(txtDKDienthoai.Text);
            lvDSKH.Items.Add(lvItem);
            txtDKHoten.Clear();
            txtDKDiachi.Clear();
            txtSoNgayThue.Clear();
            txtDKCMND.Clear();
            txtDKDienthoai.Clear();
        }

        private void radDKnam_CheckedChanged(object sender, EventArgs e)
        {
            GioiTinh = "Nam";
        }

        private void radDKnu_CheckedChanged(object sender, EventArgs e)
        {
            GioiTinh = "Nữ";
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lvDSDV.Items.Count; i++)
            {
                if (lvDSDV.Items[i].SubItems[0].Text == TenDV)
                    lvDSDV.Items[i].SubItems[2].Text = txtSoLuongDV.Text;
            }
        }

        private void lvDSDV_Click(object sender, EventArgs e)
        {
            TenDV = lvDSDV.SelectedItems[0].SubItems[0].Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHierThi_Click(object sender, EventArgs e)
        {
            grNhap.Visible = grTT.Visible = true;
            string filePath = Application.StartupPath + @"/Phong/" + TenPhong + ".txt";
            StreamReader file = new StreamReader(filePath);
            string valueDV = file.ReadLine();
            string[] arrDV = valueDV.Split('|');
            for (int i = 0; i < 3; i++)
            {
                lvDSDV.Items[i].SubItems[2].Text = arrDV[i];
            }
            while (!file.EndOfStream)
            {
                string valueLine = file.ReadLine();
                string[] value = valueLine.Split('|');

                ListViewItem lvItem = new ListViewItem(value[0]);
                lvItem.SubItems.Add(value[1]);
                lvItem.SubItems.Add(value[2]);
                lvItem.SubItems.Add(value[3]);
                lvItem.SubItems.Add(value[4]);
                lvItem.SubItems.Add(value[5]);
                lvItem.SubItems.Add(value[6]);

                lvDSKH.Items.Add(lvItem);
            }

            file.Close();
            if (lvDSKH.Items.Count >= 0) btnThanhToan.Enabled = true;
        } 

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            int ThanhTien = 0;
            int SoNgay = int.Parse(lvDSKH.Items[0].SubItems[3].Text);
            int DichVu1 = int.Parse(lvDSDV.Items[0].SubItems[1].Text);
            int SlDichVu1 = int.Parse(lvDSDV.Items[0].SubItems[2].Text);
            int DichVu2 = int.Parse(lvDSDV.Items[1].SubItems[1].Text);
            int SlDichVu2 = int.Parse(lvDSDV.Items[1].SubItems[2].Text);
            int DichVu3 = int.Parse(lvDSDV.Items[2].SubItems[1].Text);
            int SlDichVu3 = int.Parse(lvDSDV.Items[2].SubItems[2].Text);
            ThanhTien = 200000 * SoNgay + DichVu1*SlDichVu1 +DichVu2*SlDichVu2+DichVu3*SlDichVu3;
            if (MessageBox.Show("Tổng tiền: " + ThanhTien.ToString(),"Thanh toán",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                lvDSKH.Clear();
                string filePath = Application.StartupPath + @"/Phong/" + TenPhong + ".txt";
                StreamWriter wr = new StreamWriter(filePath);
                string valueFile = "";
                for (int j = 0; j < lvDSDV.Items.Count; j++)
                {
                    ListViewItem lvDV = lvDSDV.Items[j];

                    valueFile += lvDV.SubItems[2].Text + "|";
                }
                valueFile += "\n";
                for (int i = 0; i < lvDSKH.Items.Count; i++)
                {
                    ListViewItem lvItem = lvDSKH.Items[i];

                    valueFile += lvItem.SubItems[0].Text + "|";
                    valueFile += lvItem.SubItems[1].Text + "|";
                    valueFile += lvItem.SubItems[2].Text + "|";
                    valueFile += lvItem.SubItems[3].Text + "|";
                    valueFile += lvItem.SubItems[4].Text + "|";
                    valueFile += lvItem.SubItems[5].Text + "|";
                    valueFile += lvItem.SubItems[6].Text + "|";


                    wr.WriteLine(valueFile);
                }
                wr.Flush();
                wr.Close();
                DaDangKy(false);
                btnThanhToan.Enabled = false;
                btnDKthue.Enabled = true;
                this.Close();


            }
        }

        private void lvDSKH_Click(object sender, EventArgs e)
        {
            ListViewItem lvItem = lvDSKH.SelectedItems[0];
          
             txtDKHoten.Text = lvItem.SubItems[0].Text;
            txtDKDiachi.Text = lvItem.SubItems[1].Text;
            txtNgayThue.Text = lvItem.SubItems[2].Text;
            txtSoNgayThue.Text = lvItem.SubItems[3].Text;
            if (lvItem.SubItems[4].Text == "Nam")
            {
                radDKnam.Checked = true;
            }
            else radDKnu.Checked = true;
            txtDKCMND.Text = lvItem.SubItems[5].Text;
            txtDKDienthoai.Text = lvItem.SubItems[6].Text;
            

        }

        private void btnDKSua_Click(object sender, EventArgs e)
        {
            
            ListViewItem lvItem = new ListViewItem(txtDKHoten.Text);
            lvItem.SubItems.Add(txtDKDiachi.Text);
            lvItem.SubItems.Add(txtNgayThue.Text);
            lvItem.SubItems.Add(txtSoNgayThue.Text);
            lvItem.SubItems.Add(GioiTinh);
            lvItem.SubItems.Add(txtDKCMND.Text);
            lvItem.SubItems.Add(txtDKDienthoai.Text);

            for (int i=0; i < lvDSKH.Items.Count; i++)
            {
                if (txtDKHoten.Text == lvDSKH.Items[i].SubItems[0].Text)
                {
                    lvDSKH.Items[i].SubItems[0].Text = lvItem.SubItems[0].Text;
                    lvDSKH.Items[i].SubItems[1].Text = lvItem.SubItems[1].Text;
                    lvDSKH.Items[i].SubItems[2].Text = lvItem.SubItems[2].Text;
                    lvDSKH.Items[i].SubItems[3].Text = lvItem.SubItems[3].Text;
                    lvDSKH.Items[i].SubItems[4].Text = lvItem.SubItems[4].Text;
                    lvDSKH.Items[i].SubItems[5].Text = lvItem.SubItems[5].Text;
                    lvDSKH.Items[i].SubItems[6].Text = lvItem.SubItems[6].Text;
                }
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvDSKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDSKH.CheckBoxes = true;
        }
    }
}
