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
    public partial class FrmHangSX : Form
    {
        public FrmHangSX()
        {
            InitializeComponent();
        }

        private void FrmHangSX_Load(object sender, EventArgs e)
        {
            LoadDatatoGridView();
            txtMahang.Text = "";
            txtTenhang.Text = "";
            btnLuu.Enabled = false;
        }
        private void LoadDatatoGridView()
        {
            DAO.OpenConnection();
            string sql = "Select * from tblHangSX";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridViewHangSX.DataSource = table;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMahang.Text = "";
            txtTenhang.Text = "";
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (txtMahang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã hãng");
                txtMahang.Focus();
                return;
            }
            if (txtTenhang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên hãng");
                txtTenhang.Focus();
                return;
            }
            sql = "select * from tblHangSX where MaHangSX='" + txtMahang.Text.Trim() + "'";

            DAO.OpenConnection();
            if (DAO.checkKeyExit(sql))
            {
                MessageBox.Show("Mã hãng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DAO.CloseConnection();
                txtMahang.Focus();
                return;
            }
            else
            {

                sql = "insert into tblHangSX (MaHangSX, TenHangSX) " +
                    " values ('" + txtMahang.Text.Trim() + "',N'" + txtTenhang.Text.Trim() + "' )";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDatatoGridView();
                txtMahang.Enabled = true;
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
            txtMahang.Text = "";
            txtTenhang.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from tblHangSX where MaHangSX = N'" + txtMahang.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDatatoGridView();
                txtMahang.Enabled = true;
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMahang.Focus();
                return;
            }
            DAO.OpenConnection();
            string sql = "update tblHangSX set TenHangSX = N'" + txtTenhang.Text.Trim() + "'where MaHangSX = '" + txtMahang.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoadDatatoGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewHangSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMahang.Text = GridViewHangSX.CurrentRow.Cells["MaHangSX"].Value.ToString();
            txtTenhang.Text = GridViewHangSX.CurrentRow.Cells["TenHangSX"].Value.ToString();
        }
    }
}
