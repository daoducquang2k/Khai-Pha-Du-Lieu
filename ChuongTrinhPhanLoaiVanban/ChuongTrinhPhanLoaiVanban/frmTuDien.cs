using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ChuongTrinhPhanLoaiVanban
{
    public partial class frmTuDien : Form
    {

        private SortedDictionary<string, int> myDic = new SortedDictionary<string, int>();
        public frmTuDien()
        {
            InitializeComponent();
        }
       

        private void frmTuDien_Load(object sender, EventArgs e)
        {
            cboNapTuDien.Items.Add("Từ Điển gốc");
            cboNapTuDien.Items.Add("Từ Điển Thể Thao");
            cboNapTuDien.Items.Add("Từ Điển Kinh Tế");
            cboNapTuDien.Items.Add("Từ Điển Pháp Luật");
            cboNapTuDien.SelectedIndex = 0;
         
        }


        private void btnNap_Click(object sender, EventArgs e)
        {
           
            
            int index = cboNapTuDien.SelectedIndex;
            String path = "";
            if (index == 0)
            {
                path = XuLyDuLieu.NEW_DIC_NAME;
            }

            else if (index == 1)
            {
                path = XuLyDuLieu.TT_DIC_NAME;
            }
            else if (index == 2)
            {
                path = XuLyDuLieu.KT_DIC_NAME;
            }
            else if (index == 3)
            {
                path = XuLyDuLieu.PL_DIC_NAME;
            }
          
            //doc tu dien tho
            if (!File.Exists(path))
            {
                MessageBox.Show("Thiếu tập tin từ điển!", path, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (StreamReader sr = File.OpenText(path))
            {
                String input;

                while ((input = sr.ReadLine()) != null)
                {
                    if (!myDic.ContainsKey(input))
                    {
                        myDic.Add(input, 0);
                    }
                }
                sr.Close();
            }
            this.lstHienThi.Items.Clear();
            foreach (var key in myDic.Keys.ToList())
            {
                if (key.Length > 0) this.lstHienThi.Items.Add(key);
            }
           
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
