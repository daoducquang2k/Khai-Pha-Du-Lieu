using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChuongTrinhPhanLoaiVanban
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void addMessage(String m)
        {
            txtPhanLoai.Text += m;
            txtPhanLoai.ScrollToCaret();
        }
        private void btnDuLieu_Click(object sender, EventArgs e)
        {
            frmDuLieu a = new frmDuLieu(this);
            a.Show();
            btnPhanloai.Enabled = true;
        }

        private void tblTuDien_Click(object sender, EventArgs e)
        {
            frmTuDien a = new frmTuDien();
            a.Show();
            btnDuLieu.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPhanloai_Click(object sender, EventArgs e)
        {
            frmPhanLoai a = new frmPhanLoai(this);
            a.Show();
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            frmGioiThieu fm = new frmGioiThieu();
            fm.Show();
        }

        private void btnChuyenDe_Click(object sender, EventArgs e)
        {
            frmDanhMuc danhmuc = new frmDanhMuc();
            danhmuc.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
