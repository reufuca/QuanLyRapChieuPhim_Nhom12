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
using System.IO;
using System.Drawing.Imaging;

namespace QuanLyRapPhim
{
    public partial class FrmPhim : Form
    {
        public FrmPhim()
        {
            InitializeComponent();
        }
        MemoryStream ms;

        private void FrmPhim_Load(object sender, EventArgs e)
        {
            FillDatatoCombos();
            LoadDatatoGridView();
            ResetValues();

        }
        private void ResetValues()
        {
            txtMaphim.Text = "";
            txtTenphim.Text = "";
            txtDaodien.Text = "";
            txtNamdvc.Text = "";
            txtNudvc.Text = "";
            txtNoidung.Text = "";
            txtTongchiphi.Text = "";
            txtTongthu.Text = "";
            dateNgaykc.CustomFormat = " "; //Xóa trắng
            dateNgaykc.Format = DateTimePickerFormat.Custom;
            dateNgaykt.CustomFormat = " "; //Xóa trắng
            dateNgaykt.Format = DateTimePickerFormat.Custom;
            cboNSX.SelectedIndex = -1;
            cboHSX.SelectedIndex = -1;
            cboTheloai.SelectedIndex = -1;
            btnLuu.Enabled = false;
        }
        private void FillDatatoCombos()
        {
            DAO.OpenConnection();
            DAO.FillDataToCombo("SELECT MaNuocSX, TenNuocSX from tblNuocSX", cboNSX, "MaNuocSX", "TenNuocSX");
            DAO.FillDataToCombo("SELECT MaHangSX, TenHangSX from tblHangSX", cboHSX, "MaHangSX", "TenHangSX");
            DAO.FillDataToCombo("SELECT MaTheLoai, TenTheLoai from tblTheLoai", cboTheloai, "MaTheLoai", "TenTheLoai");
        }
        private void LoadDatatoGridView()
        {
            DAO.OpenConnection();
            string sql = "Select * from tblPhim";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridViewPhim.DataSource = table;
            dateNgaykc.CustomFormat = "dd/MM/yyyy"; //Hiển thị năm/ngày/tháng
            dateNgaykc.Format = DateTimePickerFormat.Custom;
            dateNgaykt.CustomFormat = "dd/MM/yyyy";
            dateNgaykt.Format = DateTimePickerFormat.Custom;
            GridViewPhim.AllowUserToAddRows = false;
            GridViewPhim.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void GridViewPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dateNgaykc.CustomFormat = "dd/MM/yyyy"; 
            dateNgaykc.Format = DateTimePickerFormat.Custom;
            dateNgaykt.CustomFormat = "dd/MM/yyyy"; 
            dateNgaykt.Format = DateTimePickerFormat.Custom;
            string ma1 = GridViewPhim.CurrentRow.Cells["MaNuocSX"].Value.ToString();
            cboNSX.Text = DAO.GetFieldValues("select TenNuocSX from tblNuocSX where MaNuocSX = '" + ma1 + "'");
            string ma2 = GridViewPhim.CurrentRow.Cells["MaHangSX"].Value.ToString();
            cboHSX.Text = DAO.GetFieldValues("select TenHangSX from tblHangSX where MaHangSX = '" + ma2 + "'");
            string ma3 = GridViewPhim.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            cboTheloai.Text = DAO.GetFieldValues("select TenTheLoai from tblTheLoai where MaTheLoai = '" + ma3 + "'");
            txtMaphim.Text = GridViewPhim.CurrentRow.Cells["MaPhim"].Value.ToString();
            txtTenphim.Text = GridViewPhim.CurrentRow.Cells["TenPhim"].Value.ToString();
            txtDaodien.Text = GridViewPhim.CurrentRow.Cells["DaoDien"].Value.ToString();
            txtNudvc.Text = GridViewPhim.CurrentRow.Cells["NuDVChinh"].Value.ToString();
            txtNamdvc.Text = GridViewPhim.CurrentRow.Cells["NamDVChinh"].Value.ToString();
            txtNoidung.Text = GridViewPhim.CurrentRow.Cells["NoiDungChinh"].Value.ToString();
            txtTongchiphi.Text = GridViewPhim.CurrentRow.Cells["TongChiPhi"].Value.ToString();
            txtTongthu.Text = GridViewPhim.CurrentRow.Cells["TongThu"].Value.ToString();
            dateNgaykt.Text = GridViewPhim.CurrentRow.Cells["NgayKhoiChieu"].Value.ToString();
            dateNgaykc.Text = GridViewPhim.CurrentRow.Cells["NgayKetThuc"].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])GridViewPhim.CurrentRow.Cells["Anh"].Value);
            picBoxAnh.Image = Image.FromStream(ms); 
        }

        private void dateNgaykc_ValueChanged(object sender, EventArgs e)
        {
            dateNgaykc.CustomFormat = "dd/MM/yyyy";
            dateNgaykc.Format = DateTimePickerFormat.Custom;
        }

        private void dateNgaykt_ValueChanged(object sender, EventArgs e)
        {
            dateNgaykt.CustomFormat = "dd/MM/yyyy";
            dateNgaykt.Format = DateTimePickerFormat.Custom;
        }

        private void btnThemanh_Click(object sender, EventArgs e)
        {
                OpenFileDialog dlgOpen = new OpenFileDialog();
                dlgOpen.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                dlgOpen.InitialDirectory = @"E:\Stdyng\y2\part2\CSLT2\QuanLyRapPhim\MoviePictures";//duong dan mac dinh luon trong duong chay
                dlgOpen.FilterIndex = 1;//luon luon mac dinh file gif chon 1 la mac dinh bitmap
                dlgOpen.Title = "Chọn ảnh để hiển thị";
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    picBoxAnh.Image = Image.FromFile(dlgOpen.FileName);
                    Image.FromFile(dlgOpen.FileName);
                }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            ResetValues();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from tblPhim where MaPhim = '" + txtMaphim.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoadDatatoGridView();
                txtMaphim.Enabled = true;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (txtMaphim.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã phim");
                txtMaphim.Focus();
                return;
            }
            if (txtTenphim.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên phim");
                txtTenphim.Focus();
                return;
            }
            if (cboNSX.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn nước sản xuất");
                cboNSX.Focus();
                return;
            }
            if (cboHSX.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn hãng sản xuất");
                cboHSX.Focus();
                return;
            }
            if (cboTheloai.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn thể loại");
                cboTheloai.Focus();
                return;
            }
            if (txtDaodien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đạo diễn");
                txtDaodien.Focus();
                return;
            }
            if (dateNgaykc.Text == "")
            {
                MessageBox.Show("Bạn phải chọn ngày khởi chiếu");
                dateNgaykc.Focus();
                return;
            }
            if (dateNgaykt.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày kết thúc");
                dateNgaykt.Focus();
                return;
            }
            if (picBoxAnh.Image == null)
            {
                MessageBox.Show("Bạn phải chọn ảnh cho phim");
                btnThemanh.Focus();
                return;
            }

            sql = "select * from tblPhim where MaPhim='" + txtMaphim.Text.Trim() + "'";

            DAO.OpenConnection();
            if (DAO.checkKeyExit(sql))
            {
                MessageBox.Show("Mã phim đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DAO.CloseConnection();
                txtMaphim.Focus();
                return;
            }
            else
            {

                sql = "insert into tblPhim (MaPhim,TenPhim,MaNuocSX,MaHangSX,DaoDien,MaTheLoai,NgayKhoiChieu,NgayKetThuc,NuDVChinh,NamDVChinh,NoiDungChinh,TongChiPhi,TongThu,Anh) " +
                    " values ('" + txtMaphim.Text.Trim() + "',N'" + txtTenphim.Text.Trim() + "',N'" + cboNSX.SelectedValue.ToString() + "',N'" + cboHSX.SelectedValue.ToString() + "',N'" + txtDaodien.Text.Trim() 
                    + "',N'" + cboTheloai.SelectedValue.ToString() + "','" + Convert.ToDateTime(dateNgaykc.Value) + "','" + Convert.ToDateTime(dateNgaykt.Value) 
                    + "',N'" + txtNudvc.Text.Trim() + "',N'" + txtNamdvc.Text.Trim() + "',N'" + txtNoidung.Text.Trim() + "',N'" + txtTongchiphi.Text.Trim() + "',N'" + txtTongthu.Text.Trim() + "',@photo)";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                if (picBoxAnh.Image != null)
                {
                    ms = new MemoryStream();
                    picBoxAnh.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] photo_aray = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_aray, 0, photo_aray.Length);
                    cmd.Parameters.AddWithValue("@photo", photo_aray);
                    cmd.ExecuteNonQuery();
                    DAO.CloseConnection();
                    LoadDatatoGridView();
                    txtMaphim.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    DAO.CloseConnection();
                    LoadDatatoGridView();
                    txtMaphim.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                }    

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaphim.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaphim.Focus();
                return;
            }
            DAO.OpenConnection();
            string sql = "update tblPhim set TenPhim =N'" + txtTenphim.Text.Trim() + "' ,MaNuocSX = N'" + cboNSX.SelectedValue.ToString() + "' ,MaHangSX = N'" + cboHSX.SelectedValue.ToString() + "',MaTheLoai = N'" + cboTheloai.SelectedValue.ToString() 
                + "',DaoDien = N'" + txtDaodien.Text.Trim() + "',NuDVChinh = N'" + txtNudvc.Text.Trim() + "',NamDVChinh = N'" + txtNamdvc.Text.Trim() + "',TongChiPhi = '" + txtTongchiphi.Text.Trim() +
                "',TongThu = '" + txtTongthu.Text.Trim() + "',NoiDungChinh = N'" + txtNoidung.Text.Trim() + "',NgayKhoiChieu = '" + Convert.ToDateTime(dateNgaykc.Value) + "',NgayKetThuc = '" + Convert.ToDateTime(dateNgaykt.Value) +
                "',Anh = @photo1 where MaPhim = '" + txtMaphim.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand();
            MemoryStream mst;
            mst = new MemoryStream();
            picBoxAnh.Image.Save(mst, ImageFormat.Jpeg);
            byte[] photo_aray = new byte[mst.Length];
            mst.Position = 0;
            mst.Read(photo_aray, 0, photo_aray.Length);
            cmd.Parameters.AddWithValue("@photo1", photo_aray);
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoadDatatoGridView();
            txtMaphim.Enabled = true;
        }
    }
}
