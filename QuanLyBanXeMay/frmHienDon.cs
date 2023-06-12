using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanXeMay
{
    public partial class frmHienDon : MetroFramework.Forms.MetroForm
    {
        public frmHienDon()
        {
            InitializeComponent();
            loadDataToGrv1("*");

        }
        void loadDataToGrv1(string s)
        {
            dgvDh.AutoGenerateColumns = false;
           
            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                if (s == "*")
                {
                    dgvDh.DataSource = Luu.CreateDataTable<ChiTietHoaDon>(db.ChiTietHoaDons.ToList<ChiTietHoaDon>());
                   
                }

                else
                {
                    dgvDh.DataSource = Luu.CreateDataTable<ChiTietHoaDon>(db.ChiTietHoaDons.SqlQuery("select * from ChiTietHoaDon where MaHD =" + s).ToList());

                    
                }
            }


        }
        private void frmHienDon_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FrmKHDD f = new FrmKHDD();
            f.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            frmHoaDonKH1 f = new frmHoaDonKH1();
            f.ShowDialog();
        }
    }
}
