namespace QuanLyRapPhim
{
    partial class FrmPhongChieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaRap = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lblTongSoGhe = new System.Windows.Forms.Label();
            this.txtTongSoGhe = new System.Windows.Forms.TextBox();
            this.GridViewDMPhongchieu = new System.Windows.Forms.DataGridView();
            this.MaRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongsoghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboMaRap = new System.Windows.Forms.ComboBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDMPhongchieu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaRap
            // 
            this.lblMaRap.AutoSize = true;
            this.lblMaRap.Location = new System.Drawing.Point(22, 20);
            this.lblMaRap.Name = "lblMaRap";
            this.lblMaRap.Size = new System.Drawing.Size(34, 17);
            this.lblMaRap.TabIndex = 0;
            this.lblMaRap.Text = "Rạp";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(22, 71);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(71, 17);
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Mã phòng";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(449, 25);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(77, 17);
            this.lblTenPhong.TabIndex = 0;
            this.lblTenPhong.Text = "Tên phòng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(582, 20);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(173, 22);
            this.txtTenPhong.TabIndex = 1;
            // 
            // lblTongSoGhe
            // 
            this.lblTongSoGhe.AutoSize = true;
            this.lblTongSoGhe.Location = new System.Drawing.Point(449, 71);
            this.lblTongSoGhe.Name = "lblTongSoGhe";
            this.lblTongSoGhe.Size = new System.Drawing.Size(88, 17);
            this.lblTongSoGhe.TabIndex = 0;
            this.lblTongSoGhe.Text = "Tổng số ghế";
            // 
            // txtTongSoGhe
            // 
            this.txtTongSoGhe.Location = new System.Drawing.Point(582, 68);
            this.txtTongSoGhe.Name = "txtTongSoGhe";
            this.txtTongSoGhe.Size = new System.Drawing.Size(173, 22);
            this.txtTongSoGhe.TabIndex = 1;
            // 
            // GridViewDMPhongchieu
            // 
            this.GridViewDMPhongchieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDMPhongchieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaRap,
            this.MaPhong,
            this.TenPhong,
            this.Tongsoghe});
            this.GridViewDMPhongchieu.Location = new System.Drawing.Point(40, 128);
            this.GridViewDMPhongchieu.Name = "GridViewDMPhongchieu";
            this.GridViewDMPhongchieu.RowHeadersWidth = 51;
            this.GridViewDMPhongchieu.RowTemplate.Height = 24;
            this.GridViewDMPhongchieu.Size = new System.Drawing.Size(729, 237);
            this.GridViewDMPhongchieu.TabIndex = 2;
            // 
            // MaRap
            // 
            this.MaRap.DataPropertyName = "MaRap";
            this.MaRap.HeaderText = "Mã Rạp";
            this.MaRap.MinimumWidth = 6;
            this.MaRap.Name = "MaRap";
            this.MaRap.Width = 125;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 125;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Width = 125;
            // 
            // Tongsoghe
            // 
            this.Tongsoghe.DataPropertyName = "TongSoGhe";
            this.Tongsoghe.HeaderText = "Tổng số ghế";
            this.Tongsoghe.MinimumWidth = 6;
            this.Tongsoghe.Name = "Tongsoghe";
            this.Tongsoghe.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 385);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 53);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(193, 385);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 53);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(335, 385);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 53);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(478, 385);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(133, 53);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(620, 385);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 53);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboMaRap
            // 
            this.cboMaRap.FormattingEnabled = true;
            this.cboMaRap.Location = new System.Drawing.Point(129, 22);
            this.cboMaRap.Name = "cboMaRap";
            this.cboMaRap.Size = new System.Drawing.Size(197, 24);
            this.cboMaRap.TabIndex = 4;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(129, 71);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(197, 22);
            this.txtMaPhong.TabIndex = 1;
            // 
            // FrmPhongChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboMaRap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.GridViewDMPhongchieu);
            this.Controls.Add(this.txtTongSoGhe);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.lblTongSoGhe);
            this.Controls.Add(this.lblTenPhong);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblMaRap);
            this.Name = "FrmPhongChieu";
            this.Text = "Phòng Chiếu";
            this.Load += new System.EventHandler(this.DMPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDMPhongchieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaRap;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label lblTongSoGhe;
        private System.Windows.Forms.TextBox txtTongSoGhe;
        private System.Windows.Forms.DataGridView GridViewDMPhongchieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongsoghe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboMaRap;
        private System.Windows.Forms.TextBox txtMaPhong;
    }
}