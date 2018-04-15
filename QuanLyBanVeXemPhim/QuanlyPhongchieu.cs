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
    public partial class QuanlyPhongchieu : Form
    {
        public QuanlyPhongchieu()
        {
            InitializeComponent();

            dgvPhongchieu.AutoGenerateColumns = false;
            dgvPhongchieu.DataSource = Session.dbContxt.PHONGCHIEUx.ToList();
        }

        public void reloadData()
        {
            dgvPhongchieu.DataSource = Session.dbContxt.PHONGCHIEUx.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                PHONGCHIEU phongchieu = new PHONGCHIEU();

                phongchieu.Tenphong = txtTenphong.Text;
                phongchieu.Size = 0;

                Session.dbContxt.PHONGCHIEUx.Add(phongchieu);
                Session.dbContxt.SaveChanges();

                MessageBox.Show("Thêm thành công");

                reloadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra", ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblID.Text);
                PHONGCHIEU phongchieu = Session.dbContxt.PHONGCHIEUx.Where(x => x.ID == id).FirstOrDefault();

                phongchieu.Tenphong = txtTenphong.Text;

                Session.dbContxt.SaveChanges();

                MessageBox.Show("Sửa thành công");
                reloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại. Có lỗi xảy ra", ex.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblID.Text);
                PHONGCHIEU phongchieu = Session.dbContxt.PHONGCHIEUx.Where(x => x.ID == id).FirstOrDefault();

                Session.dbContxt.PHONGCHIEUx.Remove(phongchieu);

                MessageBox.Show("Xóa thành công");
                reloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại. Có lỗi xảy ra", ex.ToString());
            }
        }

        private void dgvPhongchieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            lblID.Text = dgvPhongchieu[0, rowIndex].Value.ToString();
            txtTenphong.Text = dgvPhongchieu[1, rowIndex].Value.ToString();
            lblSoghe.Text = dgvPhongchieu[2, rowIndex].Value.ToString();
        }
    }
}
