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
    public partial class FrmGioChieu : Form
    {
        public FrmGioChieu()
        {
            InitializeComponent();
        }

        private void LoadDatatoGridView()
        {
            DAO.OpenConnection();
            string sql = "Select * from tblGioChieu";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridViewGioChieu.DataSource = table;
            timeGiochieu.CustomFormat = "HH:mm";
            timeGiochieu.Format = DateTimePickerFormat.Custom;
            timeGiochieu.ShowUpDown = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMagiochieu.Text = "";
            timeGiochieu.Text = "";
            cboRap.SelectedIndex = -1;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (txtMagiochieu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã giờ chiếu");
                txtMagiochieu.Focus();
                return;
            }
            if (timeGiochieu.Text == "")
            {
                MessageBox.Show("Bạn phải chọn giờ chiếu");
                timeGiochieu.Focus();
                return;
            }
            if (cboRap.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn rạp");
                cboRap.Focus();
                return;
            }
            sql = "select * from tblGioChieu where MaGioChieu='" + txtMagiochieu.Text.Trim() + "'";

            DAO.OpenConnection();
            if (DAO.checkKeyExit(sql))
            {
                MessageBox.Show("Mã giờ chiếu đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DAO.CloseConnection();
                txtMagiochieu.Focus();
                return;
            }
            else
            {

                sql = "insert into tblGioChieu (MaGioChieu, MaRap, GioChieu) " +
                    " values ('" + txtMagiochieu.Text.Trim() + "','" + cboRap.SelectedValue.ToString() + "','" + timeGiochieu.Value.ToShortTimeString() + "' )";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDatatoGridView();
                txtMagiochieu.Enabled = true;
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
            txtMagiochieu.Text = "";
            timeGiochieu.Text = "";
            cboRap.SelectedIndex = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from tblGioChieu where MaGioChieu = '" + txtMagiochieu.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDatatoGridView();
                txtMagiochieu.Enabled = true;
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMagiochieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMagiochieu.Focus();
                return;
            }
            DAO.OpenConnection();
            string sql = "UPDATE tblGioChieu SET GioChieu =  '" + timeGiochieu.Value.ToShortTimeString() + "',MaRap ='" + cboRap.SelectedValue + "'WHERE MaGioChieu = '" + txtMagiochieu.Text.Trim() + "'";
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
        private void GridViewGioChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timeGiochieu.CustomFormat = "HH:mm";
            timeGiochieu.Format = DateTimePickerFormat.Custom;
            timeGiochieu.ShowUpDown = true;
            txtMagiochieu.Text = GridViewGioChieu.CurrentRow.Cells["MaGioChieu"].Value.ToString();
            timeGiochieu.Text = GridViewGioChieu.CurrentRow.Cells["GioChieu"].Value.ToString();
            string ma = GridViewGioChieu.CurrentRow.Cells["MaRap"].Value.ToString();
            cboRap.Text = DAO.GetFieldValues("select MaRap from tblGioChieu where MaRap = '" + ma + "'");
        }

        private void FrmGioChieu_Load_1(object sender, EventArgs e)
        {
            LoadDatatoGridView();
            DAO.FillDataToCombo("SELECT MaRap, TenRap FROM tblRap", cboRap, "MaRap", "TenRap");
            txtMagiochieu.Text = "";
            timeGiochieu.CustomFormat = " "; //Xóa trắng
            timeGiochieu.Format = DateTimePickerFormat.Custom;
            timeGiochieu.ShowUpDown = true;
            cboRap.SelectedIndex = -1;
            btnLuu.Enabled = false;
        }

        private void timeGiochieu_ValueChanged(object sender, EventArgs e)
        {
            timeGiochieu.CustomFormat = "HH:mm";
            timeGiochieu.Format = DateTimePickerFormat.Custom;
            timeGiochieu.ShowUpDown = true;
        }
    }
}
