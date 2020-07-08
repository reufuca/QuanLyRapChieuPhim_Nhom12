using QuanLyBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLyRapPhim
{
    public partial class FrmGhe : Form
    {
        public FrmGhe()
        {
            InitializeComponent();
        }

        private void FrmGhe_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoadDatatoGridView();
            DAO.FillDataToCombo("SELECT MaRap,TenRap FROM tblRap", cboMarap, "MaRap", "TenRap");
         /*   DAO.FillDataToCombo("SELECT MaPhong, TenPhong FROM tblPhongChieu", cboMaphong, "MaPhong", "TenPhong");
            cboMarap.SelectedIndex = -1;
            cboMaphong.SelectedIndex = -1; */
            cboTrangthai.SelectedIndex = -1; 
            txtMaghe.Text = "";
            btnLuu.Enabled = false;
        }
        private void LoadDatatoGridView()
        {
            DAO.OpenConnection();
            string sql = "Select * from tblPhongChieuGhe";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridViewGhe.DataSource = table;
        }

        private void GridViewGhe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaghe.Text = GridViewGhe.CurrentRow.Cells["MaGhe"].Value.ToString();
            string ma = GridViewGhe.CurrentRow.Cells["MaRap"].Value.ToString();
            cboMarap.Text = DAO.GetFieldValues("select MaRap from tblPhongChieuGhe where MaRap = '" + ma + "'");
            string ma1 = GridViewGhe.CurrentRow.Cells["MaPhong"].Value.ToString();
            cboMaphong.Text = DAO.GetFieldValues("select MaPhong from tblPhongChieuGhe where MaPhong = '" + ma1 + "'");
            cboTrangthai.Text = GridViewGhe.CurrentRow.Cells["TrangThai"].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboMarap.SelectedIndex = -1;
            cboMaphong.SelectedIndex = -1;
            cboTrangthai.SelectedIndex = -1;
            txtMaghe.Text = "";
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cboMarap.SelectedIndex = -1;
            cboMaphong.SelectedIndex = -1;
            cboTrangthai.SelectedIndex = -1;
            txtMaghe.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from tblPhongChieuGhe where MaGhe = '" + txtMaghe.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDatatoGridView();
                txtMaghe.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (txtMaghe.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã ghế");
                txtMaghe.Focus();
                return;
            }
            if (cboMaphong.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn phòng");
                cboMaphong.Focus();
                return;
            }
            if (cboMarap.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn rạp");
                cboMarap.Focus();
                return;
            }
            if (cboTrangthai.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn trạng thái");
                cboTrangthai.Focus();
                return;
            }
            sql = "select * from tblPhongChieuGhe where MaGhe='" + txtMaghe.Text.Trim() + "'";

            if (DAO.checkKeyExit(sql))
            {
                MessageBox.Show("Mã ghế đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DAO.CloseConnection();
                txtMaghe.Focus();
                return;
            }
            else
            {
                sql = "insert into tblPhongChieuGhe (MaGhe, MaRap, MaPhong, TrangThai) " + " values ('" + txtMaghe.Text.Trim() + "',N'" + cboMarap.SelectedValue.ToString() +  "',N'" + cboMaphong.SelectedValue.ToString() + "',N'" + cboTrangthai.Text + "' )";
                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDatatoGridView();
                txtMaghe.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            if (txtMaghe.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaghe.Focus();
                return;
            }
            string sql = "UPDATE tblPhongChieuGhe SET MaPhong = N'" + cboMaphong.SelectedValue.ToString() + "',MaRap =N'" + cboMarap.SelectedValue.ToString() + 
                "',TrangThai = N'" + cboTrangthai.Text + "'WHERE MaGhe = '" + txtMaghe.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoadDatatoGridView();
        }

        private void cboMarap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMarap.SelectedIndex != -1)
            {
                    string str;
                    str = "select distinct MaPhong, TenPhong from tblPhongChieu where MaRap = '" + cboMarap.SelectedValue + "'";
                    // MessageBox.Show(str);
                    DAO.FillDataToCombo(str, cboMaphong, "MaPhong", "TenPhong");
            }
        }
    }
}
