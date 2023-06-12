namespace QuanLyBanXeMay
{
    partial class frmDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangnhap));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.textBoxpassword = new MetroFramework.Controls.MetroTextBox();
            this.btnDangNhap = new MetroFramework.Controls.MetroButton();
            this.BntThoat = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Tài Khoản";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Mật Khẩu";
            // 
            // textBoxUsername
            // 
            // 
            // 
            // 
            this.textBoxUsername.CustomButton.Image = null;
            this.textBoxUsername.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.textBoxUsername.CustomButton.Name = "";
            this.textBoxUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxUsername.CustomButton.TabIndex = 1;
            this.textBoxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxUsername.CustomButton.UseSelectable = true;
            this.textBoxUsername.CustomButton.Visible = false;
            this.textBoxUsername.Lines = new string[0];
            this.textBoxUsername.Location = new System.Drawing.Point(127, 82);
            this.textBoxUsername.MaxLength = 32767;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.SelectionLength = 0;
            this.textBoxUsername.SelectionStart = 0;
            this.textBoxUsername.ShortcutsEnabled = true;
            this.textBoxUsername.Size = new System.Drawing.Size(134, 23);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.UseSelectable = true;
            this.textBoxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxpassword
            // 
            // 
            // 
            // 
            this.textBoxpassword.CustomButton.Image = null;
            this.textBoxpassword.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.textBoxpassword.CustomButton.Name = "";
            this.textBoxpassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxpassword.CustomButton.TabIndex = 1;
            this.textBoxpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxpassword.CustomButton.UseSelectable = true;
            this.textBoxpassword.CustomButton.Visible = false;
            this.textBoxpassword.Lines = new string[0];
            this.textBoxpassword.Location = new System.Drawing.Point(127, 147);
            this.textBoxpassword.MaxLength = 32767;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '*';
            this.textBoxpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxpassword.SelectedText = "";
            this.textBoxpassword.SelectionLength = 0;
            this.textBoxpassword.SelectionStart = 0;
            this.textBoxpassword.ShortcutsEnabled = true;
            this.textBoxpassword.Size = new System.Drawing.Size(134, 23);
            this.textBoxpassword.TabIndex = 4;
            this.textBoxpassword.UseSelectable = true;
            this.textBoxpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(51, 198);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(100, 23);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseSelectable = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // BntThoat
            // 
            this.BntThoat.Location = new System.Drawing.Point(204, 198);
            this.BntThoat.Name = "BntThoat";
            this.BntThoat.Size = new System.Drawing.Size(97, 23);
            this.BntThoat.TabIndex = 6;
            this.BntThoat.Text = "Thoát";
            this.BntThoat.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(278, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(278, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 275);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BntThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangnhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textBoxUsername;
        private MetroFramework.Controls.MetroTextBox textBoxpassword;
        private MetroFramework.Controls.MetroButton btnDangNhap;
        private MetroFramework.Controls.MetroButton BntThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}