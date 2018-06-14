namespace ThuNhe
{
    partial class FrmKhachHang
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnExe = new System.Windows.Forms.Button();
            this.BtnQuayLoai = new System.Windows.Forms.Button();
            this.BtnChinhSua = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RaBtnNam = new System.Windows.Forms.RadioButton();
            this.RaBtnNu = new System.Windows.Forms.RadioButton();
            this.TxtMaKH2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSoDienThoai2 = new System.Windows.Forms.TextBox();
            this.TxtKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DaViewDsKH = new System.Windows.Forms.DataGridView();
            this.BtnXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaViewDsKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnExe);
            this.groupBox4.Controls.Add(this.BtnQuayLoai);
            this.groupBox4.Controls.Add(this.BtnChinhSua);
            this.groupBox4.Controls.Add(this.BtnOK);
            this.groupBox4.Controls.Add(this.TxtDiaChi);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.TxtMaKH2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.TxtSoDienThoai2);
            this.groupBox4.Controls.Add(this.TxtKH);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(121, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(943, 154);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin Khách hàng";
            // 
            // BtnExe
            // 
            this.BtnExe.BackColor = System.Drawing.Color.Silver;
            this.BtnExe.Location = new System.Drawing.Point(801, 107);
            this.BtnExe.Name = "BtnExe";
            this.BtnExe.Size = new System.Drawing.Size(91, 27);
            this.BtnExe.TabIndex = 25;
            this.BtnExe.Text = "Xuất Excel ";
            this.BtnExe.UseVisualStyleBackColor = false;
            this.BtnExe.Click += new System.EventHandler(this.BtnExe_Click);
            // 
            // BtnQuayLoai
            // 
            this.BtnQuayLoai.BackColor = System.Drawing.Color.Silver;
            this.BtnQuayLoai.Location = new System.Drawing.Point(704, 106);
            this.BtnQuayLoai.Name = "BtnQuayLoai";
            this.BtnQuayLoai.Size = new System.Drawing.Size(91, 27);
            this.BtnQuayLoai.TabIndex = 24;
            this.BtnQuayLoai.Text = "Quay lai";
            this.BtnQuayLoai.UseVisualStyleBackColor = false;
            this.BtnQuayLoai.Click += new System.EventHandler(this.BtnQuayLoai_Click);
            // 
            // BtnChinhSua
            // 
            this.BtnChinhSua.BackColor = System.Drawing.Color.Silver;
            this.BtnChinhSua.Location = new System.Drawing.Point(619, 107);
            this.BtnChinhSua.Name = "BtnChinhSua";
            this.BtnChinhSua.Size = new System.Drawing.Size(79, 28);
            this.BtnChinhSua.TabIndex = 15;
            this.BtnChinhSua.Text = "Chỉnh sửa";
            this.BtnChinhSua.UseVisualStyleBackColor = false;
            this.BtnChinhSua.Click += new System.EventHandler(this.BtnChinhSua_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.Color.Silver;
            this.BtnOK.Location = new System.Drawing.Point(534, 107);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(79, 28);
            this.BtnOK.TabIndex = 14;
            this.BtnOK.Text = "Tìm kiếm";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtDiaChi
            // 
            this.TxtDiaChi.Location = new System.Drawing.Point(112, 106);
            this.TxtDiaChi.Multiline = true;
            this.TxtDiaChi.Name = "TxtDiaChi";
            this.TxtDiaChi.Size = new System.Drawing.Size(373, 28);
            this.TxtDiaChi.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Địa chỉ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RaBtnNam);
            this.groupBox5.Controls.Add(this.RaBtnNu);
            this.groupBox5.Location = new System.Drawing.Point(387, 53);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 47);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // RaBtnNam
            // 
            this.RaBtnNam.AutoSize = true;
            this.RaBtnNam.Location = new System.Drawing.Point(95, 12);
            this.RaBtnNam.Name = "RaBtnNam";
            this.RaBtnNam.Size = new System.Drawing.Size(55, 20);
            this.RaBtnNam.TabIndex = 1;
            this.RaBtnNam.TabStop = true;
            this.RaBtnNam.Text = "Nam";
            this.RaBtnNam.UseVisualStyleBackColor = true;
            // 
            // RaBtnNu
            // 
            this.RaBtnNu.AutoSize = true;
            this.RaBtnNu.Location = new System.Drawing.Point(18, 15);
            this.RaBtnNu.Name = "RaBtnNu";
            this.RaBtnNu.Size = new System.Drawing.Size(43, 20);
            this.RaBtnNu.TabIndex = 0;
            this.RaBtnNu.TabStop = true;
            this.RaBtnNu.Text = "Nữ";
            this.RaBtnNu.UseVisualStyleBackColor = true;
            // 
            // TxtMaKH2
            // 
            this.TxtMaKH2.Location = new System.Drawing.Point(112, 26);
            this.TxtMaKH2.Name = "TxtMaKH2";
            this.TxtMaKH2.Size = new System.Drawing.Size(168, 21);
            this.TxtMaKH2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã Khách hàng";
            // 
            // TxtSoDienThoai2
            // 
            this.TxtSoDienThoai2.Location = new System.Drawing.Point(112, 66);
            this.TxtSoDienThoai2.Name = "TxtSoDienThoai2";
            this.TxtSoDienThoai2.Size = new System.Drawing.Size(168, 21);
            this.TxtSoDienThoai2.TabIndex = 7;
            // 
            // TxtKH
            // 
            this.TxtKH.Location = new System.Drawing.Point(387, 26);
            this.TxtKH.Name = "TxtKH";
            this.TxtKH.Size = new System.Drawing.Size(152, 21);
            this.TxtKH.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên KH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DaViewDsKH);
            this.groupBox1.Location = new System.Drawing.Point(70, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 382);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // DaViewDsKH
            // 
            this.DaViewDsKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaViewDsKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnXoa});
            this.DaViewDsKH.Location = new System.Drawing.Point(30, 38);
            this.DaViewDsKH.Name = "DaViewDsKH";
            this.DaViewDsKH.Size = new System.Drawing.Size(816, 338);
            this.DaViewDsKH.TabIndex = 0;
            this.DaViewDsKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaViewDsKH_CellContentClick);
            // 
            // BtnXoa
            // 
            this.BtnXoa.HeaderText = "Xóa";
            this.BtnXoa.Name = "BtnXoa";
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1137, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKhachHang";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DaViewDsKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox TxtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton RaBtnNam;
        private System.Windows.Forms.RadioButton RaBtnNu;
        private System.Windows.Forms.TextBox TxtMaKH2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSoDienThoai2;
        private System.Windows.Forms.TextBox TxtKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DaViewDsKH;
        private System.Windows.Forms.DataGridViewImageColumn BtnXoa;
        private System.Windows.Forms.Button BtnChinhSua;
        private System.Windows.Forms.Button BtnQuayLoai;
        private System.Windows.Forms.Button BtnExe;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}