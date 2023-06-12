using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyBanXeMay
{
   
    public partial class frmThemKhachHang : MetroFramework.Forms.MetroForm
    {
        KhachHang model = new KhachHang();
        int MaKh;
        string sss;
        public frmThemKhachHang()
        {
            InitializeComponent();
        }
        public void ThuVien(string Filename)
        {
            InitializeComponent();
            pictureBox1.Image = System.Drawing.Image.FromFile(Filename);
            //Hiển thị tên ảnh lên title bar
            Text = Filename.Substring(Filename.LastIndexOf('\\') + 1); //Hai dấu \\ để hiển luôn cả tên ảnh trên title bar

        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {

        }
        
        private void metroButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tệp tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                pictureBox1.Image = new System.Drawing.Bitmap(selectedFilePath);

                sss = selectedFilePath;
               //metroLabel1.Text = selectedFilePath;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            model.MaKH = MaKh;
            model.HoTen = hoten.Text;
          //  model.Email = .Text;
            model.NgaySinh = metroDateTime1.Value.Date;
            model.GioiTinh = metroComboBox1.Text;
            model.DienThoai = Dienthoai.Text;
            model.DiaChi = Diachi.Text;
            model.CanCuoc = Cancuoc.Text;
            model.Anh = sss;
            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                db.KhachHangs.Add(model);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công!", "Thông báo");

              //  loadDataToGrv("*");
            }
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
