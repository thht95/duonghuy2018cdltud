using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXemPhim
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        public static string manv;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            NHANVIEN nhanvien = Session.dbContxt.NHANVIENs.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();

            if (nhanvien != null)
            {
                Session.IsAdmin = nhanvien.IsAdmin;
                Session.TenNhanvien = nhanvien.Hoten;
                Session.MaNhanvien = nhanvien.ID;

                nhanvien.Thoigiandangnhapcuoi = DateTime.Now;
                Session.dbContxt.SaveChanges();

                MessageBox.Show("Đăng Nhâp Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                manv = nhanvien.ID.ToString();
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
