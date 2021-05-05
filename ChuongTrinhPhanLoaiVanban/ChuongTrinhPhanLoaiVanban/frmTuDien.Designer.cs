namespace ChuongTrinhPhanLoaiVanban
{
    partial class frmTuDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTuDien));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNap = new System.Windows.Forms.Button();
            this.cboNapTuDien = new System.Windows.Forms.ComboBox();
            this.lstHienThi = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnNap);
            this.groupBox2.Controls.Add(this.cboNapTuDien);
            this.groupBox2.Location = new System.Drawing.Point(150, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 142);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Từ Điển";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thoát";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nạp Từ Điển";
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Location = new System.Drawing.Point(139, 58);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(54, 41);
            this.btnThoat.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnThoat, "Thoát");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNap
            // 
            this.btnNap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNap.BackgroundImage")));
            this.btnNap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNap.Location = new System.Drawing.Point(37, 58);
            this.btnNap.Name = "btnNap";
            this.btnNap.Size = new System.Drawing.Size(54, 41);
            this.btnNap.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnNap, "Nạp Từ Điển");
            this.btnNap.UseVisualStyleBackColor = true;
            this.btnNap.Click += new System.EventHandler(this.btnNap_Click);
            // 
            // cboNapTuDien
            // 
            this.cboNapTuDien.FormattingEnabled = true;
            this.cboNapTuDien.Location = new System.Drawing.Point(21, 19);
            this.cboNapTuDien.Name = "cboNapTuDien";
            this.cboNapTuDien.Size = new System.Drawing.Size(185, 21);
            this.cboNapTuDien.TabIndex = 2;
            // 
            // lstHienThi
            // 
            this.lstHienThi.FormattingEnabled = true;
            this.lstHienThi.Location = new System.Drawing.Point(12, 12);
            this.lstHienThi.Name = "lstHienThi";
            this.lstHienThi.Size = new System.Drawing.Size(132, 212);
            this.lstHienThi.TabIndex = 3;
            // 
            // frmTuDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(391, 235);
            this.Controls.Add(this.lstHienThi);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTuDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTuDien";
            this.Load += new System.EventHandler(this.frmTuDien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNap;
        private System.Windows.Forms.ComboBox cboNapTuDien;
        private System.Windows.Forms.ListBox lstHienThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}