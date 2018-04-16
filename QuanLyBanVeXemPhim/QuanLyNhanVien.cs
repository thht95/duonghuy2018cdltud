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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
            reloadData();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }

        public void reloadData()
        {
            dgv.DataSource = Session.dbContxt.NHANVIENs.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var list = Session.dbContxt.NHANVIENs.Select(x => x.SDT).ToList();
                if (list.Contains(txtSdt.Text))
                {
                    MessageBox.Show("Đã có số điện thoại này");
                }
                else
                {
                    NHANVIEN nhanvien = new NHANVIEN();

                    nhanvien.UserName = txtUsername.Text;
                    nhanvien.Hoten = txtHOten.Text;
                    nhanvien.IsAdmin = ckbIsAdmin.Checked;
                    nhanvien.Ngaysinh = dtpNgaysinh.Value;
                    nhanvien.Diachi = txtDiachi.Text;
                    nhanvien.SDT = txtSdt.Text;
                    nhanvien.Password = "1";
                    nhanvien.Thoigiandangnhapcuoi = DateTime.Now;

                    Session.dbContxt.NHANVIENs.Add(nhanvien);
                    Session.dbContxt.SaveChanges();

                    MessageBox.Show("Thêm thành công");

                    reloadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra", ex.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "")
            {
                try
                {
                    int manhanvien = Convert.ToInt32(lblID.Text);

                    NHANVIEN nv = Session.dbContxt.NHANVIENs.Where(x => x.ID == manhanvien).FirstOrDefault();

                    Session.dbContxt.NHANVIENs.Remove(nv);
                    Session.dbContxt.SaveChanges();

                    MessageBox.Show("Xóa thành công");
                    reloadData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra", ex.ToString());
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "")
            {
                int manhanvien = Convert.ToInt32(lblID.Text);
                NHANVIEN nv = Session.dbContxt.NHANVIENs.Where(x => x.ID == manhanvien).FirstOrDefault();
                if (nv != null)
                {
                    nv.Password = "1";
                    Session.dbContxt.SaveChanges();
                    MessageBox.Show("Reset password thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "")
            {
                try
                {
                    int manhanvien = Convert.ToInt32(lblID.Text);
                    NHANVIEN nv = Session.dbContxt.NHANVIENs.Where(x => x.ID == manhanvien).FirstOrDefault();

                    if (nv.SDT != txtSdt.Text)
                    {
                        var list = Session.dbContxt.NHANVIENs.Select(x => x.SDT).ToList();
                        if (list.Contains(txtSdt.Text))
                        {
                            MessageBox.Show("Đã có số điện thoại này");
                        }
                        else
                        {
                            nv.Hoten = txtHOten.Text;
                            nv.UserName = txtUsername.Text;
                            nv.Ngaysinh = dtpNgaysinh.Value;
                            nv.SDT = txtSdt.Text;
                            nv.IsAdmin = ckbIsAdmin.Checked;

                            Session.dbContxt.SaveChanges();
                            reloadData();
                            MessageBox.Show("Sửa thành công");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                lblID.Text = dgv[0, rowIndex].Value.ToString();
                txtHOten.Text = dgv[1, rowIndex].Value.ToString();
                txtUsername.Text = dgv[2, rowIndex].Value.ToString();
                dtpNgaysinh.Value = Convert.ToDateTime(dgv[3, rowIndex].Value);
                txtSdt.Text = Convert.ToString(dgv[5, rowIndex].Value);
                txtDiachi.Text = dgv[6, rowIndex].Value.ToString();
                ckbIsAdmin.Checked = Convert.ToBoolean(dgv[7, rowIndex].Value);
                lblLastLogin.Text = Convert.ToString(dgv[8, rowIndex].Value);
            }
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (rowIndex >= 0 && colIndex == 4)
            {
                DateTime dt = Convert.ToDateTime(dgv[3, rowIndex].Value);
                e.Value = DateTime.Now.Year - dt.Year;
            }
        }
    }
}
