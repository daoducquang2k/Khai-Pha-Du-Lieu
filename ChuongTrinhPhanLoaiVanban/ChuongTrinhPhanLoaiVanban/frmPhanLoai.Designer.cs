namespace ChuongTrinhPhanLoaiVanban
{
    partial class frmPhanLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanLoai));
            this.txtPhanLoai = new System.Windows.Forms.TextBox();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.btnPhanLoai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhanLoai
            // 
            this.txtPhanLoai.Location = new System.Drawing.Point(0, 141);
            this.txtPhanLoai.Multiline = true;
            this.txtPhanLoai.Name = "txtPhanLoai";
            this.txtPhanLoai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPhanLoai.Size = new System.Drawing.Size(530, 203);
            this.txtPhanLoai.TabIndex = 0;
            // 
            // btnXuLy
            // 
            this.btnXuLy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuLy.BackgroundImage")));
            this.btnXuLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuLy.Location = new System.Drawing.Point(22, 19);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(54, 41);
            this.btnXuLy.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnXuLy, "Xử Lí Văn Bản");
            this.btnXuLy.UseVisualStyleBackColor = true;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // btnPhanLoai
            // 
            this.btnPhanLoai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhanLoai.BackgroundImage")));
            this.btnPhanLoai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhanLoai.Enabled = false;
            this.btnPhanLoai.Location = new System.Drawing.Point(127, 19);
            this.btnPhanLoai.Name = "btnPhanLoai";
            this.btnPhanLoai.Size = new System.Drawing.Size(54, 41);
            this.btnPhanLoai.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnPhanLoai, "Phân Loại Văn Bản");
            this.btnPhanLoai.UseVisualStyleBackColor = true;
            this.btnPhanLoai.Click += new System.EventHandler(this.btnPhanLoai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phân Loại Văn Bản";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(443, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button1, "Thoát");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnXuLy);
            this.groupBox1.Controls.Add(this.btnPhanLoai);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Xử lí  văn bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phân loại văn bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thoát";
            // 
            // frmPhanLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(530, 345);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhanLoai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhanLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhanLoai";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhanLoai_FormClosing);
            this.Load += new System.EventHandler(this.frmPhanLoai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhanLoai;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.Button btnPhanLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}