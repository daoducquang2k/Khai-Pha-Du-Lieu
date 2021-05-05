namespace ChuongTrinhPhanLoaiVanban
{
    partial class frmDuLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDuLieu));
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNapDuLieu = new System.Windows.Forms.Button();
            this.btnPhanTich = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtketQuaDuLieu = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(117, 6);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(144, 20);
            this.txtDuongDan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đường Dẫn Dữ Liệu";
            // 
            // btnNapDuLieu
            // 
            this.btnNapDuLieu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNapDuLieu.BackgroundImage")));
            this.btnNapDuLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNapDuLieu.Location = new System.Drawing.Point(13, 19);
            this.btnNapDuLieu.Name = "btnNapDuLieu";
            this.btnNapDuLieu.Size = new System.Drawing.Size(54, 41);
            this.btnNapDuLieu.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnNapDuLieu, "Nạp Dữ Liệu");
            this.btnNapDuLieu.UseVisualStyleBackColor = true;
            this.btnNapDuLieu.Click += new System.EventHandler(this.btnNapDuLieu_Click);
            // 
            // btnPhanTich
            // 
            this.btnPhanTich.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhanTich.BackgroundImage")));
            this.btnPhanTich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhanTich.Enabled = false;
            this.btnPhanTich.Location = new System.Drawing.Point(91, 19);
            this.btnPhanTich.Name = "btnPhanTich";
            this.btnPhanTich.Size = new System.Drawing.Size(54, 41);
            this.btnPhanTich.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnPhanTich, "Phân Tích");
            this.btnPhanTich.UseVisualStyleBackColor = true;
            this.btnPhanTich.Click += new System.EventHandler(this.btnPhanTich_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuy.Location = new System.Drawing.Point(174, 19);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(54, 41);
            this.btnHuy.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnHuy, "Hủy");
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Location = new System.Drawing.Point(443, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 52);
            this.btnThoat.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnThoat, "Thoát");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtketQuaDuLieu
            // 
            this.txtketQuaDuLieu.BackColor = System.Drawing.SystemColors.Window;
            this.txtketQuaDuLieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtketQuaDuLieu.Location = new System.Drawing.Point(0, 140);
            this.txtketQuaDuLieu.Multiline = true;
            this.txtketQuaDuLieu.Name = "txtketQuaDuLieu";
            this.txtketQuaDuLieu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtketQuaDuLieu.Size = new System.Drawing.Size(530, 218);
            this.txtketQuaDuLieu.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNapDuLieu);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnPhanTich);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 88);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hủy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phân Tích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nạp Dữ Liệu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thoát";
            // 
            // frmDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(530, 358);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtketQuaDuLieu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDuongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDuLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDuLieu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDuLieu_FormClosing);
            this.Load += new System.EventHandler(this.DuLieu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNapDuLieu;
        private System.Windows.Forms.Button btnPhanTich;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtketQuaDuLieu;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}