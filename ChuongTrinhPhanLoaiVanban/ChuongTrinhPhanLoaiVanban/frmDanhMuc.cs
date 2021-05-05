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
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Thể Thao");
            listBox1.Items.Add("Kinh Tế");
            listBox1.Items.Add("Pháp Luật");
        }
    }
}
