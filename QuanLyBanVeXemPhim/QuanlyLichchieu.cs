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
    public partial class QuanlyLichchieu : Form
    {
        public QuanlyLichchieu()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
            reloadData();
        }

        public void reloadData()
        {
            dgv.DataSource = Session.dbContxt.LICHCHIEUx.ToList();
            reloadCbbPhim();
            reloadCbbPhongchieu();
        }

        public void reloadCbbPhim()
        {
            cbbPhim.DataSource = Session.dbContxt.PHIMs.ToList();
            cbbPhim.DisplayMember = "Tenphim"; 
            cbbPhim.ValueMember = "ID";
        }

        public void reloadCbbPhongchieu()
        {
            cbbPhongchieu.DataSource = Session.dbContxt.PHONGCHIEUx.ToList();
            cbbPhongchieu.DisplayMember = "Tenphong";
            cbbPhongchieu.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int phongchieuID = Convert.ToInt32(cbbPhongchieu.SelectedValue);
            int phimID = Convert.ToInt32(cbbPhim.SelectedValue);

            LICHCHIEU lichchieu = new LICHCHIEU();
            lichchieu.PhongchieuID = phongchieuID;
            lichchieu.PhimID = phimID;
            lichchieu.Thoigianchieu = dtp.Value;

            Session.dbContxt.LICHCHIEUx.Add(lichchieu);
            Session.dbContxt.SaveChanges();

            MessageBox.Show("Thêm lịch chiếu thành công");
            reloadData();
        }
    }
}
