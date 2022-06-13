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
    public partial class frmThongTinMonAn : Form
    {
        private string connStr;

        private QuanLyNhomMonAn QL_NhomMonAn;
        public frmThongTinMonAn()
        {
            InitializeComponent();
        }

        public frmThongTinMonAn(QuanLyNhomMonAn QL_NhomMonAn)
        {
            InitializeComponent();
            connStr = ConfigurationManager.ConnectionStrings["QLMonAn"].ConnectionString;
            this.QL_NhomMonAn = QL_NhomMonAn;
            hienThiNhomMonAn(QL_NhomMonAn.layDS());
        }

        public frmThongTinMonAn(QuanLyNhomMonAn QL_NhomMonAn, MonAn i)
        {
            InitializeComponent();
            connStr = ConfigurationManager.ConnectionStrings["QLMonAn"].ConnectionString;
            this.QL_NhomMonAn = QL_NhomMonAn;
            hienThiNhomMonAn(QL_NhomMonAn.layDS());

            // lấy thông tin món ăn truyền vào các Controls
            bindingThongTinMonAn(i);
        }

        private void hienThiNhomMonAn(List<NhomMonAn> ds)
        {
            cbNhomMonAn.DataSource = ds;
            cbNhomMonAn.DisplayMember = "TenNhom";
            cbNhomMonAn.ValueMember = "MaNhom";
        }

        private void bindingThongTinMonAn(MonAn i)
        {
            txtMaMonAn.Text = i.maMonAn.ToString();
            txtTenMonAn.Text = i.tenMonAn;
            txtDVT.Text = i.dvt;
            nudDonGia.Value = Convert.ToDecimal(i.donGia);
            cbNhomMonAn.SelectedValue = i.nhom;
        } 

        private void suaMonAn(MonAn i)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText =
                "UPDATE MonAn SET " +
                "TenMonAn=" + "N\'" + i.tenMonAn + "\'" + "," + 
                "DonViTinh=" + "N\'" + i.dvt + "\'" + "," + 
                "DonGia=" + i.donGia + "," + 
                "Nhom=" + i.nhom + " " + 
                "WHERE MaMonAn=" + i.maMonAn;
                
            conn.Open();

            int res = cmd.ExecuteNonQuery();
            if (res <= 0)
            {
                MessageBox.Show("Lỗi khi sửa thông tin món ăn");
            }

            conn.Close();
        }

        private void themMonAn(MonAn i)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = 
                "INSERT INTO MonAn(TenMonAn, DonViTinh, DonGia, Nhom) VALUES " +
                "(" +
                "N\'" + i.tenMonAn + "\'" + "," +
                "N\'" + i.dvt + "\'" + "," +
                i.donGia + "," +
                i.nhom +
                ")";
            conn.Open();

            int res = cmd.ExecuteNonQuery();
            if (res <= 0)
            {
                MessageBox.Show("Lỗi khi thêm món ăn");
            }

            conn.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // tạo đối tượng MonAn từ các thông tin trên Controls
            MonAn i = new MonAn()
            {
                tenMonAn = txtTenMonAn.Text,
                dvt = txtDVT.Text,
                donGia = int.Parse(nudDonGia.Value.ToString()),
                nhom = int.Parse(cbNhomMonAn.SelectedValue.ToString())
            };

            // nếu txtMaMonAn có giá trị thì sửa thông tin món ăn
            if (!string.IsNullOrEmpty(txtMaMonAn.Text))
            {
                i.maMonAn = int.Parse(txtMaMonAn.Text);
                suaMonAn(i);
            }
            // ngược lại thêm món ăn
            else
            {
                themMonAn(i);
            }
            // đóng form
            Close();
        }
    }
}
