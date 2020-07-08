namespace QuanLyRapPhim
{
    partial class FrmTimKiemLich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemLich));
            this.lblRap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRap = new System.Windows.Forms.ComboBox();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.lblMaphim = new System.Windows.Forms.Label();
            this.GridViewTimKiemLich = new System.Windows.Forms.DataGridView();
            this.btnTimkiemphim = new System.Windows.Forms.Button();
            this.btnTimkiemrap = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTimKiemLich)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRap
            // 
            this.lblRap.AutoSize = true;
            this.lblRap.Location = new System.Drawing.Point(142, 76);
            this.lblRap.Name = "lblRap";
            this.lblRap.Size = new System.Drawing.Size(34, 17);
            this.lblRap.TabIndex = 0;
            this.lblRap.Text = "Rạp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÌM KIẾM LỊCH CHIẾU";
            // 
            // cboRap
            // 
            this.cboRap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboRap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRap.FormattingEnabled = true;
            this.cboRap.Location = new System.Drawing.Point(195, 73);
            this.cboRap.Name = "cboRap";
            this.cboRap.Size = new System.Drawing.Size(189, 24);
            this.cboRap.TabIndex = 2;
            // 
            // cboPhim
            // 
            this.cboPhim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPhim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPhim.FormattingEnabled = true;
            this.cboPhim.Location = new System.Drawing.Point(195, 125);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(189, 24);
            this.cboPhim.TabIndex = 2;
            // 
            // lblMaphim
            // 
            this.lblMaphim.AutoSize = true;
            this.lblMaphim.Location = new System.Drawing.Point(137, 128);
            this.lblMaphim.Name = "lblMaphim";
            this.lblMaphim.Size = new System.Drawing.Size(39, 17);
            this.lblMaphim.TabIndex = 0;
            this.lblMaphim.Text = "Phim";
            // 
            // GridViewTimKiemLich
            // 
            this.GridViewTimKiemLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewTimKiemLich.Location = new System.Drawing.Point(42, 189);
            this.GridViewTimKiemLich.Name = "GridViewTimKiemLich";
            this.GridViewTimKiemLich.RowHeadersWidth = 51;
            this.GridViewTimKiemLich.RowTemplate.Height = 24;
            this.GridViewTimKiemLich.Size = new System.Drawing.Size(704, 228);
            this.GridViewTimKiemLich.TabIndex = 4;
            // 
            // btnTimkiemphim
            // 
            this.btnTimkiemphim.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiemphim.Image")));
            this.btnTimkiemphim.Location = new System.Drawing.Point(398, 125);
            this.btnTimkiemphim.Name = "btnTimkiemphim";
            this.btnTimkiemphim.Size = new System.Drawing.Size(25, 24);
            this.btnTimkiemphim.TabIndex = 14;
            this.btnTimkiemphim.UseVisualStyleBackColor = true;
            this.btnTimkiemphim.Click += new System.EventHandler(this.btnTimkiemphim_Click);
            // 
            // btnTimkiemrap
            // 
            this.btnTimkiemrap.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiemrap.Image")));
            this.btnTimkiemrap.Location = new System.Drawing.Point(398, 73);
            this.btnTimkiemrap.Name = "btnTimkiemrap";
            this.btnTimkiemrap.Size = new System.Drawing.Size(25, 24);
            this.btnTimkiemrap.TabIndex = 15;
            this.btnTimkiemrap.UseVisualStyleBackColor = true;
            this.btnTimkiemrap.Click += new System.EventHandler(this.btnTimkiemrap_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(483, 73);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(179, 72);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "TÌM KIẾM";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // FrmTimKiemLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimkiemphim);
            this.Controls.Add(this.btnTimkiemrap);
            this.Controls.Add(this.GridViewTimKiemLich);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.cboPhim);
            this.Controls.Add(this.cboRap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaphim);
            this.Controls.Add(this.lblRap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTimKiemLich";
            this.Text = "Tìm kiếm lịch";
            this.Load += new System.EventHandler(this.FrmTimKiemLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTimKiemLich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRap;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Label lblMaphim;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridView GridViewTimKiemLich;
        private System.Windows.Forms.Button btnTimkiemphim;
        private System.Windows.Forms.Button btnTimkiemrap;
    }
}