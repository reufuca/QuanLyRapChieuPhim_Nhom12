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
    public partial class FrmLichChieu : Form
    {
        public FrmLichChieu()
        {
            InitializeComponent();
        }

        private void FrmLichChieu_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            cboMaphim.Enabled = true;
            cboMarap.Enabled = true;
            cboMaphong.Enabled = true;
            btnLuu.Enabled = false;
            dateNgaychieu.CustomFormat = " "; //Xóa trắng
            dateNgaychieu.Format = DateTimePickerFormat.Custom;
            LoadDataToGridView();
            DAO.FillDataToCombo("SELECT MaPhim, TenPhim FROM tblPhim",cboMaphim, "MaPhim", "TenPhim");
            DAO.FillDataToCombo("SELECT MaRap, TenRap FROM tblRap",cboMarap, "MaRap", "TenRap");
         // DAO.FillDataToCombo("SELECT MaPhong, TenPhong FROM tblPhongChieu",cboMaphong, "MaPhong", "TenPhong");
            DAO.CloseConnection();
        }
        private void LoadDataToGridView()
        {
            string sql = "select * from tblLichChieu";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridViewLichChieu.DataSource = table;
            dateNgaychieu.CustomFormat = "dd/MM/yyyy"; //Hiển thị năm/ngày/tháng
            dateNgaychieu.Format = DateTimePickerFormat.Custom;
            GridViewLichChieu.AllowUserToAddRows = false;
            GridViewLichChieu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void GridViewLichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma1 = GridViewLichChieu.CurrentRow.Cells["MaPhim"].Value.ToString();
            cboMaphim.Text = DAO.GetFieldValues("select MaPhim from tblLichChieu where MaPhim = '" + ma1 + "'");
            string ma2 = GridViewLichChieu.CurrentRow.Cells["MaRap"].Value.ToString();
            cboMarap.Text = DAO.GetFieldValues("select MaRap from tblLichChieu where MaRap = '" + ma2 + "'");
            string ma3 = GridViewLichChieu.CurrentRow.Cells["MaPhong"].Value.ToString();
            cboMaphong.Text = DAO.GetFieldValues("select MaPhong from tblLichChieu where MaPhong = '" + ma3 + "'");
            string ma4 = GridViewLichChieu.CurrentRow.Cells["MaGioChieu"].Value.ToString();
            cboMagiochieu.Text = DAO.GetFieldValues("select MaGioChieu from tblLichChieu where MaGioChieu = '" + ma4 + "'");
            txtMashow.Text = GridViewLichChieu.CurrentRow.Cells["MaShow"].Value.ToString();
            dateNgaychieu.Text = GridViewLichChieu.CurrentRow.Cells["NgayChieu"].Value.ToString();
            txtMashow.Text = GridViewLichChieu.CurrentRow.Cells["MaShow"].Value.ToString();
            txtGiave.Text = GridViewLichChieu.CurrentRow.Cells["GiaVe"].Value.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            cboMaphim.Enabled = true;
            cboMarap.Enabled = true;
            cboMaphong.Enabled = true;
            txtMashow.Enabled = true;
            dateNgaychieu.Enabled = true;
            cboMagiochieu.SelectedIndex = -1;
            txtGiave.Enabled = true;
            dateNgaychieu.CustomFormat = " "; //Xóa trắng
            dateNgaychieu.Format = DateTimePickerFormat.Custom;
            cboMaphim.SelectedIndex = -1;
            cboMaphong.SelectedIndex = -1;
            cboMarap.SelectedIndex = -1;
            txtMashow.Text = "";
            dateNgaychieu.Text = "";
            txtGiave.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboMaphim.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn phim!");
                return;
            }
            if (cboMaphong.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn phòng!");
                return;
            }
            if (cboMarap.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn rạp!");
                return;
            }
            //1 phòng không được chiếu trùng lịch
            //Kiểm tra Phim, Phòng, Giờ chiếu, Ngày chiếu có trùng?
            DAO.OpenConnection();
            string sql = "SELECT MaPhim,MaPhong,MaGioChieu,NgayChieu FROM tblLichChieu WHERE MaPhim=N'" + cboMaphim.SelectedValue.ToString() + "' AND MaPhong=N'" + cboMaphong.SelectedValue.ToString() + "' AND MaGioChieu=N'" + cboMagiochieu.SelectedValue.ToString() + "' AND NgayChieu=N'" + Convert.ToDateTime(dateNgaychieu.Value) +  "'";
            if (DAO.checkKeyExit(sql) == true)
            {
                MessageBox.Show("Phim '" + cboMaphim.SelectedValue.ToString() + "' đã có lịch chiếu tại phòng vào giờ này!", "Thông báo");
                return;
            }

            else
            {

                sql = "insert into tblLichChieu (MaShow,MaPhim,MaRap,MaPhong,NgayChieu,MaGioChieu,GiaVe) " +
                    " values ('" + txtMashow.Text.Trim() + "','" + cboMaphim.SelectedValue.ToString() + "','" + cboMarap.SelectedValue.ToString() + "','" + cboMaphong.SelectedValue.ToString() + "','" 
                    + Convert.ToDateTime(dateNgaychieu.Value) + "','" + cboMagiochieu.SelectedValue.ToString() + "','" + txtGiave.Text.Trim() + "')";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDataToGridView();
                txtMashow.Enabled = true;
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
                string sql = "delete from tblLichChieu where MaPhong = N'" + txtMashow.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                //  DAO.CloseConnection();
                LoadDataToGridView();
                txtMashow.Enabled = true;

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMashow.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMashow.Focus();
                return;
            }
            DAO.OpenConnection();
            string sql = "update tblLichChieu set NgayChieu =  '" + Convert.ToDateTime(dateNgaychieu.Value) + "',MaGioChieu ='" + cboMagiochieu.SelectedValue.ToString() + "',MaRap ='" + cboMarap.SelectedValue.ToString() + "',MaPhong ='" + cboMaphong.SelectedValue.ToString() + "',MaPhim ='" + cboMaphim.SelectedValue.ToString() + "',GiaVe ='" + txtGiave.Text.Trim() + "'where MaShow = '" + txtMashow.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoadDataToGridView();
            txtMashow.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
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
            { 
                string str1;
                str1 = "select distinct MaGioChieu, GioChieu from tblGioChieu where MaRap = '" + cboMarap.SelectedValue + "'";
                // MessageBox.Show(str);
                DAO.FillDataToCombo(str1, cboMagiochieu, "MaGioChieu", "GioChieu");

            }
        }

        private void dateNgaychieu_ValueChanged(object sender, EventArgs e)
        {
            dateNgaychieu.CustomFormat = "dd/MM/yyyy";
            dateNgaychieu.Format = DateTimePickerFormat.Custom;
        }
    }
}
