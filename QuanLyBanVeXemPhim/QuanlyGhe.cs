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
    public partial class QuanlyGhe : Form
    {
        public QuanlyGhe()
        {
            InitializeComponent();

            dgvGhe.AutoGenerateColumns = false;
            reloadData();
            
        }

        public void reloadData()
        {
            dgvGhe.DataSource = Session.dbContxt.GHEs.ToList();
            cbbPhongchieu.DataSource = Session.dbContxt.PHONGCHIEUx.ToList();
            cbbPhongchieu.ValueMember = "ID";
            cbbPhongchieu.DisplayMember = "Tenphong";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhongchieu = Convert.ToInt32(cbbPhongchieu.SelectedValue);
                GHE ghe = new GHE();

                ghe.Vitri = txtVitri.Text;
                ghe.Loaighe = cbbLoaighe.SelectedIndex;
                ghe.Tinhtrang = false;
                ghe.PhongChieuID = maPhongchieu;

                Session.dbContxt.GHEs.Add(ghe);
                Session.dbContxt.PHONGCHIEUx.Where(x => x.ID == maPhongchieu).FirstOrDefault().Size += 1;

                Session.dbContxt.SaveChanges();

                MessageBox.Show("Thêm thành công");

                reloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra", ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblID.Text);
                int maPhongchieu = Convert.ToInt32(cbbPhongchieu.SelectedValue);

                GHE ghe = Session.dbContxt.GHEs.Where(x => x.ID == id).FirstOrDefault();

                int oldMaPhongchieu = Convert.ToInt32(ghe.PhongChieuID);

                ghe.Loaighe = cbbLoaighe.SelectedIndex;
                ghe.Vitri = txtVitri.Text;
                ghe.PhongChieuID = maPhongchieu;

                if (maPhongchieu != oldMaPhongchieu)
                {
                    Session.dbContxt.PHONGCHIEUx.Where(x => x.ID == maPhongchieu).FirstOrDefault().Size += 1;
                    Session.dbContxt.PHONGCHIEUx.Where(x => x.ID == oldMaPhongchieu).FirstOrDefault().Size -= 1;
                }

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
                GHE ghe = Session.dbContxt.GHEs.Where(x => x.ID == id).FirstOrDefault();
                int maphongchieu = Convert.ToInt32(ghe.PhongChieuID);
                
                Session.dbContxt.PHONGCHIEUx.Where(x => x.ID == maphongchieu).FirstOrDefault().Size -= 1;
                Session.dbContxt.GHEs.Remove(ghe);

                MessageBox.Show("Xóa thành công");
                reloadData();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại. Có lỗi xảy ra", ex.ToString());
            }
        }

        private void dgvGhe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
           
            lblID.Text = dgvGhe[0, rowIndex].Value.ToString();
            txtVitri.Text = dgvGhe[1, rowIndex].Value.ToString();
            cbbPhongchieu.SelectedValue = dgvGhe[2, rowIndex].Value;
            cbbLoaighe.SelectedIndex = Convert.ToInt32(dgvGhe[3, rowIndex].Value);
            lblStt.Text = Convert.ToBoolean(dgvGhe[4, rowIndex].Value) ? "Đã bị chiếm" : "Chưa bị chiếm";
        }

        private void dgvGhe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            List<PHONGCHIEU> list = Session.dbContxt.PHONGCHIEUx.ToList();

            if( e.ColumnIndex == 2)
            {
                e.Value = list.Where(x => x.ID == Convert.ToInt32(e.Value)).FirstOrDefault().Tenphong;
            }
            else if (e.ColumnIndex == 3)
            {
                e.Value = cbbLoaighe.Items[Convert.ToInt32(e.Value)];
            }
            else if (e.ColumnIndex == 4)
            {
                e.Value = Convert.ToBoolean(e.Value)? "Đã bị chiếm" : "Chưa bị chiếm";
            }
            
        }
    }
}
