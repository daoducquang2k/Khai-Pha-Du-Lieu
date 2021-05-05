using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ChuongTrinhPhanLoaiVanban
{
    public partial class frmDuLieu : Form
    {
        
        private Form1 p;
        private String[] listFile = null;

        private Dictionary<string, int> myRawDic = new Dictionary<string, int>();


        private SortedDictionary<string, int> myDic = new SortedDictionary<string, int>();


        private SortedDictionary<string, int> myDicInfor = new SortedDictionary<string, int>();
        public frmDuLieu( Form1 _p)
        {
            InitializeComponent();
            p = _p;
        }
        //Data kn = new Data();
        //string[] fineNames, finePaths;
        public void LoadDuLieu()
        {

            //string sql = "Select fldID,fldTuDien,fldPhienDich from TuDien";
            ////dvgDonVi.DataSource = kn.taobang(sql);

            //dvgDuLieu.DataSource = kn.taobang(sql);
            //DataTable dtb = new DataTable();
            //dtb = kn.taobang(sql);
            //lstDuLieu.DataSource = dtb;
            //lstPhanLoai.DataSource = dtb;
            //lstDuLieu.DisplayMember = "fldTuDien";
            ////lstDuLieu.ValueMember = "fldID";
            //lstPhanLoai.DisplayMember = "fldPhienDich";
        }

        private void btnNapDuLieu_Click(object sender, EventArgs e)
        {
            if (XuLyDuLieu.RAW_DATA_PATH.Length <= 0) return;
            if (Directory.Exists(XuLyDuLieu.RAW_DATA_PATH) != true)
            {
                MessageBox.Show("Đường dẫn không đúng!");
                return;
            }
            DirectoryInfo di = new DirectoryInfo(XuLyDuLieu.RAW_DATA_PATH);
            FileInfo[] rgFiles = di.GetFiles("*.txt");
            txtketQuaDuLieu.Text += "Tìm thấy " + rgFiles.Length + " văn bản!\r\n";

            String name = "";
            foreach (FileInfo fi in rgFiles)
            {
               txtketQuaDuLieu.Text += "\r\n" + fi.Name;
                name += XuLyDuLieu.RAW_DATA_PATH + "\\" + fi.Name + "|";

            }
            name = name.Substring(0, name.Length - 1);
            listFile = name.Split('|');
           txtketQuaDuLieu.ScrollToCaret();
           btnPhanTich.Enabled = true;
        }

        private void btnPhanTich_Click(object sender, EventArgs e)
        {
            
            if (listFile == null)
            {
                MessageBox.Show("Chưa nạp dữ liệu!");
                return;
            }
            
            SortedDictionary<string, int>[] arrAllFile = new SortedDictionary<string, int>[listFile.Length];
            for (int k = 0; k < listFile.Length; k++)
            {
                if (arrAllFile[k] == null) arrAllFile[k] = new SortedDictionary<string, int>();
                String sdata = System.IO.File.ReadAllText(@listFile[k]);

                if (sdata.Length <= 0)
                {
                    MessageBox.Show("Lỗi đọc file: " + listFile[k]);
                    return;
                }

                int pos = 0;
                String world;  

                
                sdata = sdata.Trim();
                sdata = sdata.Replace(',', '.');
                sdata = sdata.Replace('"', '.');
                sdata = sdata.Replace(':', '.');
                sdata = sdata.Replace('(', '.');
                sdata = sdata.Replace(')', '.');
                sdata = sdata.Replace("\r\n", ".");
                while (sdata.Contains("..")) sdata = sdata.Replace("..", ".");

                
                sdata = sdata.ToLower();

               
                String[] sArr = sdata.Split('.');
               
                for (int i = 0; i < sArr.Length; i++)
                {
                    sArr[i] = sArr[i].Trim();

                    if (sArr[i].Length > 0)
                    {
                        
                        for (int g = 0; g < 10; g++)
                        {
                            pos = sArr[i].IndexOf(g + "");
                            while (pos >= 0)
                            {
                                sArr[i] = sArr[i].Substring(0, pos) + sArr[i].Substring(pos + 1);
                                pos = sArr[i].IndexOf(g + "");
                            }
                        }

                        for (int j = 0; j < XuLyDuLieu.stopWordArr.Length; j++)
                        {
                            pos = sArr[i].IndexOf(XuLyDuLieu.stopWordArr[j]);
                            while (pos >= 0)
                            {
                                sArr[i] = sArr[i].Substring(0, pos) + " " + sArr[i].Substring(pos + XuLyDuLieu.stopWordArr[j].Length);
                               
                                pos = sArr[i].IndexOf(XuLyDuLieu.stopWordArr[j]);
                            }
                        }


                        for (int j = 0; j < XuLyDuLieu.noMeaningArr.Length; j++)
                        {
                            pos = sArr[i].IndexOf(XuLyDuLieu.noMeaningArr[j]);
                            while (pos >= 0)
                            {
                                sArr[i] = sArr[i].Substring(0, pos) + " " + sArr[i].Substring(pos + XuLyDuLieu.noMeaningArr[j].Length);
                              
                                pos = sArr[i].IndexOf(XuLyDuLieu.noMeaningArr[j]);
                            }
                        }
                        
                        world = sArr[i];
                        
                        String w = world;

                        while (world.Length > 0)
                        {
                            while (w.Length > XuLyDuLieu.maxWordLength) w = cutLastWord(w);

                            if (myRawDic.ContainsKey(w))
                            {
                                //neu tu do trong tu dien, luu vao tu dien trung gian
                                if (!myDic.ContainsKey(w))
                                {
                                    myDic.Add(w, 1);
                                    arrAllFile[k].Add(w, 1);
                                }
                                else
                                {
                                    myDic[w]++;

                                    if (arrAllFile[k].ContainsKey(w))
                                    {
                                        arrAllFile[k][w]++;
                                    }
                                    else
                                    {
                                        arrAllFile[k].Add(w, 1);
                                    }

                                }
                                world = world.Substring(w.Length).Trim();
                                w = world;
                            }
                            else
                            {
                                w = cutLastWord(w).Trim();

                               
                                if (w.Length <= 0)
                                {
                                    String[] srrTemp = world.Split(' ');
                                    if (myRawDic.ContainsKey(srrTemp[0]))
                                    {
                                       
                                        if (!myDic.ContainsKey(w))
                                        {
                                            myDic.Add(srrTemp[0], 1);
                                            arrAllFile[k].Add(srrTemp[0], 1);
                                        }
                                        else
                                        {
                                            myDic[srrTemp[0]]++;
                                            if (arrAllFile[k].ContainsKey(srrTemp[0]))
                                            {
                                                arrAllFile[k][srrTemp[0]]++;
                                            }
                                            else
                                            {
                                                arrAllFile[k].Add(srrTemp[0], 1);
                                            }
                                        }
                                        world = world.Substring(srrTemp[0].Length).Trim();
                                        w = world;
                                    }
                                    else
                                    {
                                       
                                        world = world.Substring(srrTemp[0].Length).Trim();
                                        w = world;
                                    }
                                }
                            }
                        }
                    }
                    
                }
            }

            
            SortedDictionary<string, int> _myDic = new SortedDictionary<string, int>();
            foreach (var kvp in myDic)
            {
               
                if (kvp.Value < 3 || kvp.Key.Trim().Length <= 0) _myDic.Add(kvp.Key, 1);
            }
            foreach (var kvp in _myDic)
            {
                //xoa cac tu co tan so be hon 3
                myDic.Remove(kvp.Key);
            }
            txtketQuaDuLieu.Text += "\r\nTừ điển rút gọn còn: " + myDic.Count + " từ!\r\n";

            //set index cho tu dien
            int c = 1;
            foreach (var key in myDic.Keys.ToList())
            {
                myDicInfor.Add(key, 0);
                myDic[key] = c;
                c++;
            }

                     
            for (int i = 0; i < arrAllFile.Length; i++)
            {
                _myDic.Clear();
                foreach (var kvp in arrAllFile[i])
                {
                    if (!myDic.ContainsKey(kvp.Key))
                        _myDic.Add(kvp.Key, 1);
                }
                foreach (var kvp in _myDic)
                {
                    arrAllFile[i].Remove(kvp.Key);
                }
            }

            //tính số lần xuất hiện của từ trong tập huấn luyện -> luu vao myDicInfor
            for (int i = 0; i < arrAllFile.Length; i++)
            {
                foreach (var kvp in arrAllFile[i])
                {
                    myDicInfor[kvp.Key]++;
                }
            }


            using (StreamWriter file = new StreamWriter(File.Open(XuLyDuLieu.NEW_DIC_NAME , FileMode.Create), Encoding.Unicode))
            //using (StreamWriter file = new StreamWriter(lstPhanLoai.Text))
            {
                foreach (var kvp in myDic)
                {
                    file.Write(kvp.Key + "\r\n");
                    //writer.Write(kvp.Value);
                }
                file.Flush();
                file.Close();
            }
            txtketQuaDuLieu.Text += "Đã lưu từ điển thu gọn: " + XuLyDuLieu.NEW_DIC_NAME + "\r\n";

            exportData(arrAllFile, XuLyDuLieu.TYPE_THETHAO);
            exportData(arrAllFile, XuLyDuLieu.TYPE_KINHTE);
            exportData(arrAllFile, XuLyDuLieu.TYPE_PHAPLUAT);

            trainSVM(XuLyDuLieu.TYPE_THETHAO);
            trainSVM(XuLyDuLieu.TYPE_KINHTE);
            trainSVM(XuLyDuLieu.TYPE_PHAPLUAT);

            txtketQuaDuLieu.ScrollToCaret();
            MessageBox.Show("Đã nạp xong dữ liệu xong!");
        }
        public void exportData(SortedDictionary<string, int>[] arrAllFile, int t)
        {
            int type = 0;
            
            using (StreamWriter file1 = new StreamWriter(File.Open(XuLyDuLieu.SVM_DATA_PATH + "\\data" + t + ".dat", FileMode.Create), Encoding.ASCII))
            {
                
                for (int i = 0; i < arrAllFile.Length; i++)
                {
                   
                    String ss = listFile[i];
                    //int pos = 0;
                    for (int j = ss.Length - 1; j > 0; j--)
                    {
                        if (ss[j] == '\\')
                        {
                            ss = ss.Substring(j + 1);
                            break;
                        }
                    }

                    type = Int32.Parse(ss[0] + "");
                    if (type == t) file1.Write("1 ");
                    else file1.Write("-1 ");

                    


                    foreach (var kvp in arrAllFile[i])
                    {
                        if (myDic.ContainsKey(kvp.Key))
                        {
                            file1.Write(myDic[kvp.Key] + ":");
                            
                            file1.Write(kvp.Value + " ");
                        }

                    }
                    file1.Write("\r\n");
                }
                file1.Flush();
                file1.Close();
            }
            txtketQuaDuLieu.Text += "Đã lưu dữ liệu vecto hóa: " + "\\data" + t + ".dat\r\n";
        }

        
        public void trainSVM(int type)
        {
           
            Process.Start("svm_learn.exe", "svmData\\data" + type + ".dat svmData/model" + type);
            
        }

        private String cutLastWord(String word)
        {
            int pos = word.Length;
            if (pos < 0) return "";

            for (int i = word.Length - 1; i > 0; i--)
            {
                if (word[i] == ' ') return word.Substring(0, i);
            }
            return "";
        }

        private void frmDuLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.addMessage("\r\n------------NAP DU LIEU-------------\r\n" + txtketQuaDuLieu.Text);
        }

        private void DuLieu_Load(object sender, EventArgs e)
        {
            //kn.myConnect();
            LoadDuLieu();

            this.txtDuongDan.Text = XuLyDuLieu.RAW_DATA_PATH;
            int count = 0;

            if (!File.Exists(XuLyDuLieu.RAW_DIC_NAME))
            {

                MessageBox.Show("Thiếu tập tin từ điển chính!", XuLyDuLieu.RAW_DIC_NAME , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (StreamReader sr = File.OpenText(XuLyDuLieu.RAW_DIC_NAME ))
            {
                String input;

                while ((input = sr.ReadLine()) != null)
                {
                    if (!myRawDic.ContainsKey(input))
                    {
                        myRawDic.Add(input, count);

                        count++;

                    }

                }

                sr.Close();
            }

            txtketQuaDuLieu.Text += count + " từ ...\r\n";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtketQuaDuLieu.ResetText();
            btnPhanTich.Enabled = false;
            
        }

        private void lstHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //saveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //saveFileDialog1.Title = "Save as ....";
            //saveFileDialog1.FileName = " ";
            //saveFileDialog1.Filter = "Text Files|*.txt| All Files | *.*";
            //string save = "";
            //if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            //{
            //    save = saveFileDialog1.FileName;
                
            //}
        }
   }
}

