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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhongChieu));
            this.lblMaRap = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.lblTongSoGhe = new System.Windows.Forms.Label();
            this.txtTongsoghe = new System.Windows.Forms.TextBox();
            this.GridViewDMPhongchieu = new System.Windows.Forms.DataGridView();
            this.MaRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongsoghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMaRap = new System.Windows.Forms.ComboBox();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDMPhongchieu)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // txtTenphong
            // 
            this.txtTenphong.Location = new System.Drawing.Point(582, 20);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(173, 22);
            this.txtTenphong.TabIndex = 1;
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
            // txtTongsoghe
            // 
            this.txtTongsoghe.Location = new System.Drawing.Point(582, 68);
            this.txtTongsoghe.Name = "txtTongsoghe";
            this.txtTongsoghe.Size = new System.Drawing.Size(173, 22);
            this.txtTongsoghe.TabIndex = 1;
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
            this.GridViewDMPhongchieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDMPhongchieu_CellClick);
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
            // cboMaRap
            // 
            this.cboMaRap.FormattingEnabled = true;
            this.cboMaRap.Location = new System.Drawing.Point(129, 22);
            this.cboMaRap.Name = "cboMaRap";
            this.cboMaRap.Size = new System.Drawing.Size(197, 24);
            this.cboMaRap.TabIndex = 4;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(129, 71);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(197, 22);
            this.txtMaphong.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(12, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 84);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(540, 26);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 39);
            this.btnHuy.TabIndex = 53;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(414, 26);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 39);
            this.btnLuu.TabIndex = 49;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(287, 26);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 39);
            this.btnXoa.TabIndex = 50;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(163, 26);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 39);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(658, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 39);
            this.btnThoat.TabIndex = 48;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(33, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 39);
            this.btnThem.TabIndex = 52;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmPhongChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboMaRap);
            this.Controls.Add(this.GridViewDMPhongchieu);
            this.Controls.Add(this.txtTongsoghe);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.txtTenphong);
            this.Controls.Add(this.lblTongSoGhe);
            this.Controls.Add(this.lblTenPhong);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblMaRap);
            this.Name = "FrmPhongChieu";
            this.Text = "Phòng Chiếu";
            this.Load += new System.EventHandler(this.DMPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDMPhongchieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaRap;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.Label lblTongSoGhe;
        private System.Windows.Forms.TextBox txtTongsoghe;
        private System.Windows.Forms.DataGridView GridViewDMPhongchieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongsoghe;
        private System.Windows.Forms.ComboBox cboMaRap;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
    }
}