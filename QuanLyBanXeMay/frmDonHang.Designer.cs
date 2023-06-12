namespace QuanLyBanXeMay
{
    partial class frmDonHang
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtCancuoc = new MetroFramework.Controls.MetroTextBox();
            this.qLBXemayDataSet = new QuanLyBanXeMay.QLBXemayDataSet();
            this.qLBXemayDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenxe = new MetroFramework.Controls.MetroTextBox();
            this.txtHangXe = new MetroFramework.Controls.MetroTextBox();
            this.txtGiaban = new MetroFramework.Controls.MetroTextBox();
            this.txtSoMay = new MetroFramework.Controls.MetroTextBox();
            this.txtTen = new MetroFramework.Controls.MetroTextBox();
            this.txtMausac = new MetroFramework.Controls.MetroTextBox();
            this.txtSoKhung = new MetroFramework.Controls.MetroTextBox();
            this.dgvKh = new System.Windows.Forms.DataGridView();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanCuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.s = new MetroFramework.Controls.MetroLabel();
            this.txtSdt = new MetroFramework.Controls.MetroTextBox();
            this.SoDt = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaXess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtMaKH = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.qLBXemayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBXemayDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 463);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tên Khách Hàng";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 515);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Hãng Xe";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 414);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Mã Khách Hàng";
            // 
            // txtCancuoc
            // 
            // 
            // 
            // 
            this.txtCancuoc.CustomButton.Image = null;
            this.txtCancuoc.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtCancuoc.CustomButton.Name = "";
            this.txtCancuoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCancuoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCancuoc.CustomButton.TabIndex = 1;
            this.txtCancuoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCancuoc.CustomButton.UseSelectable = true;
            this.txtCancuoc.CustomButton.Visible = false;
            this.txtCancuoc.Enabled = false;
            this.txtCancuoc.Lines = new string[0];
            this.txtCancuoc.Location = new System.Drawing.Point(541, 418);
            this.txtCancuoc.MaxLength = 32767;
            this.txtCancuoc.Name = "txtCancuoc";
            this.txtCancuoc.PasswordChar = '\0';
            this.txtCancuoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCancuoc.SelectedText = "";
            this.txtCancuoc.SelectionLength = 0;
            this.txtCancuoc.SelectionStart = 0;
            this.txtCancuoc.ShortcutsEnabled = true;
            this.txtCancuoc.Size = new System.Drawing.Size(127, 23);
            this.txtCancuoc.TabIndex = 4;
            this.txtCancuoc.UseSelectable = true;
            this.txtCancuoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCancuoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // qLBXemayDataSet
            // 
            this.qLBXemayDataSet.DataSetName = "QLBXemayDataSet";
            this.qLBXemayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBXemayDataSetBindingSource
            // 
            this.qLBXemayDataSetBindingSource.DataSource = this.qLBXemayDataSet;
            this.qLBXemayDataSetBindingSource.Position = 0;
            // 
            // txtTenxe
            // 
            // 
            // 
            // 
            this.txtTenxe.CustomButton.Image = null;
            this.txtTenxe.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.txtTenxe.CustomButton.Name = "";
            this.txtTenxe.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenxe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenxe.CustomButton.TabIndex = 1;
            this.txtTenxe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenxe.CustomButton.UseSelectable = true;
            this.txtTenxe.CustomButton.Visible = false;
            this.txtTenxe.Enabled = false;
            this.txtTenxe.Lines = new string[0];
            this.txtTenxe.Location = new System.Drawing.Point(113, 562);
            this.txtTenxe.MaxLength = 32767;
            this.txtTenxe.Name = "txtTenxe";
            this.txtTenxe.PasswordChar = '\0';
            this.txtTenxe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenxe.SelectedText = "";
            this.txtTenxe.SelectionLength = 0;
            this.txtTenxe.SelectionStart = 0;
            this.txtTenxe.ShortcutsEnabled = true;
            this.txtTenxe.Size = new System.Drawing.Size(150, 23);
            this.txtTenxe.TabIndex = 7;
            this.txtTenxe.UseSelectable = true;
            this.txtTenxe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenxe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHangXe
            // 
            // 
            // 
            // 
            this.txtHangXe.CustomButton.Image = null;
            this.txtHangXe.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.txtHangXe.CustomButton.Name = "";
            this.txtHangXe.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHangXe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHangXe.CustomButton.TabIndex = 1;
            this.txtHangXe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHangXe.CustomButton.UseSelectable = true;
            this.txtHangXe.CustomButton.Visible = false;
            this.txtHangXe.Enabled = false;
            this.txtHangXe.Lines = new string[0];
            this.txtHangXe.Location = new System.Drawing.Point(113, 515);
            this.txtHangXe.MaxLength = 32767;
            this.txtHangXe.Name = "txtHangXe";
            this.txtHangXe.PasswordChar = '\0';
            this.txtHangXe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHangXe.SelectedText = "";
            this.txtHangXe.SelectionLength = 0;
            this.txtHangXe.SelectionStart = 0;
            this.txtHangXe.ShortcutsEnabled = true;
            this.txtHangXe.Size = new System.Drawing.Size(150, 23);
            this.txtHangXe.TabIndex = 8;
            this.txtHangXe.UseSelectable = true;
            this.txtHangXe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHangXe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGiaban
            // 
            // 
            // 
            // 
            this.txtGiaban.CustomButton.Image = null;
            this.txtGiaban.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.txtGiaban.CustomButton.Name = "";
            this.txtGiaban.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGiaban.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGiaban.CustomButton.TabIndex = 1;
            this.txtGiaban.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGiaban.CustomButton.UseSelectable = true;
            this.txtGiaban.CustomButton.Visible = false;
            this.txtGiaban.Enabled = false;
            this.txtGiaban.Lines = new string[0];
            this.txtGiaban.Location = new System.Drawing.Point(722, 562);
            this.txtGiaban.MaxLength = 32767;
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.PasswordChar = '\0';
            this.txtGiaban.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGiaban.SelectedText = "";
            this.txtGiaban.SelectionLength = 0;
            this.txtGiaban.SelectionStart = 0;
            this.txtGiaban.ShortcutsEnabled = true;
            this.txtGiaban.Size = new System.Drawing.Size(150, 23);
            this.txtGiaban.TabIndex = 9;
            this.txtGiaban.UseSelectable = true;
            this.txtGiaban.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGiaban.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGiaban.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // txtSoMay
            // 
            // 
            // 
            // 
            this.txtSoMay.CustomButton.Image = null;
            this.txtSoMay.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.txtSoMay.CustomButton.Name = "";
            this.txtSoMay.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSoMay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoMay.CustomButton.TabIndex = 1;
            this.txtSoMay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoMay.CustomButton.UseSelectable = true;
            this.txtSoMay.CustomButton.Visible = false;
            this.txtSoMay.Enabled = false;
            this.txtSoMay.Lines = new string[0];
            this.txtSoMay.Location = new System.Drawing.Point(409, 562);
            this.txtSoMay.MaxLength = 32767;
            this.txtSoMay.Name = "txtSoMay";
            this.txtSoMay.PasswordChar = '\0';
            this.txtSoMay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoMay.SelectedText = "";
            this.txtSoMay.SelectionLength = 0;
            this.txtSoMay.SelectionStart = 0;
            this.txtSoMay.ShortcutsEnabled = true;
            this.txtSoMay.Size = new System.Drawing.Size(150, 23);
            this.txtSoMay.TabIndex = 10;
            this.txtSoMay.UseSelectable = true;
            this.txtSoMay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoMay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.CustomButton.Image = null;
            this.txtTen.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.txtTen.CustomButton.Name = "";
            this.txtTen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTen.CustomButton.TabIndex = 1;
            this.txtTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTen.CustomButton.UseSelectable = true;
            this.txtTen.CustomButton.Visible = false;
            this.txtTen.Enabled = false;
            this.txtTen.Lines = new string[0];
            this.txtTen.Location = new System.Drawing.Point(177, 463);
            this.txtTen.MaxLength = 32767;
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTen.SelectedText = "";
            this.txtTen.SelectionLength = 0;
            this.txtTen.SelectionStart = 0;
            this.txtTen.ShortcutsEnabled = true;
            this.txtTen.Size = new System.Drawing.Size(150, 23);
            this.txtTen.TabIndex = 11;
            this.txtTen.UseSelectable = true;
            this.txtTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMausac
            // 
            // 
            // 
            // 
            this.txtMausac.CustomButton.Image = null;
            this.txtMausac.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.txtMausac.CustomButton.Name = "";
            this.txtMausac.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMausac.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMausac.CustomButton.TabIndex = 1;
            this.txtMausac.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMausac.CustomButton.UseSelectable = true;
            this.txtMausac.CustomButton.Visible = false;
            this.txtMausac.Enabled = false;
            this.txtMausac.Lines = new string[0];
            this.txtMausac.Location = new System.Drawing.Point(722, 511);
            this.txtMausac.MaxLength = 32767;
            this.txtMausac.Name = "txtMausac";
            this.txtMausac.PasswordChar = '\0';
            this.txtMausac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMausac.SelectedText = "";
            this.txtMausac.SelectionLength = 0;
            this.txtMausac.SelectionStart = 0;
            this.txtMausac.ShortcutsEnabled = true;
            this.txtMausac.Size = new System.Drawing.Size(150, 23);
            this.txtMausac.TabIndex = 12;
            this.txtMausac.UseSelectable = true;
            this.txtMausac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMausac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSoKhung
            // 
            // 
            // 
            // 
            this.txtSoKhung.CustomButton.Image = null;
            this.txtSoKhung.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.txtSoKhung.CustomButton.Name = "";
            this.txtSoKhung.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSoKhung.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoKhung.CustomButton.TabIndex = 1;
            this.txtSoKhung.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoKhung.CustomButton.UseSelectable = true;
            this.txtSoKhung.CustomButton.Visible = false;
            this.txtSoKhung.Enabled = false;
            this.txtSoKhung.Lines = new string[0];
            this.txtSoKhung.Location = new System.Drawing.Point(409, 511);
            this.txtSoKhung.MaxLength = 32767;
            this.txtSoKhung.Name = "txtSoKhung";
            this.txtSoKhung.PasswordChar = '\0';
            this.txtSoKhung.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoKhung.SelectedText = "";
            this.txtSoKhung.SelectionLength = 0;
            this.txtSoKhung.SelectionStart = 0;
            this.txtSoKhung.ShortcutsEnabled = true;
            this.txtSoKhung.Size = new System.Drawing.Size(150, 23);
            this.txtSoKhung.TabIndex = 13;
            this.txtSoKhung.UseSelectable = true;
            this.txtSoKhung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoKhung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvKh
            // 
            this.dgvKh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TT,
            this.HoTen,
            this.CanCuoc,
            this.DienThoai,
            this.MaKh});
            this.dgvKh.Location = new System.Drawing.Point(48, 63);
            this.dgvKh.Name = "dgvKh";
            this.dgvKh.Size = new System.Drawing.Size(468, 144);
            this.dgvKh.TabIndex = 14;
            this.dgvKh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKh_CellContentClick);
            // 
            // TT
            // 
            this.TT.DataPropertyName = "TT";
            this.TT.HeaderText = "TT";
            this.TT.Name = "TT";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // CanCuoc
            // 
            this.CanCuoc.DataPropertyName = "CanCuoc";
            this.CanCuoc.HeaderText = "Căn Cước";
            this.CanCuoc.Name = "CanCuoc";
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Số Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // MaKh
            // 
            this.MaKh.DataPropertyName = "MaKH";
            this.MaKh.HeaderText = "Mã Khách Hàng";
            this.MaKh.Name = "MaKh";
            this.MaKh.Visible = false;
            // 
            // dgvHang
            // 
            this.dgvHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.SoMay,
            this.MauSac,
            this.GiaBan,
            this.MaXess});
            this.dgvHang.Location = new System.Drawing.Point(48, 243);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.Size = new System.Drawing.Size(756, 144);
            this.dgvHang.TabIndex = 15;
            this.dgvHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(387, 418);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(67, 19);
            this.s.TabIndex = 16;
            this.s.Text = "Căn Cước";
            // 
            // txtSdt
            // 
            // 
            // 
            // 
            this.txtSdt.CustomButton.Image = null;
            this.txtSdt.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtSdt.CustomButton.Name = "";
            this.txtSdt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSdt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSdt.CustomButton.TabIndex = 1;
            this.txtSdt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSdt.CustomButton.UseSelectable = true;
            this.txtSdt.CustomButton.Visible = false;
            this.txtSdt.Enabled = false;
            this.txtSdt.Lines = new string[0];
            this.txtSdt.Location = new System.Drawing.Point(541, 463);
            this.txtSdt.MaxLength = 32767;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.PasswordChar = '\0';
            this.txtSdt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSdt.SelectedText = "";
            this.txtSdt.SelectionLength = 0;
            this.txtSdt.SelectionStart = 0;
            this.txtSdt.ShortcutsEnabled = true;
            this.txtSdt.Size = new System.Drawing.Size(127, 23);
            this.txtSdt.TabIndex = 17;
            this.txtSdt.UseSelectable = true;
            this.txtSdt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSdt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SoDt
            // 
            this.SoDt.AutoSize = true;
            this.SoDt.Location = new System.Drawing.Point(387, 463);
            this.SoDt.Name = "SoDt";
            this.SoDt.Size = new System.Drawing.Size(90, 19);
            this.SoDt.TabIndex = 18;
            this.SoDt.Text = "Số Điện Thoại";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TT";
            this.dataGridViewTextBoxColumn1.HeaderText = "TT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HangXe";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hãng Xe";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenXe";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên Xe";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoKhung";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số Khung";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // SoMay
            // 
            this.SoMay.DataPropertyName = "SoMay";
            this.SoMay.HeaderText = "Số Máy";
            this.SoMay.Name = "SoMay";
            // 
            // MauSac
            // 
            this.MauSac.DataPropertyName = "MauSac";
            this.MauSac.HeaderText = "Màu Sắc";
            this.MauSac.Name = "MauSac";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // MaXess
            // 
            this.MaXess.DataPropertyName = "MaXe";
            this.MaXess.HeaderText = "Mã Xe";
            this.MaXess.Name = "MaXess";
            this.MaXess.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 566);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Tên Xe";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(323, 515);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Số Khung";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(323, 566);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(53, 19);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "Số Máy";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(604, 511);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 22;
            this.metroLabel7.Text = "Màu Sắc";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(604, 562);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(54, 19);
            this.metroLabel8.TabIndex = 23;
            this.metroLabel8.Text = "Giá Bán";
            // 
            // txtMaKH
            // 
            this.txtMaKH.AutoSize = true;
            this.txtMaKH.Location = new System.Drawing.Point(177, 414);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(0, 0);
            this.txtMaKH.TabIndex = 24;
            this.txtMaKH.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(349, 598);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(128, 23);
            this.metroButton1.TabIndex = 25;
            this.metroButton1.Text = "Tạo Đơn";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // frmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 644);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.SoDt);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.s);
            this.Controls.Add(this.dgvHang);
            this.Controls.Add(this.dgvKh);
            this.Controls.Add(this.txtSoKhung);
            this.Controls.Add(this.txtMausac);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtSoMay);
            this.Controls.Add(this.txtGiaban);
            this.Controls.Add(this.txtHangXe);
            this.Controls.Add(this.txtTenxe);
            this.Controls.Add(this.txtCancuoc);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmDonHang";
            this.Text = "Đơn Hàng";
            this.Load += new System.EventHandler(this.frmDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBXemayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBXemayDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtCancuoc;
        private QLBXemayDataSet qLBXemayDataSet;
        private System.Windows.Forms.BindingSource qLBXemayDataSetBindingSource;
        private MetroFramework.Controls.MetroTextBox txtTenxe;
        private MetroFramework.Controls.MetroTextBox txtHangXe;
        private MetroFramework.Controls.MetroTextBox txtGiaban;
        private MetroFramework.Controls.MetroTextBox txtSoMay;
        private MetroFramework.Controls.MetroTextBox txtTen;
        private MetroFramework.Controls.MetroTextBox txtMausac;
        private MetroFramework.Controls.MetroTextBox txtSoKhung;
        private System.Windows.Forms.DataGridView dgvKh;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanCuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKh;
        private MetroFramework.Controls.MetroLabel s;
        private MetroFramework.Controls.MetroTextBox txtSdt;
        private MetroFramework.Controls.MetroLabel SoDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXess;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel txtMaKH;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}