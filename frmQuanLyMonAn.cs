using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BT_QLMonAn
{
    public partial class frmQuanLyMonAn : Form
    {
        private string connStr;

        private QuanLyNhomMonAn QL_NhomMonAn;
        private QuanLyMonAn QL_MonAn;

        public frmQuanLyMonAn()
        {
            InitializeComponent();
            init();
            layDuLieuTuDB();
            hienThi();
        }

        private void init()
        {
            connStr = ConfigurationManager.ConnectionStrings["QLMonAn"].ConnectionString;
            QL_NhomMonAn = new QuanLyNhomMonAn();
            QL_MonAn = new QuanLyMonAn();
        }

        private void hienThi()
        {
            hienThiNhomMonAn(QL_NhomMonAn.layDS());
            hienThiMonAn(QL_MonAn.layDS());
        }

        private void layDuLieuTuDB()
        {
            layDuLieuNhomMonAn();
            layDuLieuMonAn();
        }

        private void layDuLieuNhomMonAn()
        {
            QL_NhomMonAn.clear();

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM NhomMonAn";
            conn.Open();

            SqlDataReader records = cmd.ExecuteReader();
            while (records.Read())
            {
                NhomMonAn i = new NhomMonAn()
                {
                    maNhom = int.Parse(records["MaNhom"].ToString()),
                    tenNhom = records["TenNhom"].ToString()
                };

                QL_NhomMonAn.them(i);
            }

            conn.Close();
        }

        private void hienThiNhomMonAn(List<NhomMonAn> ds)
        {
            cbNhomMonAn.DataSource = ds;
            cbNhomMonAn.DisplayMember = "TenNhom";
            cbNhomMonAn.ValueMember = "MaNhom";
        }

        private void layDuLieuMonAn()
        {
            QL_MonAn.clear();

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM MonAn";
            conn.Open();

            SqlDataReader records = cmd.ExecuteReader();
            while (records.Read())
            {
                MonAn i = new MonAn()
                {
                    maMonAn = int.Parse(records["MaMonAn"].ToString()),
                    tenMonAn = records["TenMonAn"].ToString(),
                    dvt = records["DonViTinh"].ToString(),
                    donGia = int.Parse(records["DonGia"].ToString()),
                    nhom = int.Parse(records["Nhom"].ToString())
                };

                QL_MonAn.them(i);
            }

            conn.Close();
        }

        private string layTenNhom(int maNhom)
        {
            var ds = QL_NhomMonAn.layDS();
            return ds.Find(i => i.maNhom == maNhom).tenNhom;
        }

        private void hienThiMonAn(List<MonAn> ds)
        {
            lvMonAn.Items.Clear();
            foreach (MonAn monAn in ds)
            {
                string[] info = {
                    monAn.maMonAn.ToString(),
                    monAn.tenMonAn,
                    monAn.dvt,
                    monAn.donGia.ToString(),
                    layTenNhom(monAn.nhom)
                };
                ListViewItem item = new ListViewItem(info);
                lvMonAn.Items.Add(item);
            }
        }

        private void refreshMonAn()
        {
            layDuLieuMonAn();
            hienThiMonAn(QL_MonAn.layDS());
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TextBox owner = sender as TextBox;
            string ten = owner.Text;
            if (string.IsNullOrEmpty(ten) || string.IsNullOrWhiteSpace(ten))
            {
                hienThiMonAn(QL_MonAn.layDS());
            }    
            List<MonAn> founds = QL_MonAn.timMonAnTheoTen(ten);
            hienThiMonAn(founds);
        }

        private void cbNhomMonAn_SelectedValueChanged(object sender, EventArgs e)
        {
            /*ComboBox owner = sender as ComboBox;
            int maNhom = (owner.SelectedItem as NhomMonAn).maNhom;
            List<MonAn> founds = QL_MonAn.locMonAnTheoNhom(maNhom);
            hienThiMonAn(founds);*/
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            frmThongTinMonAn form = new frmThongTinMonAn(QL_NhomMonAn);
            // hiển thị form thông tin món ăn
            form.Show();
            // xử lý khi đóng form
            form.FormClosed += (s, args) => {
                refreshMonAn(); /* load lại danh sách món ăn */
            };
        }

        private void lvMonAn_DoubleClick(object sender, EventArgs e)
        {
            ListView owner = sender as ListView;
            // nếu chọn item trong ListView
            if (owner.SelectedItems[0] != null) 
            {
                int maMonAn = int.Parse(owner.SelectedItems[0].Text);
                MonAn found = QL_MonAn.timMonAnTheoMa(maMonAn);
                frmThongTinMonAn form = new frmThongTinMonAn(QL_NhomMonAn, found);
                form.Show();
                form.FormClosed += (s, args) => { refreshMonAn(); };
            }
        }
    }
}
