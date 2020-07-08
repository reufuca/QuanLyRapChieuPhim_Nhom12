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
    public partial class FrmTheLoai : Form
    {
        public FrmTheLoai()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTheLoai_Load(object sender, EventArgs e)
        {
            LoadDatatoGridView();
            txtMatheloai.Text = "";
            txtTentheloai.Text = "";
            btnLuu.Enabled = false;
        }
        private void LoadDatatoGridView()
        {
            DAO.OpenConnection();
            string sql = "Select * from tblTheLoai";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridViewTheLoai.DataSource = table;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMatheloai.Text = "";
            txtTentheloai.Text = "";
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (txtMatheloai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã thể loại");
                txtMatheloai.Focus();
                return;
            }
            if (txtTentheloai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên thể loại");
                txtTentheloai.Focus();
                return;
            }
            sql = "select * from tblTheLoai where MaTheLoai='" + txtMatheloai.Text.Trim() + "'";

            DAO.OpenConnection();
            if (DAO.checkKeyExit(sql))
            {
                MessageBox.Show("Mã thể loại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DAO.CloseConnection();
                txtMatheloai.Focus();
                return;
            }
            else
            {

                sql = "insert into tblTheLoai (MaTheLoai, TenTheLoai) " +
                    " values ('" + txtMatheloai.Text.Trim() + "',N'" + txtTentheloai.Text.Trim() + "' )";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDatatoGridView();
                txtMatheloai.Enabled = true;
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
            txtMatheloai.Text = "";
            txtTentheloai.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from tblMaTheLoai where MaTheLoai = '" + txtMatheloai.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDatatoGridView();
                txtMatheloai.Enabled = true;
            }
        }

        private void GridViewTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatheloai.Text = GridViewTheLoai.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            txtTentheloai.Text = GridViewTheLoai.CurrentRow.Cells["TenTheLoai"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMatheloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatheloai.Focus();
                return;
            }
            DAO.OpenConnection();
            string sql = "update tblTheLoai set TenTheLoai =  N'" + txtTentheloai.Text.Trim() +  "'where MaTheLoai = '" + txtMatheloai.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoadDatatoGridView();
        }
    }
}
