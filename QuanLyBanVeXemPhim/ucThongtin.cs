using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace QuanLyBanVeXemPhim
{
    public partial class ucThongtin : UserControl
    {
        public ucThongtin()
        {
            InitializeComponent();
        }   

        private void ucThongtin_Load(object sender, EventArgs e)
        {
            NHANVIEN nhanvien = Session.dbContxt.NHANVIENs.Where(x => x.ID == Session.MaNhanvien).FirstOrDefault();
            
            txtDiachi.Text = nhanvien.Diachi;
            cbbIsAdmin.SelectedItem = (bool) nhanvien.IsAdmin ? "Yes" : "No";
            cbbIsAdmin.Enabled = (bool)nhanvien.IsAdmin;
            dtpNgaysinh.Value = Convert.ToDateTime(nhanvien.Ngaysinh);
            txtTen.Text = nhanvien.Hoten;
            txtSDT.Text = nhanvien.SDT;
            lblMaNV.Text = Session.MaNhanvien.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblMaNV.Text);

            NHANVIEN nhanvien = Session.dbContxt.NHANVIENs.Where(x => x.ID == id).FirstOrDefault();

            nhanvien.IsAdmin = Convert.ToBoolean(cbbIsAdmin.SelectedIndex);
            nhanvien.Diachi = txtDiachi.Text;
            nhanvien.Ngaysinh = dtpNgaysinh.Value;
            nhanvien.Hoten = txtTen.Text;
            nhanvien.SDT = txtSDT.Text;

            Session.dbContxt.SaveChanges();
            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
