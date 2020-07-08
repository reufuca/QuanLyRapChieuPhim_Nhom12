using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void phimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phòngChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhongChieu f1 = new FrmPhongChieu();
            f1.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rạpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRap f1 = new FrmRap();
            f1.Show();
        }

        private void lịchChiếuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTimKiemLich f1 = new FrmTimKiemLich();
            f1.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTheLoai f1 = new FrmTheLoai();
            f1.Show();
        }

        private void nướcSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuocSX f1 = new FrmNuocSX();
            f1.Show();
        }

        private void hãngSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHangSX f1 = new FrmHangSX();
            f1.Show();
        }

        private void lịchChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLichChieu f1 = new FrmLichChieu();
            f1.Show();
        }

        private void phimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTimKiemPhim f1 = new FrmTimKiemPhim();
            f1.Show();
        }

        private void giờChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGioChieu f1 = new FrmGioChieu();
            f1.Show();
        }

        private void phimToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPhim f1 = new FrmPhim();
            f1.Show();
        }

        private void ghếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGhe f1 = new FrmGhe();
            f1.Show();
        }

        private void véToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVe f1 = new FrmVe();
            f1.Show();
        }

        private void phimToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InDoanhThuPhim f1 = new InDoanhThuPhim();
            f1.Show();
        }

        private void rạpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InDoanhThuRap f1 = new InDoanhThuRap();
            f1.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InPhimDangChieu f1 = new InPhimDangChieu();
            f1.Show();
        }
    }
}
