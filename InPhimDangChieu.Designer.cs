namespace QuanLyRapPhim
{
    partial class InPhimDangChieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InPhimDangChieu));
            this.lblncsx = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInDTR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblncsx
            // 
            this.lblncsx.AutoSize = true;
            this.lblncsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblncsx.Location = new System.Drawing.Point(251, 25);
            this.lblncsx.Name = "lblncsx";
            this.lblncsx.Size = new System.Drawing.Size(461, 32);
            this.lblncsx.TabIndex = 74;
            this.lblncsx.Text = "DANH SÁCH PHIM ĐANG CHIẾU";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(824, 248);
            this.dataGridView1.TabIndex = 76;
            // 
            // btnInDTR
            // 
            this.btnInDTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDTR.Image = ((System.Drawing.Image)(resources.GetObject("btnInDTR.Image")));
            this.btnInDTR.Location = new System.Drawing.Point(404, 364);
            this.btnInDTR.Name = "btnInDTR";
            this.btnInDTR.Size = new System.Drawing.Size(119, 74);
            this.btnInDTR.TabIndex = 75;
            this.btnInDTR.Text = "In danh sách";
            this.btnInDTR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInDTR.UseVisualStyleBackColor = true;
            this.btnInDTR.Click += new System.EventHandler(this.btnInDTR_Click);
            // 
            // InPhimDangChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInDTR);
            this.Controls.Add(this.lblncsx);
            this.Name = "InPhimDangChieu";
            this.Text = "InPhimDangChieu";
            this.Load += new System.EventHandler(this.InPhimDangChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInDTR;
        private System.Windows.Forms.Label lblncsx;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}