namespace QuanLyRapPhim
{
    partial class FrmTimKiemPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemPhim));
            this.GridViewTimKiemPhim = new System.Windows.Forms.DataGridView();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaphim = new System.Windows.Forms.Label();
            this.lblRap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHangSX = new System.Windows.Forms.ComboBox();
            this.txtTenphim = new System.Windows.Forms.TextBox();
            this.btnTimkiemhsx = new System.Windows.Forms.Button();
            this.btnTimkiemtheloai = new System.Windows.Forms.Button();
            this.btnTimkiemphim = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTimKiemPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewTimKiemPhim
            // 
            this.GridViewTimKiemPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewTimKiemPhim.Location = new System.Drawing.Point(48, 201);
            this.GridViewTimKiemPhim.Name = "GridViewTimKiemPhim";
            this.GridViewTimKiemPhim.RowHeadersWidth = 51;
            this.GridViewTimKiemPhim.RowTemplate.Height = 24;
            this.GridViewTimKiemPhim.Size = new System.Drawing.Size(704, 228);
            this.GridViewTimKiemPhim.TabIndex = 11;
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(183, 104);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(189, 24);
            this.cboTheLoai.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "TÌM KIẾM PHIM";
            // 
            // lblMaphim
            // 
            this.lblMaphim.AutoSize = true;
            this.lblMaphim.Location = new System.Drawing.Point(101, 107);
            this.lblMaphim.Name = "lblMaphim";
            this.lblMaphim.Size = new System.Drawing.Size(59, 17);
            this.lblMaphim.TabIndex = 5;
            this.lblMaphim.Text = "Thể loại";
            // 
            // lblRap
            // 
            this.lblRap.AutoSize = true;
            this.lblRap.Location = new System.Drawing.Point(92, 68);
            this.lblRap.Name = "lblRap";
            this.lblRap.Size = new System.Drawing.Size(68, 17);
            this.lblRap.TabIndex = 6;
            this.lblRap.Text = "Tên Phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hãng sản xuất";
            // 
            // cboHangSX
            // 
            this.cboHangSX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboHangSX.FormattingEnabled = true;
            this.cboHangSX.Location = new System.Drawing.Point(183, 140);
            this.cboHangSX.Name = "cboHangSX";
            this.cboHangSX.Size = new System.Drawing.Size(189, 24);
            this.cboHangSX.TabIndex = 8;
            // 
            // txtTenphim
            // 
            this.txtTenphim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTenphim.Location = new System.Drawing.Point(183, 65);
            this.txtTenphim.Name = "txtTenphim";
            this.txtTenphim.Size = new System.Drawing.Size(189, 22);
            this.txtTenphim.TabIndex = 14;
            // 
            // btnTimkiemhsx
            // 
            this.btnTimkiemhsx.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiemhsx.Image")));
            this.btnTimkiemhsx.Location = new System.Drawing.Point(398, 140);
            this.btnTimkiemhsx.Name = "btnTimkiemhsx";
            this.btnTimkiemhsx.Size = new System.Drawing.Size(25, 24);
            this.btnTimkiemhsx.TabIndex = 13;
            this.btnTimkiemhsx.UseVisualStyleBackColor = true;
            this.btnTimkiemhsx.Click += new System.EventHandler(this.btnTimkiemhsx_Click);
            // 
            // btnTimkiemtheloai
            // 
            this.btnTimkiemtheloai.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiemtheloai.Image")));
            this.btnTimkiemtheloai.Location = new System.Drawing.Point(398, 104);
            this.btnTimkiemtheloai.Name = "btnTimkiemtheloai";
            this.btnTimkiemtheloai.Size = new System.Drawing.Size(25, 24);
            this.btnTimkiemtheloai.TabIndex = 13;
            this.btnTimkiemtheloai.UseVisualStyleBackColor = true;
            this.btnTimkiemtheloai.Click += new System.EventHandler(this.btnTimkiemtheloai_Click);
            // 
            // btnTimkiemphim
            // 
            this.btnTimkiemphim.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiemphim.Image")));
            this.btnTimkiemphim.Location = new System.Drawing.Point(398, 65);
            this.btnTimkiemphim.Name = "btnTimkiemphim";
            this.btnTimkiemphim.Size = new System.Drawing.Size(25, 24);
            this.btnTimkiemphim.TabIndex = 13;
            this.btnTimkiemphim.UseVisualStyleBackColor = true;
            this.btnTimkiemphim.Click += new System.EventHandler(this.btnTimkiemphim_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(473, 76);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(179, 72);
            this.btnTimkiem.TabIndex = 12;
            this.btnTimkiem.Text = "TÌM KIẾM";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // FrmTimKiemPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTenphim);
            this.Controls.Add(this.btnTimkiemhsx);
            this.Controls.Add(this.btnTimkiemtheloai);
            this.Controls.Add(this.btnTimkiemphim);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.GridViewTimKiemPhim);
            this.Controls.Add(this.cboHangSX);
            this.Controls.Add(this.cboTheLoai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaphim);
            this.Controls.Add(this.lblRap);
            this.Name = "FrmTimKiemPhim";
            this.Text = "Tìm Kiếm Phim";
            this.Load += new System.EventHandler(this.FrmTimKiemPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTimKiemPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewTimKiemPhim;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaphim;
        private System.Windows.Forms.Label lblRap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHangSX;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnTimkiemphim;
        private System.Windows.Forms.Button btnTimkiemtheloai;
        private System.Windows.Forms.Button btnTimkiemhsx;
        private System.Windows.Forms.TextBox txtTenphim;
    }
}