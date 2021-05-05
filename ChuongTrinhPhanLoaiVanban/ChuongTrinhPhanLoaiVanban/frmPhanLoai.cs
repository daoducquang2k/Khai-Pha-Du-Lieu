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
    public partial class frmPhanLoai : Form
    {
        private Form1 p;

        private SortedDictionary<string, int> myDic = new SortedDictionary<string, int>();


        private String[] listFile = null;


        private string[,] resultArr = null;
        public frmPhanLoai(Form1 p)
        {
           this.p = p;
            InitializeComponent();
        }
        //Data kn = new Data();
        //string[] fineNames, finePaths;
        public void LoadDuLieu()
        {

            //string sql = "Select fldID,fldTuDien,fldPhienDich from TuDien";
            ////dvgDonVi.DataSource = kn.taobang(sql);

            //dvgPhanLoai.DataSource = kn.taobang(sql);
            //DataTable dtb = new DataTable();
            //dtb = kn.taobang(sql);
            //lstPhanLoai.DataSource = dtb;
            //lstPhiendich.DataSource = dtb;
            //lstPhanLoai.DisplayMember = "fldTuDien";
            //lstPhanLoai.ValueMember = "fldID";
            //lstPhiendich.DisplayMember = "fldPhienDich";
        }

        private void frmPhanLoai_Load(object sender, EventArgs e)
        {
            //kn.myConnect();
            LoadDuLieu();



            if (!File.Exists(XuLyDuLieu.NEW_DIC_NAME))
            {
                MessageBox.Show("Thiếu tập tin từ điển!", XuLyDuLieu.NEW_DIC_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (StreamReader sr = File.OpenText( XuLyDuLieu.NEW_DIC_NAME))
            {
                String input;
                int c = 1;
                while ((input = sr.ReadLine()) != null)
                {
                    if (!myDic.ContainsKey(input))
                    {
                        myDic.Add(input, c);
                        c++;
                    }
                }
                sr.Close();
            }
            txtPhanLoai.Text += "Nạp từ điển " + myDic.Count + " từ...\r\n";

            //nap van ban
            if (XuLyDuLieu.TEST_DATA_PATH.Length <= 0) return;
            if (Directory.Exists(XuLyDuLieu.TEST_DATA_PATH) != true)
            {
                MessageBox.Show("Đường dẫn không đúng!");
                return;
            }

            DirectoryInfo di = new DirectoryInfo(XuLyDuLieu.TEST_DATA_PATH);
            FileInfo[] rgFiles = di.GetFiles("*.txt");
            txtPhanLoai.Text += "Tìm thấy " + rgFiles.Length + " văn bản!\r\n";

            resultArr = new String[2, rgFiles.Length];
            String name = "";
            int cc = 0;
            foreach (FileInfo fi in rgFiles)
            {
                resultArr[0, cc] = fi.Name;
                resultArr[1, cc] = "Không xác định";

                txtPhanLoai.Text += "\r\n" + fi.Name;
                name += XuLyDuLieu.TEST_DATA_PATH + "\\" + fi.Name + "|";
                cc++;
            }
            name = name.Substring(0, name.Length - 1);
            listFile = name.Split('|');
            txtPhanLoai.ScrollToCaret();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        
            {
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

                
                int pos = 0;    
                String world;   
                for (int i = 0; i < sArr.Length; i++)
                {
                    sArr[i] = sArr[i].Trim();

                    if (sArr[i].Length > 0)
                    {
                        //loai bo so
                        for (int g = 0; g < 10; g++)
                        {
                            pos = sArr[i].IndexOf(g + "");
                            while (pos >= 0)
                            {
                                sArr[i] = sArr[i].Substring(0, pos) + sArr[i].Substring(pos + 1);
                                pos = sArr[i].IndexOf(g + "");
                            }
                        }


                        //loai bo stop world
                        for (int j = 0; j < XuLyDuLieu.stopWordArr.Length; j++)
                        {
                            pos = sArr[i].IndexOf(XuLyDuLieu.stopWordArr[j]);
                            while (pos >= 0)
                            {
                                sArr[i] = sArr[i].Substring(0, pos) + " " + sArr[i].Substring(pos + XuLyDuLieu.stopWordArr[j].Length);
                                
                                pos = sArr[i].IndexOf(XuLyDuLieu.stopWordArr[j]);
                            }
                        }

                        //loai bo cac tu don vo nghia
                        for (int j = 0; j < XuLyDuLieu.noMeaningArr.Length; j++)
                        {
                            pos = sArr[i].IndexOf(XuLyDuLieu.noMeaningArr[j]);
                            while (pos >= 0)
                            {
                                sArr[i] = sArr[i].Substring(0, pos) + " " + sArr[i].Substring(pos + XuLyDuLieu.noMeaningArr[j].Length);
                                
                                pos = sArr[i].IndexOf(XuLyDuLieu.noMeaningArr[j]);
                            }
                        }


                        //cat cac tu trong cau ra
                        world = sArr[i];
                        
                        String w = world;

                        while (world.Length > 0)
                        {
                            while (w.Length > XuLyDuLieu.maxWordLength) w = cutLastWord(w);

                            if (myDic.ContainsKey(w))
                            {
                                //neu tu do trong tu dien, luu vao tu dien trung gian
                                if (!myDic.ContainsKey(w))
                                {
                                   
                                    arrAllFile[k].Add(w, 1);
                                }
                                else
                                {
                                    

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
                                    if (myDic.ContainsKey(srrTemp[0]))
                                    {
                                        //neu tu don co trong tu dien-> luu
                                        if (!myDic.ContainsKey(w))
                                        {
                                                                                
                                            arrAllFile[k].Add(srrTemp[0], 1);
                                        }
                                        else
                                        {
                                            
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

            //luu ra file
            using (StreamWriter file1 = new StreamWriter(File.Open(XuLyDuLieu.SVM_DATA_PATH + "\\test.txt", FileMode.Create), Encoding.ASCII))
            {
                
                for (int i = 0; i < arrAllFile.Length; i++)
                {
                    
                    file1.Write(" 0 ");
                    
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
             txtPhanLoai.ScrollToCaret();
            MessageBox.Show("Đã xử lý xong!");
            btnPhanLoai.Enabled = true;
        }

        //cat tu cuoi trong 1 doan van ban
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

        private void btnPhanLoai_Click(object sender, EventArgs e)
        {
            classifySVM(XuLyDuLieu.TYPE_PHAPLUAT);
            classifySVM(XuLyDuLieu.TYPE_THETHAO);
            classifySVM(XuLyDuLieu.TYPE_KINHTE);

            txtPhanLoai.Text += "\r\n\r\n" + phanLoaivanBan();
            MessageBox.Show("Đã phân loại!");
        }
        public String phanLoaivanBan()
        {
            //kiem tra file
            for (int i = 1; i < 4; i++)
            {
                String sdata = System.IO.File.ReadAllText(XuLyDuLieu.SVM_DATA_PATH + "predictions" + i);
                if (sdata.Length <= 0)
                {
                    MessageBox.Show("Lỗi đọc file!");
                    return "";
                }

                sdata = sdata.Replace('\r', ' ');
                String[] arr = sdata.Split('\n');
                if (arr.Length < 0) return "";

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j].Trim();
                    double d = double.Parse(arr[j]);
                    if (d > 0)
                    {
                        if (i == XuLyDuLieu.TYPE_THETHAO) resultArr[1, j] = "Thể Thao";
                        else if (i == XuLyDuLieu.TYPE_KINHTE) resultArr[1, j] = "Kinh Tế";
                        else if (i == XuLyDuLieu.TYPE_PHAPLUAT) resultArr[1, j] = "Pháp Luật";
                    }
                }
            }

            String sResult = "\r\nKết quả phân loại:\r\n";
            for (int i = 0; i < resultArr.Length / 2; i++)
            {
                sResult += resultArr[0, i] + " : " + resultArr[1, i] + "\r\n";
            }
            return sResult;
        }
        public void classifySVM(int type)
        {
            Process.Start("svm_classify.exe", "svmData/test.txt svmData/model" + type + " svmData/predictions" + type);
        }

        private void frmPhanLoai_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.addMessage("\r\n------------PHÂN LOẠI-------------\r\n" + txtPhanLoai.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        }
    }

