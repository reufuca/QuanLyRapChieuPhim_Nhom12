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
            
        }
        private void LoadDatatoGridView()
        {
            string sql = "Select * from tblPhongChieu";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridViewDMPhongchieu.DataSource = table;
        }
        private void fillDatatoCombo()
        {
            string sql = "Select * from tblRap";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboMaRap.DataSource = table;
            cboMaRap.ValueMember = "MaRap";
            cboMaRap.DisplayMember = "TenRap";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ResetValues()
        {
            cboMaRap.SelectedIndex = -1;
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtTongSoGhe.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if(txtMaPhong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã phòng");
                txtMaPhong.Focus();
                return;
            }
            if (txtTenPhong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã phòng");
                txtTenPhong.Focus();
                return;
            }
            if(txtTongSoGhe.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tổng số ghế");
                txtTongSoGhe.Focus();
                return;
            } 


        }
    }
}
