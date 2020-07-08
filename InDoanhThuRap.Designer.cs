namespace QuanLyRapPhim
{
    partial class InDoanhThuRap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InDoanhThuRap));
            this.btnInDTR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRap = new System.Windows.Forms.ComboBox();
            this.lblncsx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInDTR
            // 
            this.btnInDTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDTR.Image = ((System.Drawing.Image)(resources.GetObject("btnInDTR.Image")));
            this.btnInDTR.Location = new System.Drawing.Point(175, 173);
            this.btnInDTR.Name = "btnInDTR";
            this.btnInDTR.Size = new System.Drawing.Size(119, 74);
            this.btnInDTR.TabIndex = 73;
            this.btnInDTR.Text = "In báo cáo";
            this.btnInDTR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInDTR.UseVisualStyleBackColor = true;
            this.btnInDTR.Click += new System.EventHandler(this.btnInDTR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Chọn rạp";
            // 
            // cboRap
            // 
            this.cboRap.FormattingEnabled = true;
            this.cboRap.Location = new System.Drawing.Point(148, 81);
            this.cboRap.Name = "cboRap";
            this.cboRap.Size = new System.Drawing.Size(186, 24);
            this.cboRap.TabIndex = 71;
            // 
            // lblncsx
            // 
            this.lblncsx.AutoSize = true;
            this.lblncsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblncsx.Location = new System.Drawing.Point(21, 22);
            this.lblncsx.Name = "lblncsx";
            this.lblncsx.Size = new System.Drawing.Size(401, 32);
            this.lblncsx.TabIndex = 70;
            this.lblncsx.Text = "BÁO CÁO DOANH THU RẠP";
            // 
            // InDoanhThuRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 270);
            this.Controls.Add(this.btnInDTR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRap);
            this.Controls.Add(this.lblncsx);
            this.Name = "InDoanhThuRap";
            this.Text = "InDoanhThuRap";
            this.Load += new System.EventHandler(this.InDoanhThuRap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInDTR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRap;
        private System.Windows.Forms.Label lblncsx;
    }
}