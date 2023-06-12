using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanXeMay
{
    public partial class frmDonHang : MetroFramework.Forms.MetroForm
    {
        int MaKH, Maxe;
        ChiTietHoaDon model = new ChiTietHoaDon();
        public frmDonHang()
        {
            InitializeComponent();
            loadDataToGrv1("*");
        }
        void loadDataToGrv1(string s)
        {
            dgvKh.AutoGenerateColumns = false;
            dgvHang.AutoGenerateColumns = false;
            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                if (s == "*")
                {   
                    dgvKh.DataSource = Luu.CreateDataTable<KhachHang>(db.KhachHangs.ToList<KhachHang>());
                    dgvHang.DataSource = Luu.CreateDataTable<XeMay>(db.XeMays.ToList<XeMay>());
                }

                else { 
                    dgvKh.DataSource = Luu.CreateDataTable<KhachHang>(db.KhachHangs.SqlQuery("select * from KhachHang where MaKh =" + s).ToList());
           
                    dgvHang.DataSource = Luu.CreateDataTable<XeMay>(db.XeMays.SqlQuery("select * from KhachHang where Maxe =" + s).ToList());
            }
            }

        
    }



        private void frmDonHang_Load(object sender, EventArgs e)
        {


        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvKh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i = dgvKh.CurrentRow.Index;
            MaKH = int.Parse(dgvKh[4, i].Value.ToString());
            txtTen.Text = dgvKh[1, i].Value.ToString();
            txtCancuoc.Text = dgvKh[2, i].Value.ToString();
            txtSdt.Text = dgvKh[3, i].Value.ToString();
            txtMaKH.Text = MaKH.ToString();

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            model.MaKH = int.Parse(txtMaKH.Text);
            model.HoTen = txtTen.Text;
            model.TenXe = txtTenxe.Text;
            model.SoKhung = txtSoKhung.Text;
            model.SoMay = txtSoMay.Text;
            model.MauSac = txtMausac.Text;
            model.DonGia = float.Parse(txtGiaban.Text);
            model.CanCuoc = txtCancuoc.Text;
            model.HangXe = txtHangXe.Text;
            model.DienThoai = txtSdt.Text;
            model.SoLuong = int.Parse("1");
           


            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                db.ChiTietHoaDons.Add(model);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công!", "Thông báo");

               
            }
        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvHang.CurrentRow.Index;

          
            Maxe = int.Parse(dgvHang[7, i].Value.ToString());
            txtHangXe.Text = dgvHang[1, i].Value.ToString();
            txtTenxe.Text = dgvHang[2, i].Value.ToString();
            txtSoKhung.Text = dgvHang[3, i].Value.ToString();
            txtSoMay.Text = dgvHang[4, i].Value.ToString();
            txtMausac.Text = dgvHang[5, i].Value.ToString(); ;
            txtGiaban.Text = dgvHang[6, i].Value.ToString();
        }
    }
}

