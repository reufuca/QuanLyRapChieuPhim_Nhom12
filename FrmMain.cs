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
            FrmRap f2 = new FrmRap();
            f2.Show();
        }
    }
}
