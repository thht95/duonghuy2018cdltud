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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
            quanLyNhanVien.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Session.IsAdmin == true)
                adminToolStripMenuItem.Visible = true;
            else
                adminToolStripMenuItem.Visible = false;

            tàiKhoảnToolStripMenuItem.Text = "Chào " + Session.TenNhanvien;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin thongtin = new ThongTin();
            thongtin.Show();
        }

        private void chọnPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhim quanLyPhim = new QuanLyPhim();
            quanLyPhim.Show();
        }

        private void quảnLýPhòngChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlyPhongchieu quanlyPhongchieu = new QuanlyPhongchieu();
            quanlyPhongchieu.Show();
        }

        private void cậpNhậtGhếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlyGhe quanlyGhe = new QuanlyGhe();
            quanlyGhe.Show();
        }

        private void quảnLýGhếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlyGhe quanlyGhe = new QuanlyGhe();
            quanlyGhe.Show();
        }

        private void cậpNhậtThôngTinLịchChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlyLichchieu qlLichchieu = new QuanlyLichchieu();
            qlLichchieu.Show();
        }

        private void bánVéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Banve form = new Banve();
            form.Show();
        }
    }
}
