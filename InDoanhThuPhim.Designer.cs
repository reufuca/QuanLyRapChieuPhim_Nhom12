namespace QuanLyRapPhim
{
    partial class InDoanhThuPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InDoanhThuPhim));
            this.lblncsx = new System.Windows.Forms.Label();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInDTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblncsx
            // 
            this.lblncsx.AutoSize = true;
            this.lblncsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblncsx.Location = new System.Drawing.Point(58, 22);
            this.lblncsx.Name = "lblncsx";
            this.lblncsx.Size = new System.Drawing.Size(413, 32);
            this.lblncsx.TabIndex = 66;
            this.lblncsx.Text = "BÁO CÁO DOANH THU PHIM";
            // 
            // cboPhim
            // 
            this.cboPhim.FormattingEnabled = true;
            this.cboPhim.Location = new System.Drawing.Point(185, 81);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(186, 24);
            this.cboPhim.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Chọn phim";
            // 
            // btnInDTP
            // 
            this.btnInDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDTP.Image = ((System.Drawing.Image)(resources.GetObject("btnInDTP.Image")));
            this.btnInDTP.Location = new System.Drawing.Point(212, 173);
            this.btnInDTP.Name = "btnInDTP";
            this.btnInDTP.Size = new System.Drawing.Size(119, 74);
            this.btnInDTP.TabIndex = 69;
            this.btnInDTP.Text = "In báo cáo";
            this.btnInDTP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInDTP.UseVisualStyleBackColor = true;
            this.btnInDTP.Click += new System.EventHandler(this.btnInDTP_Click);
            // 
            // InDoanhThuPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 290);
            this.Controls.Add(this.btnInDTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPhim);
            this.Controls.Add(this.lblncsx);
            this.Name = "InDoanhThuPhim";
            this.Text = "Doanh thu Phim";
            this.Load += new System.EventHandler(this.InDoanhThuPhim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblncsx;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInDTP;
    }
}