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
    public partial class FrmNuocSX : Form
    {
        public FrmNuocSX()
        {
            InitializeComponent();
        }

        private void FrmNuocSX_Load(object sender, EventArgs e)
        {
            LoadDatatoGridView();
            txtManuoc.Text = "";
            txtTennuoc.Text = "";
            btnLuu.Enabled = false;
        }
        private void LoadDatatoGridView()
        {
            DAO.OpenConnection();
            string sql = "Select * from tblNuocSX";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridViewNuocSX.DataSource = table;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtManuoc.Text = "";
            txtTennuoc.Text = "";
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (txtManuoc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nước");
                txtManuoc.Focus();
                return;
            }
            if (txtTennuoc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nước");
                txtTennuoc.Focus();
                return;
            }
            sql = "select * from tblNuocSX where MaNuocSX='" + txtManuoc.Text.Trim() + "'";

            DAO.OpenConnection();
            if (DAO.checkKeyExit(sql))
            {
                MessageBox.Show("Mã nước đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DAO.CloseConnection();
                txtManuoc.Focus();
                return;
            }
            else
            {

                sql = "insert into tblNuocSX (MaNuocSX, TenNuocSX) " +
                    " values ('" + txtManuoc.Text.Trim() + "',N'" + txtTennuoc.Text.Trim() + "' )";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDatatoGridView();
                txtManuoc.Enabled = true;
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
            txtManuoc.Text = "";
            txtTennuoc.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from tblNuocSX where MaNuocSX = '" + txtManuoc.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDatatoGridView();
                txtManuoc.Enabled = true;
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtManuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManuoc.Focus();
                return;
            }
            DAO.OpenConnection();
            string sql = "update tblNuocSX set TenNuocSX =  N'" + txtTennuoc.Text.Trim() + "'where MaNuocSX = '" + txtManuoc.Text.Trim() + "'";
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

        private void GridViewNuocSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManuoc.Text = GridViewNuocSX.CurrentRow.Cells["MaNuocSX"].Value.ToString();
            txtTennuoc.Text = GridViewNuocSX.CurrentRow.Cells["TenNuocSX"].Value.ToString();
        }
    }
}
