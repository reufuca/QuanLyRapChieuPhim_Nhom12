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
    public partial class FrmPhongChieu : Form
    {
        public FrmPhongChieu()
        {
            InitializeComponent();  
        }
        private void DMPhim_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoadDatatoGridView();
            DAO.FillDataToCombo("SELECT MaRap,TenRap FROM tblRap",cboMaRap, "MaRap", "TenRap");
            ResetValues();
            btnLuu.Enabled = false;
        }
        private void LoadDatatoGridView()
        {
            string sql = "Select * from tblPhongChieu";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridViewDMPhongchieu.DataSource = table;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ResetValues()
        {
            cboMaRap.SelectedIndex = -1;
            txtMaphong.Text = "";
            txtTenphong.Text = "";
            txtTongsoghe.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (txtMaphong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã phòng");
                txtMaphong.Focus();
                return;
            }
            if (txtTenphong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên phòng");
                txtTenphong.Focus();
                return;
            }
            if (txtTongsoghe.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tổng số ghế");
                txtTongsoghe.Focus();
                return;
            }
            sql = "select * from tblPhongChieu where MaPhong='" + txtMaphong.Text.Trim() + "'";

            DAO.OpenConnection();
            if (DAO.checkKeyExit(sql))
            {
                MessageBox.Show("Mã phòng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DAO.CloseConnection();
                txtMaphong.Focus();
                return;
            }
            else
            {

                sql = "insert into tblPhongChieu (MaRap,MaPhong,TenPhong,TongSoGhe) " +
                    " values ('" + cboMaRap.SelectedValue.ToString() + "','" + txtMaphong.Text.Trim() + "',N'" + txtTenphong.Text.Trim() + "','" + txtTongsoghe.Text.Trim() + "' )";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDatatoGridView();
                txtMaphong.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from tblPhongChieu where MaPhong = '" + txtMaphong.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDatatoGridView();
                txtMaphong.Enabled = true;
            }
        }

        private void GridViewDMPhongchieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = GridViewDMPhongchieu.CurrentRow.Cells["MaRap"].Value.ToString();
            cboMaRap.Text = DAO.GetFieldValues("select TenRap from tblRap where MaRap = '" + ma + "'");
            txtMaphong.Text = GridViewDMPhongchieu.CurrentRow.Cells["MaPhong"].Value.ToString();
            txtTenphong.Text = GridViewDMPhongchieu.CurrentRow.Cells["TenPhong"].Value.ToString();
            txtTongsoghe.Text = GridViewDMPhongchieu.CurrentRow.Cells["TongSoGhe"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaphong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaphong.Focus();
                return;
            }
            DAO.OpenConnection();
            string sql = "update tblPhongChieu set TenPhong =  N'" + txtTenphong.Text.Trim() + "' ,MaRap = N'" + cboMaRap.SelectedValue.ToString() + "',TongSoGhe ='" 
                + txtTongsoghe.Text.Trim() + "'where MaPhong = N'" + txtMaphong.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoadDatatoGridView();
            //txtMaphong.Enabled = true;
        }
    }
}
