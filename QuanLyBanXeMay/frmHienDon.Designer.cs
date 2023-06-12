namespace QuanLyBanXeMay
{
    partial class frmHienDon
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
            this.dgvDh = new System.Windows.Forms.DataGridView();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanCuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKhung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDh
            // 
            this.dgvDh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TT,
            this.Column1,
            this.CanCuoc,
            this.DienThoai,
            this.SoKhung,
            this.SoMay,
            this.TenXe,
            this.TenHang,
            this.MauSac});
            this.dgvDh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDh.Location = new System.Drawing.Point(20, 60);
            this.dgvDh.Name = "dgvDh";
            this.dgvDh.Size = new System.Drawing.Size(1079, 598);
            this.dgvDh.TabIndex = 0;
            this.dgvDh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TT
            // 
            this.TT.DataPropertyName = "TT";
            this.TT.HeaderText = "TT";
            this.TT.Name = "TT";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HoTen";
            this.Column1.HeaderText = "Họ Tên";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // CanCuoc
            // 
            this.CanCuoc.DataPropertyName = "CanCuoc";
            this.CanCuoc.HeaderText = "Căn Cước";
            this.CanCuoc.Name = "CanCuoc";
            this.CanCuoc.Width = 150;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // SoKhung
            // 
            this.SoKhung.DataPropertyName = "SoKhung";
            this.SoKhung.HeaderText = "Số Khung";
            this.SoKhung.Name = "SoKhung";
            this.SoKhung.Width = 110;
            // 
            // SoMay
            // 
            this.SoMay.DataPropertyName = "SoMay";
            this.SoMay.HeaderText = "Số Máy";
            this.SoMay.Name = "SoMay";
            // 
            // TenXe
            // 
            this.TenXe.DataPropertyName = "TenXe";
            this.TenXe.HeaderText = "Tên Xe";
            this.TenXe.Name = "TenXe";
            this.TenXe.Width = 120;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "HangXe";
            this.TenHang.HeaderText = "Tên Hãng";
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 120;
            // 
            // MauSac
            // 
            this.MauSac.DataPropertyName = "MauSac";
            this.MauSac.HeaderText = "Màu Sắc";
            this.MauSac.Name = "MauSac";
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroButton1.Location = new System.Drawing.Point(20, 635);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(1079, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "In Hoá Đơn";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroButton2.Location = new System.Drawing.Point(20, 612);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(1079, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "In 1 Hoá Đơn";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // frmHienDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 678);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dgvDh);
            this.Name = "frmHienDon";
            this.Text = "Danh Sách Hoá Đơn";
            this.Load += new System.EventHandler(this.frmHienDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDh;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanCuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoKhung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}