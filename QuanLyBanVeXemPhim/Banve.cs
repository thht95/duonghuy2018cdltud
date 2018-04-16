using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace QuanLyBanVeXemPhim
{
    public partial class Banve : Form
    {
        public Banve()
        {
            InitializeComponent();
            loadCBB();
        }
        static string constr = "Data Source=ADMIN-PC;Initial Catalog=QLBVXP;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constr);
        int maphong;
        int giatien;
        
        private void loadCBB()
        {
            var list = Session.dbContxt.PHIMs.ToList();

            cbbPhim.DataSource = list;
            cbbPhim.DisplayMember = "Tenphim";
            cbbPhim.ValueMember = "ID";
            
        }
        private void loadLB(int maphong)
        {
            //conn.Open();
            //string sql = "select id,vitri from ghe where phongchieuid=" + maphong;
            //SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //conn.Close();
            
            var list = Session.dbContxt.GHEs.Where(x => x.PhongChieuID == maphong).ToList();

            lbGhe.DisplayMember = "vitri";
            lbGhe.ValueMember = "ID";
            lbGhe.DataSource = list;
        }
        private void giochieu(int maphim)
        {
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();
            //string sql = "select id,thoigianchieu from lichchieu where phimid=" + maphim + " and thoigianchieu>=getdate()";
            //SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //conn.Close();
            //cbbGio.DisplayMember = "thoigianchieu";
            //cbbGio.ValueMember = "ID";
            //cbbGio.DataSource = dt;

            var list = Session.dbContxt.LICHCHIEUx.Where(x => x.PhimID == maphim).ToList();
            cbbGio.DisplayMember = "thoigianchieu";
            cbbGio.ValueMember = "ID";
            cbbGio.DataSource = list;
            
        }
        private void phongchieu(int lichchieu)
        {
            //string sql = "select phongchieuid from lichchieu where id=" + lichchieu;
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //string s = cmd.ExecuteScalar().ToString();
            //string sql2 = "select tenphong from phongchieu where id=" + s;
            //SqlCommand cmd2 = new SqlCommand(sql2, conn);

            //lblPhongchieu.Text = cmd2.ExecuteScalar().ToString();

            //string sql3 = "select id from phongchieu where id=" + s;
            //SqlCommand cmd3 = new SqlCommand(sql3, conn);

            //maphong = cmd3.ExecuteScalar().ToString();

            //string sql4 = "select giave from lichchieu where id=" + lichchieu;
            //SqlCommand cmd4 = new SqlCommand(sql4, conn);

            //giatien = (int)cmd4.ExecuteScalar();

            var objLichchieu = Session.dbContxt.LICHCHIEUx.Where(x => x.ID == lichchieu).FirstOrDefault();
            var objPhongChieu = objLichchieu.PHONGCHIEU;
            lblPhongchieu.Text = objPhongChieu.Tenphong;
            maphong = objPhongChieu.ID;
            giatien = Convert.ToInt32(objLichchieu.Giave);
        }
        private bool checkLB(string s)
        {
            for (int i = 0; i < lbChon.Items.Count; i++)
            {
                if (s == lbChon.Items[i].ToString())
                    return false;
            }
            return true;
        }
        private void Banve_Load(object sender, EventArgs e)
        {
            
        }

        private void cbbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cbbPhim.Text!="<none>")
            //{
            //    giochieu(Convert.ToInt32(cbbPhim.SelectedValue));
            //    loadLB(maphong);
            //}
            
            var x = cbbPhim.SelectedValue;
            giochieu(Convert.ToInt32(x));
        }
        private int tinhgiave()
        {
            int gia = 0;
            if (lbChon.Items.Count == 0)
                gia = 0;
            else
            {
                gia = giatien * lbChon.Items.Count;
            }
            return gia;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbbGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lichchieuID = Convert.ToInt32(cbbGio.SelectedValue);
            phongchieu(lichchieuID);
            loadLB(maphong);
            lblLichchieuID.Text = lichchieuID.ToString();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (checkLB(lbGhe.Text))
                lbChon.Items.Add(lbGhe.Text);
            lblTien.Text = "" + tinhgiave();
        }

        private void btBo_Click(object sender, EventArgs e)
        {
            if (lbChon.Items.Count > 0)
                lbChon.Items.Remove(lbChon.SelectedItem);
            lblTien.Text = "" + tinhgiave();
        }

        private void btnChonhet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbGhe.Items.Count; i++)
            {
                lbGhe.SelectedIndex = i;
                string a = lbGhe.Text;
                if (checkLB(a))
                    lbChon.Items.Add(a);
            }
            lblTien.Text = "" + tinhgiave();
        }
        //private int mahoadon()
        //{
        //    int ma = 0;
        //    conn.Open();
        //    string sql1 = "select max(id) from hoadon";
        //    SqlCommand cmd1 = new SqlCommand(sql1, conn);
        //    ma = (int)cmd1.ExecuteScalar();
        //    conn.Close();
        //    return ma;
        //}
        private string laymaghe(string vitrighe)
        {
            string s = "";
            conn.Open();
            string sql = "select id from ghe where vitri='" + vitrighe + "' and phongchieuid=" + maphong;
            SqlCommand cmd = new SqlCommand(sql, conn);
            s = cmd.ExecuteScalar().ToString();
            conn.Close();
            return s;
        }
        private void btnBohet_Click(object sender, EventArgs e)
        {
            lbChon.Items.Clear();
            lblTien.Text = "" + tinhgiave();
        }
        private void themhoadon()
        {
            if (lbChon.Items.Count != 0)
            {
                HOADON objHoadon = new HOADON();

                objHoadon.NhanvienID = Session.MaNhanvien;
                objHoadon.Soluongve = lbChon.Items.Count;
                objHoadon.Tongtien = tinhgiave();

                Session.dbContxt.HOADONs.Add(objHoadon);
                Session.dbContxt.SaveChanges();

                foreach (var obj in lbChon.Items)
                {
                    VE objVe = new VE();

                    objVe.HoadonID = objHoadon.ID;
                    objVe.LichchieuID = Convert.ToInt32(lblLichchieuID.Text);

                    var objGhe = Session.dbContxt.GHEs.Where(x => x.PhongChieuID == maphong).FirstOrDefault();

                    //objVe.GheID = ;

                    Session.dbContxt.GHEs.Add(objGhe);
                    Session.dbContxt.SaveChanges();
                }
                //conn.Open();
                //string sql = "insert into hoadon values(" + Dangnhap.manv + "," + lbChon.Items.Count + "," + tinhgiave() + ")";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                //conn.Close();
                //int ma = mahoadon();
                //for(int i=0;i< lbChon.Items.Count; i++)
                //{
                //    lbChon.SelectedIndex = i;
                //    string x = laymaghe(lbChon.Text);
                //    conn.Open();
                //    string sql1 = "insert into ve values(" + cbbGio.SelectedValue.ToString() + "," + x + "," + mahoadon() + ")";
                //    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                //    cmd1.ExecuteNonQuery();
                //    string sql2 = "update ghe set tinhtrang=1";
                //    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                //    cmd2.ExecuteNonQuery();
                //    conn.Close();
                //}
            }
            else
                MessageBox.Show("Mời chọn ghế", "Thông báo");
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            themhoadon();
            //if (cbbPhim.Text != "<none>")
            //    themhoadon();
            //else
            //    MessageBox.Show("Hãy chọn phim!", "Thông báo!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //cbbPhim.Text = "<none>";
            //cbbGio.DataSource = "";
            //lblPhongchieu.Text = "";
            //lblTien.Text = "";
            //lbChon.Items.Clear();
            //lbGhe.Items.Clear();
        }
    }
}
