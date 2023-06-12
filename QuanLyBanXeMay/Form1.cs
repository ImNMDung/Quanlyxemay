using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanXeMay
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        XeMay model = new XeMay();
        KhachHang moder_kh = new KhachHang();
        int Maxe,MaKH;

        private static bool handlingEvent = false;
        public Form1()
        {
            InitializeComponent();

            customsize();
            nhapxuat();
            lock_unlock(Luu.KT);
            check_uncheck();
           
            tbTimten.Visible = false;
            logoLon.Visible = true;
            // load dữ liệu sau mỗi lần sử dụng
            LoadComboBox();
            LoadComboBoxGT();
            loadDataToGrv("*");
            loadDataToGrv1("*");
            loadDataToGrv2("*");
            loadDataToGrv3("*");
        }
        public void LoadComboBoxGT()
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-GR9NFKL; database=QLBXemay;user id=keiths;password=123456");
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select DISTINCT GioiTinh From KhachHang", conn);
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            if (metroCheckBox1.Checked)
            {
                try
                {
                    cbbGT1.DataSource = dt;
                    cbbGT1.DisplayMember = "GioiTinh";
                    cbbGT1.ValueMember = "GioiTinh";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi load dữ liệu! giới trính \n", ex.ToString());
                }
            }
            
        }

        public void LoadComboBox()
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-GR9NFKL; database=QLBXemay;user id=keiths;password=123456");
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select DISTINCT  * From XeMay", conn);
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            if (metroCheckBox1.Checked ) { 
            try
            {
                cbbHang.DataSource = dt;
                cbbHang.DisplayMember = "HangXe";
                cbbHang.ValueMember = "HangXe";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
            }
            if (metroCheckBox2.Checked)
            {
                try
                {
                    cbbHang.DataSource = dt;
                    cbbHang.DisplayMember = "TenXe";
                    cbbHang.ValueMember = "TenXe";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
                }
            }
            if (metroCheckBox3.Checked)
            {
                try
                {
                    cbbHang.DataSource = dt;
                    cbbHang.DisplayMember = "MauSac";
                    cbbHang.ValueMember = "MauSac";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
                }
            }
        }

        void loadDataToGrv1(string s)
        {
            dgvDSX.AutoGenerateColumns = false;
            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                if (s == "*")
                    dgvDSX.DataSource = Luu.CreateDataTable<XeMay>(db.XeMays.ToList<XeMay>());
                else
                    dgvDSX.DataSource = Luu.CreateDataTable<XeMay>(db.XeMays.SqlQuery("select * from Xemay where Maxe =" + s).ToList());
            }
        }

        void loadDataToGrv(string s)
        {
            dgvXe.AutoGenerateColumns = false;
            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                if (s == "*")
                    dgvXe.DataSource = Luu.CreateDataTable<XeMay>(db.XeMays.ToList<XeMay>());
                else
                    dgvXe.DataSource = Luu.CreateDataTable<XeMay>(db.XeMays.SqlQuery("select * from Xemay where Maxe =" + s).ToList());
            }
        }

        void loadDataToGrv2(string s)
        {
            dgvDSKH.AutoGenerateColumns = false;
            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                if (s == "*")
                    dgvDSKH.DataSource = Luu.CreateDataTable<KhachHang>(db.KhachHangs.ToList<KhachHang>());
                else
                    dgvDSKH.DataSource = Luu.CreateDataTable<KhachHang>(db.KhachHangs.SqlQuery("select * from KhachHang where MaKH =" + s).ToList());
            }
        }
        void loadDataToGrv3(string s)
        {
            dgvTKKH.AutoGenerateColumns = false;
            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                if (s == "*")
                    dgvTKKH.DataSource = Luu.CreateDataTable<KhachHang>(db.KhachHangs.ToList<KhachHang>());
                else
                    dgvTKKH.DataSource = Luu.CreateDataTable<KhachHang>(db.KhachHangs.SqlQuery("select * from KhachHang where MaKH =" + s).ToList());
            }
        }
        public Form1(string text)
        {
            Text = text;
        }

        void lock_unlock(bool kt)
        {
            bntDangnhap.Visible = kt;
            bntDangxuat.Visible = bntQLXM.Visible = btnQLTTKH.Visible = btnDonhang.Visible = !kt;
        }


        void check_uncheck()
        {
            if (!handlingEvent && metroCheckBox1.Checked)
            {
                handlingEvent = true;
                metroCheckBox2.Checked = false;
                metroCheckBox3.Checked = false;
                handlingEvent = false;
            }

            if (!handlingEvent && metroCheckBox2.Checked)
            {
                handlingEvent = true;
                metroCheckBox3.Checked = false;
                metroCheckBox1.Checked = false;
                handlingEvent = false;
            }


            if (!handlingEvent && metroCheckBox3.Checked)
            {
                handlingEvent = true;
                metroCheckBox1.Checked = false;
                metroCheckBox2.Checked = false;
                handlingEvent = false;
            }


        }



        public void nhapxuat()
        {

            bntDangnhap.Visible = true;
            bntDangxuat.Visible = false;
        }
        public void customsize()
        {
            panelTV.Visible = false;
            panelKH.Visible = false;
            panelDH.Visible = false;
            panneldanhsach.Visible = false;
            panelChitietxe.Visible = false;
            panelTKxe.Visible = false;
            panelDSKH.Visible = false;
            panerTKKH.Visible = false;
            logoLon.Visible = true;
        }

        public void showsubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                hidesubmenu();
                Submenu.Visible = true;
            }
            else { Submenu.Visible = false; }

        }

     

        public void hidesubmenu()
        {
            if (panelTV.Visible == true)
            {     
                panelTV.Visible = false;
                logoLon.Visible = false;
            }

            if (panelKH.Visible == true)
            {
                panelKH.Visible = false;
                logoLon.Visible = false;
            }
           

            if (panelDH.Visible == true)
            {
                panelDH.Visible = false;
                logoLon.Visible = false;
            }
          

            if (panneldanhsach.Visible == true)
                panneldanhsach.Visible = false;

            if (panelTKxe.Visible == true)
                panelTKxe.Visible = false;

            if (panelDSKH.Visible == true)
                panelDSKH.Visible = false;

            if (panerTKKH.Visible == true)
                panerTKKH.Visible = false;

            if (panelChitietxe.Visible == true)
                panelChitietxe.Visible = false;

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {         
            this.xeMayTableAdapter.Fill(this.qLBXemayDataSet.XeMay); // dataset dữ liệu của bảng
        }

        private void bntDangnhap_Click(object sender, EventArgs e)
        {
            frmDangnhap f = new frmDangnhap();
            f.ShowDialog();
        }

        private void bntDangxuat_Click(object sender, EventArgs e)
        {
            lock_unlock(!Luu.KT);
        }

        private void panelTV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntQLXM_Click(object sender, EventArgs e)
        { 
          showsubmenu(panelTV);
           logoLon.Visible = true;
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQLTTKH_Click(object sender, EventArgs e)
        {
            showsubmenu(panelKH);
            logoLon.Visible = true;
        }

        private void btnDonhang_Click(object sender, EventArgs e)
        {
            showsubmenu(panelDH);
            logoLon.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            showsubmenu(panelChitietxe);
          
          
        }

        private void htmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
           lock_unlock(Luu.KT);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
           
            
        }

        private void dgvXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvXe.CurrentRow.Index;
            Maxe = int.Parse(dgvXe[7, i].Value.ToString());
            txtHangxe.Text = dgvXe[1, i].Value.ToString();
            txtTenxe.Text = dgvXe[2, i].Value.ToString();
            txtSokhung.Text = dgvXe[3, i].Value.ToString();
            txtSomay.Text = dgvXe[4, i].Value.ToString();
            txtMausac.Text = dgvXe[5, i].Value.ToString();
            txtDongia.Text =(dgvXe[6, i].Value.ToString());
          //  btnThem.Enabled = false;
          //  btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            model.MaXe = Maxe;
            model.HangXe =  txtHangxe.Text;
            model.TenXe = txtTenxe.Text;
            model.SoKhung =txtSokhung.Text;
            model.SoMay =txtSomay.Text;
            model.MauSac = txtMausac.Text;
            model.GiaBan = float.Parse(txtDongia.Text);

            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                db.XeMays.Add(model);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công!", "Thông báo");

                loadDataToGrv("*");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            model.MaXe = Maxe;
            model.HangXe = txtHangxe.Text;
            model.TenXe = txtTenxe.Text;
            model.SoKhung = txtSokhung.Text;
            model.SoMay = txtSomay.Text;
            model.MauSac = txtMausac.Text;
            model.GiaBan = float.Parse(txtDongia.Text);


            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Sửa thành công!", "Thông báo");
                loadDataToGrv("*");
               
            }
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvXe.CurrentRow.Index;
            Maxe = int.Parse(dgvXe[7, i].Value.ToString());
            txtHangxe.Text = dgvXe[1, i].Value.ToString();
            txtTenxe.Text = dgvXe[2, i].Value.ToString();
            txtSokhung.Text = dgvXe[3, i].Value.ToString();
            txtSomay.Text = dgvXe[4, i].Value.ToString();
            txtMausac.Text = dgvXe[5, i].Value.ToString();
            txtDongia.Text = (dgvXe[6, i].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            model.MaXe = Maxe;
            model.HangXe = txtHangxe.Text;
            model.TenXe = txtTenxe.Text;
            model.SoKhung = txtSokhung.Text;
            model.SoMay = txtSomay.Text;
            model.MauSac = txtMausac.Text;
            model.GiaBan = float.Parse(txtDongia.Text);
            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!", "Thông báo");
               
              
                    loadDataToGrv("*");
             
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtHangxe.Text = "";
            txtTenxe.Text = "";
            txtSokhung.Text = "";
            txtSomay.Text = "";
            txtMausac.Text = "";
            txtDongia.Text = "";
            Sua.Enabled = false;
            Xoa.Enabled = false;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            panelChitietxe.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            showsubmenu(panneldanhsach);
             panelChitietxe.Visible = false;
            loadDataToGrv1("*");
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            FrmBaoCaoXe f = new FrmBaoCaoXe();
            f.ShowDialog(); 
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            showsubmenu(panelTKxe);
            panelChitietxe.Visible = false;
            loadDataToGrv1("*");
            metroCheckBox1.Checked = true;
            metroCheckBox2.Checked = false;
            metroCheckBox3.Checked = false;



        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
         if (metroCheckBox1.Checked)
            {
                using( QLBXemayEntities db = new QLBXemayEntities())
                {
                    dgvtimkiem.DataSource = Luu.CreateDataTable<XeMay>(db.XeMays.SqlQuery("select * from Xemay where HangXe like N'%" + cbbHang.Text + "%'").ToList());
                }
            }
            if (metroCheckBox2.Checked)
            {
                using (QLBXemayEntities db = new QLBXemayEntities())
                {
                    dgvtimkiem.DataSource = Luu.CreateDataTable<XeMay>(db.XeMays.SqlQuery("select * from Xemay where TenXe like N'%" + cbbHang.Text + "%'").ToList());
                }
            }
            if (metroCheckBox3.Checked)
            {
                using (QLBXemayEntities db = new QLBXemayEntities())
                {
                    dgvtimkiem.DataSource = Luu.CreateDataTable<XeMay>(db.XeMays.SqlQuery("select * from Xemay where MauSac like N'%" + cbbHang.Text + "%'").ToList());
                }
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bntDangxuat_Click_1(object sender, EventArgs e)
        {
            lock_unlock(!Luu.KT);
        }

        private void bntDangnhap_Click_1(object sender, EventArgs e)
        {
            frmDangnhap f = new frmDangnhap();
            f.ShowDialog();
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            check_uncheck();
            LoadComboBox();
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            check_uncheck();
            LoadComboBox();
        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            check_uncheck();
            LoadComboBox();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            frmThemKhachHang f = new frmThemKhachHang();
            f.ShowDialog(this);
        }

        private void dgvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSKH.CurrentRow.Index;
            MaKH = int.Parse(dgvDSKH[8, i].Value.ToString());
            Hoten1.Text = dgvDSKH[1, i].Value.ToString();
            ngaysinh1.Text = dgvDSKH[2, i].Value.ToString();
            cbbGioitinh.Text = dgvDSKH[3, i].Value.ToString();
            Cancuoc.Text = dgvDSKH[4, i].Value.ToString();
            Diachi.Text = dgvDSKH[5, i].Value.ToString();
           Dienthoai.Text = (dgvDSKH[6, i].Value.ToString());
            Anh.Text = dgvDSKH[7, i].Value.ToString();
           
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            moder_kh.MaKH = MaKH;
            moder_kh.HoTen = Hoten1.Text;
            moder_kh.NgaySinh = ngaysinh1.Value;
            moder_kh.GioiTinh = cbbGioitinh.Text;
            moder_kh.CanCuoc = Cancuoc.Text;
            moder_kh.Anh = Anh.Text;
            moder_kh.DiaChi = Diachi.Text;
            moder_kh.DienThoai = Dienthoai.Text;
            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                db.Entry(moder_kh).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!", "Thông báo");


                loadDataToGrv2("*");

            }
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tệp tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
              //  pictureBox1.Image = new System.Drawing.Bitmap(selectedFilePath);

              
                Anh.Text = selectedFilePath;
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            showsubmenu(panelDSKH);
        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            if (cbGT.Checked)
            {
                using (QLBXemayEntities db = new QLBXemayEntities())
                {
                    CbTen.Checked = false;
                    dgvTKKH.DataSource = Luu.CreateDataTable<KhachHang>(db.KhachHangs.SqlQuery("select * from KhachHang where GioiTinh = N'" + cbbGT1.Text + "'").ToList());
                }
            }
            if (CbTen.Checked)
            {
              
                using (QLBXemayEntities db = new QLBXemayEntities())
                {
                    cbGT.Checked = false;
                    dgvTKKH.DataSource = Luu.CreateDataTable<KhachHang>(db.KhachHangs.SqlQuery("select * from KhachHang where HoTen like N'%" + tbTimten.Text + "%'").ToList());
                }
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            showsubmenu(panerTKKH);
        }

        private void dgvTKKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSKH.CurrentRow.Index;
            MaKH = int.Parse(dgvDSKH[8, i].Value.ToString());
            Hoten1.Text = dgvDSKH[1, i].Value.ToString();
            ngaysinh1.Text = dgvDSKH[2, i].Value.ToString();
            cbbGioitinh.Text = dgvDSKH[3, i].Value.ToString();
            Cancuoc.Text = dgvDSKH[4, i].Value.ToString();
            Diachi.Text = dgvDSKH[5, i].Value.ToString();
            Dienthoai.Text = (dgvDSKH[6, i].Value.ToString());
            Anh.Text = dgvDSKH[7, i].Value.ToString();
        }

        private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            cbbGT1.Visible = true;
            CbTen.Checked = false;
            tbTimten.Visible = false;

        }

        private void CbTen_CheckedChanged(object sender, EventArgs e)
        {
            cbGT.Checked = false;
            cbbGT1.Visible = false;
       
            tbTimten.Visible = true;
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            frmDonHang f = new frmDonHang();
            f.ShowDialog();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            frmHienDon f = new frmHienDon();
            f.ShowDialog();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            dgvXe.Sort(dgvXe.Columns["TenXe"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            dgvXe.Sort(dgvXe.Columns["HangXe"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {

            moder_kh.MaKH = MaKH;
            moder_kh.HoTen = Hoten1.Text;
            moder_kh.NgaySinh = ngaysinh1.Value;
            moder_kh.GioiTinh = cbbGioitinh.Text;
            moder_kh.CanCuoc = Cancuoc.Text;
            moder_kh.Anh = Anh.Text;
            moder_kh.DiaChi = Diachi.Text;
            moder_kh.DienThoai = Dienthoai.Text;

            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                db.Entry(moder_kh).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Sửa thành công!", "Thông báo");
                loadDataToGrv2("*");

            }
        }
    }
}
