using QuanLyBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLyRapPhim
{
    public partial class FrmRap : Form
    {
        public FrmRap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRap_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            txtMaRap.Enabled = true;
            btnLuu.Enabled = false;
            LoadDataToGridView();
            DAO.CloseConnection();
        }
        private void LoadDataToGridView()
        {
            string sql = "select * from tblRap";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridViewRap.DataSource = table;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            txtMaRap.Enabled = true;
            txtTenrap.Enabled = true;
            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;
            txtTenrap.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            txtMaRap.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaRap.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn Rạp!");
                return;
            }
            string sql = "select * from tblRap where MaRap='" + txtMaRap.Text.Trim() + "'";

            DAO.OpenConnection();
            if (DAO.checkKeyExit(sql))
            {
                MessageBox.Show("Mã rạp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DAO.CloseConnection();
                txtMaRap.Focus();
                return;
            }
            else
            {

                sql = "insert into tblRap (MaRap,TenRap,DiaChi,DienThoai,TongSoGhe,SoPhong) " +
                    " values ('" + txtMaRap.Text.Trim() + "','" + txtTenrap.Text.Trim() + "','" + txtDiachi.Text.Trim() + "',N'" + txtDienthoai.Text.Trim() + "' ,'" + txtTongsoghe.Text.Trim() + "','" + txtSophong.Text.Trim() + "')";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDataToGridView();
                txtMaRap.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DAO.OpenConnection();
                string sql = "delete from tblRap where MaRap = '" + txtMaRap.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDataToGridView();
                txtMaRap.Enabled = true;

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaRap.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaRap.Focus();
                return;
            }
            DAO.OpenConnection();
            string sql = "update tblRap set TenRap =N'" + txtTenrap.Text.Trim() + "' ,Diachi = N'" + txtDiachi.Text.Trim() + "' ,DienThoai =  '" + txtDienthoai.Text.Trim() + "',TongSoGhe ='" + txtTongsoghe.Text.Trim() + "',SoPhong = '" + txtSophong.Text.Trim() + "' where MaRap = '" + txtMaRap.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoadDataToGridView();
            txtMaRap.Enabled = true;
        }

        private void GridViewRap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaRap.Text = GridViewRap.CurrentRow.Cells["MaRap"].Value.ToString();
            txtTenrap.Text = GridViewRap.CurrentRow.Cells["TenRap"].Value.ToString();
            txtDiachi.Text = GridViewRap.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtDienthoai.Text = GridViewRap.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtSophong.Text = GridViewRap.CurrentRow.Cells["SoPhong"].Value.ToString();
            txtTongsoghe.Text = GridViewRap.CurrentRow.Cells["TongSoGhe"].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaRap.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }
    }
}
