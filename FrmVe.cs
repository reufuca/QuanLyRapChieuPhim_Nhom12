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
    public partial class FrmVe : Form
    {
        public FrmVe()
        {
            InitializeComponent();
        }

        private void FrmVe_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoadDataToGridView();
            DAO.FillDataToCombo("SELECT MaShow FROM tblLichChieu", cboMashow, "MaShow", "MaShow");
            DAO.FillDataToCombo("SELECT MaGhe FROM tblPhongChieuGhe where TrangThai = N'Trống'", cboGhe, "MaGhe", "MaGhe");
            btnLuu.Enabled = false;
            DAO.CloseConnection();
        }

        private void LoadDataToGridView()
        {
            string sql = "select * from tblVe";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridViewVe.DataSource = table;
            GridViewVe.AllowUserToAddRows = false;
            GridViewVe.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboMashow.Enabled = true;
            cboGhe.Enabled = true;
            cboMashow.SelectedIndex = -1;
            cboGhe.SelectedIndex = -1;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DAO.OpenConnection();
                string sql = "delete from tblVe where MaGhe = N'" + cboGhe.SelectedValue.ToString() + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDataToGridView();
                cboGhe.Enabled = true;
            }
        }

        private void GridViewVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = GridViewVe.CurrentRow.Cells["MaShow"].Value.ToString();
            cboMashow.Text = DAO.GetFieldValues("select MaShow from tblLichChieu where MaShow = '" + ma + "'");
            string ma1 = GridViewVe.CurrentRow.Cells["MaGhe"].Value.ToString();
            cboGhe.Text = DAO.GetFieldValues("select MaGhe from tblPhongChieuGhe where MaGhe = '" + ma1 + "'");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cboGhe.SelectedIndex = -1;
            cboMashow.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cboGhe.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboGhe.Focus();
                return;
            }
            DAO.OpenConnection();
            string sql = "update tblVe set MaShow =  N'" + cboMashow.SelectedValue.ToString() + "'where MaGhe = N'" + cboGhe.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoadDataToGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (cboGhe.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn ghế");
                cboGhe.Focus();
                return;
            }
            if (cboMashow.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn show");
                cboGhe.Focus();
                return;
            }

            sql = "select * from tblVe where MaGhe='" + cboGhe.SelectedValue.ToString() + "'";

            DAO.OpenConnection();
            if (DAO.checkKeyExit(sql))
            {
                MessageBox.Show("Mã ghế đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DAO.CloseConnection();
                cboGhe.Focus();
                return;
            }
            else
            {

                sql = "insert into tblVe (MaShow, MaGhe) " +
                    " values ('" + cboMashow.SelectedValue.ToString() + "','" + cboGhe.SelectedValue.ToString() + "' )";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDataToGridView();
                cboGhe.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
