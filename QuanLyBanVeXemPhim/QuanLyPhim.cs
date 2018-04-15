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
    public partial class QuanLyPhim : Form
    {
        public QuanLyPhim()
        {
            InitializeComponent();
            dgvPhim.AutoGenerateColumns = false;
            reloadData();
        }

        public void reloadData()
        {
           dgvPhim.DataSource = Session.dbContxt.PHIMs.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                PHIM phim = new PHIM();

                phim.Tenphim = txtTenphim.Text;
                phim.Theloai = txtTheloai.Text;
                phim.Thongtin = txtThongtin.Text;
                phim.Noidung = txtNoidung.Text;

                Session.dbContxt.PHIMs.Add(phim);
                Session.dbContxt.SaveChanges();
                
                MessageBox.Show("Thêm thành công");
                reloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi đã xảy ra", ex.ToString());
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32( lblID.Text);
                PHIM phim = Session.dbContxt.PHIMs.Where(x => x.ID == id).FirstOrDefault();

                phim.Tenphim = txtTenphim.Text;
                phim.Theloai = txtTheloai.Text;
                phim.Thongtin = txtThongtin.Text;
                phim.Noidung = txtNoidung.Text;

                Session.dbContxt.SaveChanges();

                MessageBox.Show("Sửa thành công");
                reloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi đã xảy ra", ex.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblID.Text);
                PHIM phim = Session.dbContxt.PHIMs.Where(x => x.ID == id).FirstOrDefault();

                Session.dbContxt.PHIMs.Remove(phim);
                Session.dbContxt.SaveChanges();

                MessageBox.Show("Xóa thành công");
                reloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi đã xảy ra", ex.ToString());
            }
        }

        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            lblID.Text = dgvPhim[0, rowIndex].Value.ToString();
            txtTenphim.Text = dgvPhim[1, rowIndex].Value.ToString();
            txtThongtin.Text = dgvPhim[2, rowIndex].Value.ToString();
            txtTheloai.Text = dgvPhim[3, rowIndex].Value.ToString();
            txtNoidung.Text = dgvPhim[4, rowIndex].Value.ToString();
        }
    }
}
