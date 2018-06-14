namespace ThuNhe
{
    partial class FrmPhieu
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
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.BtnQuayLoai = new System.Windows.Forms.Button();
            this.BtnCHinhSua = new System.Windows.Forms.Button();
            this.BtnTimKiem = new System.Windows.Forms.Button();
            this.Txt_NgayTra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_MaPhieu = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DaViewDSPhieu = new System.Windows.Forms.DataGridView();
            this.BtnXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DaViewDSCTP = new System.Windows.Forms.DataGridView();
            this.Btn_Xoa2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaViewDSPhieu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaViewDSCTP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.BtnQuayLoai);
            this.groupBox11.Controls.Add(this.BtnCHinhSua);
            this.groupBox11.Controls.Add(this.BtnTimKiem);
            this.groupBox11.Controls.Add(this.Txt_NgayTra);
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Controls.Add(this.Txt_MaPhieu);
            this.groupBox11.Controls.Add(this.label19);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox11.Location = new System.Drawing.Point(245, 25);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(723, 127);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Thông Tin Phiếu";
            // 
            // BtnQuayLoai
            // 
            this.BtnQuayLoai.BackColor = System.Drawing.Color.Silver;
            this.BtnQuayLoai.Location = new System.Drawing.Point(479, 83);
            this.BtnQuayLoai.Name = "BtnQuayLoai";
            this.BtnQuayLoai.Size = new System.Drawing.Size(111, 26);
            this.BtnQuayLoai.TabIndex = 23;
            this.BtnQuayLoai.Text = "Quay lai";
            this.BtnQuayLoai.UseVisualStyleBackColor = false;
            this.BtnQuayLoai.Click += new System.EventHandler(this.BtnQuayLoai_Click);
            // 
            // BtnCHinhSua
            // 
            this.BtnCHinhSua.BackColor = System.Drawing.Color.Silver;
            this.BtnCHinhSua.Location = new System.Drawing.Point(612, 83);
            this.BtnCHinhSua.Name = "BtnCHinhSua";
            this.BtnCHinhSua.Size = new System.Drawing.Size(99, 26);
            this.BtnCHinhSua.TabIndex = 22;
            this.BtnCHinhSua.Text = "CHỉnh sửa";
            this.BtnCHinhSua.UseVisualStyleBackColor = false;
            this.BtnCHinhSua.Click += new System.EventHandler(this.BtnCHinhSua_Click);
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.BackColor = System.Drawing.Color.Silver;
            this.BtnTimKiem.Location = new System.Drawing.Point(351, 83);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(109, 26);
            this.BtnTimKiem.TabIndex = 21;
            this.BtnTimKiem.Text = "Tìm kiếm";
            this.BtnTimKiem.UseVisualStyleBackColor = false;
            this.BtnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // Txt_NgayTra
            // 
            this.Txt_NgayTra.Location = new System.Drawing.Point(372, 28);
            this.Txt_NgayTra.Name = "Txt_NgayTra";
            this.Txt_NgayTra.Size = new System.Drawing.Size(168, 21);
            this.Txt_NgayTra.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(304, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Ngày trả";
            // 
            // Txt_MaPhieu
            // 
            this.Txt_MaPhieu.Location = new System.Drawing.Point(112, 23);
            this.Txt_MaPhieu.Name = "Txt_MaPhieu";
            this.Txt_MaPhieu.Size = new System.Drawing.Size(168, 21);
            this.Txt_MaPhieu.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 16);
            this.label19.TabIndex = 11;
            this.label19.Text = "Mã Phiếu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DaViewDSPhieu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(75, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 297);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Phiếu";
            // 
            // DaViewDSPhieu
            // 
            this.DaViewDSPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaViewDSPhieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnXoa});
            this.DaViewDSPhieu.Location = new System.Drawing.Point(25, 30);
            this.DaViewDSPhieu.Name = "DaViewDSPhieu";
            this.DaViewDSPhieu.Size = new System.Drawing.Size(623, 232);
            this.DaViewDSPhieu.TabIndex = 0;
            this.DaViewDSPhieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaViewDSPhieu_CellContentClick);
            // 
            // BtnXoa
            // 
            this.BtnXoa.HeaderText = "Xóa";
            this.BtnXoa.Name = "BtnXoa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DaViewDSCTP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(761, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 288);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết phiếu";
            // 
            // DaViewDSCTP
            // 
            this.DaViewDSCTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaViewDSCTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Btn_Xoa2});
            this.DaViewDSCTP.Location = new System.Drawing.Point(17, 21);
            this.DaViewDSCTP.Name = "DaViewDSCTP";
            this.DaViewDSCTP.Size = new System.Drawing.Size(261, 204);
            this.DaViewDSCTP.TabIndex = 0;
            this.DaViewDSCTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaViewDSCTP_CellContentClick);
            // 
            // Btn_Xoa2
            // 
            this.Btn_Xoa2.HeaderText = "Xóa";
            this.Btn_Xoa2.Name = "Btn_Xoa2";
            // 
            // FrmPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1120, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox11);
            this.Name = "FrmPhieu";
            this.Text = "FrmPhieu";
            this.Load += new System.EventHandler(this.FrmPhieu_Load);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DaViewDSPhieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DaViewDSCTP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button BtnTimKiem;
        private System.Windows.Forms.TextBox Txt_NgayTra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_MaPhieu;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DaViewDSPhieu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewImageColumn BtnXoa;
        private System.Windows.Forms.DataGridView DaViewDSCTP;
        private System.Windows.Forms.Button BtnCHinhSua;
        private System.Windows.Forms.Button BtnQuayLoai;
        private System.Windows.Forms.DataGridViewImageColumn Btn_Xoa2;
    }
}