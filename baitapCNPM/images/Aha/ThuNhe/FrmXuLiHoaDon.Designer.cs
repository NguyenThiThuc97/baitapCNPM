namespace ThuNhe
{
    partial class FrmXuLiHoaDon
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtHoaDon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DaHD = new System.Windows.Forms.DataGridView();
            this.BtnXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DaCTHD = new System.Windows.Forms.DataGridView();
            this.BtnXoaCt = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaHD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TxtHoaDon);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(208, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(313, 91);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin Hóa đơn";
            // 
            // TxtHoaDon
            // 
            this.TxtHoaDon.Location = new System.Drawing.Point(96, 31);
            this.TxtHoaDon.Name = "TxtHoaDon";
            this.TxtHoaDon.Size = new System.Drawing.Size(123, 20);
            this.TxtHoaDon.TabIndex = 6;
            this.TxtHoaDon.TextChanged += new System.EventHandler(this.TxtHoaDon_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DaHD);
            this.groupBox1.Location = new System.Drawing.Point(17, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 321);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Hóa đơn";
            // 
            // DaHD
            // 
            this.DaHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnXoa});
            this.DaHD.Location = new System.Drawing.Point(16, 20);
            this.DaHD.Name = "DaHD";
            this.DaHD.Size = new System.Drawing.Size(544, 295);
            this.DaHD.TabIndex = 0;
            this.DaHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaHD_CellClick);
            this.DaHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaHD_CellContentClick);
            // 
            // BtnXoa
            // 
            this.BtnXoa.HeaderText = "Xóa";
            this.BtnXoa.Name = "BtnXoa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DaCTHD);
            this.groupBox2.Location = new System.Drawing.Point(601, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 321);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // DaCTHD
            // 
            this.DaCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnXoaCt});
            this.DaCTHD.Location = new System.Drawing.Point(30, 19);
            this.DaCTHD.Name = "DaCTHD";
            this.DaCTHD.Size = new System.Drawing.Size(690, 296);
            this.DaCTHD.TabIndex = 0;
            this.DaCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaCTHD_CellContentClick);
            // 
            // BtnXoaCt
            // 
            this.BtnXoaCt.HeaderText = "Xóa";
            this.BtnXoaCt.Name = "BtnXoaCt";
            // 
            // FrmXuLiHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1428, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "FrmXuLiHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmXuLiHoaDon";
            this.Load += new System.EventHandler(this.FrmXuLiHoaDon_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DaHD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DaCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxtHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DaHD;
        private System.Windows.Forms.DataGridViewImageColumn BtnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DaCTHD;
        private System.Windows.Forms.DataGridViewImageColumn BtnXoaCt;
    }
}