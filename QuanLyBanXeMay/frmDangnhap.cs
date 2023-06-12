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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBanXeMay
{
    public partial class frmDangnhap : MetroFramework.Forms.MetroForm
    {
        public frmDangnhap()
        {
            InitializeComponent();

          
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBoxpassword.PasswordChar == '*')
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                textBoxpassword.PasswordChar = '\0';
            }
            else if (textBoxpassword.PasswordChar == '\0')
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                textBoxpassword.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBoxpassword.PasswordChar == '*')
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                textBoxpassword.PasswordChar = '\0';
            }
            else if (textBoxpassword.PasswordChar == '\0')
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                textBoxpassword.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            using (QLBXemayEntities db = new QLBXemayEntities())
            {
                string s = "Select * from Nhanvien where " +
                    "Tendangnhap ='" + textBoxUsername.Text + "' and Matkhau = '" + textBoxpassword.Text + "'";

                var list = db.NhanViens.SqlQuery(s).ToList();
                if (list.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông Báo");
                    Luu.KT = !Luu.KT;
                    Close();

                }

                else
                    MessageBox.Show("Username hoąc Password không đúng!", "Thông Báo");


            }


        }
    }
}

