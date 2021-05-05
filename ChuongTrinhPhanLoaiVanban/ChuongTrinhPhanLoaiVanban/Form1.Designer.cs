namespace ChuongTrinhPhanLoaiVanban
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPhanLoai = new System.Windows.Forms.TextBox();
            this.btnChuyenDe = new System.Windows.Forms.Button();
            this.btnPhanloai = new System.Windows.Forms.Button();
            this.btnDuLieu = new System.Windows.Forms.Button();
            this.btnGioiThieu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblTuDien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtPhanLoai
            // 
            this.txtPhanLoai.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhanLoai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPhanLoai.Location = new System.Drawing.Point(0, 187);
            this.txtPhanLoai.Multiline = true;
            this.txtPhanLoai.Name = "txtPhanLoai";
            this.txtPhanLoai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPhanLoai.Size = new System.Drawing.Size(612, 252);
            this.txtPhanLoai.TabIndex = 0;
            // 
            // btnChuyenDe
            // 
            this.btnChuyenDe.BackColor = System.Drawing.Color.MintCream;
            this.btnChuyenDe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChuyenDe.BackgroundImage")));
            this.btnChuyenDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChuyenDe.Location = new System.Drawing.Point(12, 98);
            this.btnChuyenDe.Name = "btnChuyenDe";
            this.btnChuyenDe.Size = new System.Drawing.Size(68, 50);
            this.btnChuyenDe.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnChuyenDe, "Chủ Đề");
            this.btnChuyenDe.UseVisualStyleBackColor = false;
            this.btnChuyenDe.Click += new System.EventHandler(this.btnChuyenDe_Click);
            // 
            // btnPhanloai
            // 
            this.btnPhanloai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhanloai.BackgroundImage")));
            this.btnPhanloai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhanloai.Enabled = false;
            this.btnPhanloai.Location = new System.Drawing.Point(327, 98);
            this.btnPhanloai.Name = "btnPhanloai";
            this.btnPhanloai.Size = new System.Drawing.Size(68, 50);
            this.btnPhanloai.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnPhanloai, "Phân Loại Văn Bản");
            this.btnPhanloai.UseVisualStyleBackColor = true;
            this.btnPhanloai.Click += new System.EventHandler(this.btnPhanloai_Click);
            // 
            // btnDuLieu
            // 
            this.btnDuLieu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDuLieu.BackgroundImage")));
            this.btnDuLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDuLieu.Enabled = false;
            this.btnDuLieu.Location = new System.Drawing.Point(219, 98);
            this.btnDuLieu.Name = "btnDuLieu";
            this.btnDuLieu.Size = new System.Drawing.Size(68, 50);
            this.btnDuLieu.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnDuLieu, "Nạp Dữ Liệu Vào Hệ Thống");
            this.btnDuLieu.UseVisualStyleBackColor = true;
            this.btnDuLieu.Click += new System.EventHandler(this.btnDuLieu_Click);
            // 
            // btnGioiThieu
            // 
            this.btnGioiThieu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGioiThieu.BackgroundImage")));
            this.btnGioiThieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGioiThieu.Location = new System.Drawing.Point(429, 98);
            this.btnGioiThieu.Name = "btnGioiThieu";
            this.btnGioiThieu.Size = new System.Drawing.Size(68, 50);
            this.btnGioiThieu.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnGioiThieu, "Giới Thiệu");
            this.btnGioiThieu.UseVisualStyleBackColor = true;
            this.btnGioiThieu.Click += new System.EventHandler(this.btnGioiThieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Location = new System.Drawing.Point(529, 98);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(68, 50);
            this.btnThoat.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnThoat, "Thoát");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chương Trình Phân Loại Văn Bản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tblTuDien
            // 
            this.tblTuDien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblTuDien.BackgroundImage")));
            this.tblTuDien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblTuDien.Location = new System.Drawing.Point(110, 98);
            this.tblTuDien.Name = "tblTuDien";
            this.tblTuDien.Size = new System.Drawing.Size(68, 50);
            this.tblTuDien.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tblTuDien, "Nạp Từ Điển");
            this.tblTuDien.UseVisualStyleBackColor = true;
            this.tblTuDien.Click += new System.EventHandler(this.tblTuDien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(23, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chủ Đề";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(311, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phân Loại Văn Bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(121, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Từ Điển";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(228, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dữ Liệu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(442, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Giới Thiệu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(546, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Thoát";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::ChuongTrinhPhanLoaiVanban.Properties.Resources.tải_xuống;
            this.ClientSize = new System.Drawing.Size(612, 439);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tblTuDien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGioiThieu);
            this.Controls.Add(this.btnDuLieu);
            this.Controls.Add(this.btnPhanloai);
            this.Controls.Add(this.btnChuyenDe);
            this.Controls.Add(this.txtPhanLoai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương Trình Phân Loại Văn Bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhanLoai;
        private System.Windows.Forms.Button btnChuyenDe;
        private System.Windows.Forms.Button btnPhanloai;
        private System.Windows.Forms.Button btnDuLieu;
        private System.Windows.Forms.Button btnGioiThieu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tblTuDien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

