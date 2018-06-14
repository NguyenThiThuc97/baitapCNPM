namespace baitapCNPM
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaSP_Search = new DevExpress.XtraEditors.TextEdit();
            this.panelSearch = new DevExpress.XtraEditors.PanelControl();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.dtpNhapHang = new System.Windows.Forms.DateTimePicker();
            this.txtTenSP = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSP = new DevExpress.XtraEditors.TextEdit();
            this.panelThaoTac = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectImg = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.panelInfor = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChuyen = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBaoHanh = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSearch)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelThaoTac)).BeginInit();
            this.panelThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInfor)).BeginInit();
            this.panelInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaoHanh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(13, 362);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(860, 353);
            this.dgvSanPham.TabIndex = 7;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Appearance.Options.UseForeColor = true;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(367, 73);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 34);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(162, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 29);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tìm kiếm sản phẩm";
            // 
            // txtMaSP_Search
            // 
            this.txtMaSP_Search.Location = new System.Drawing.Point(167, 81);
            this.txtMaSP_Search.Name = "txtMaSP_Search";
            this.txtMaSP_Search.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSP_Search.Properties.Appearance.Options.UseFont = true;
            this.txtMaSP_Search.Size = new System.Drawing.Size(170, 26);
            this.txtMaSP_Search.TabIndex = 21;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnTimKiem);
            this.panelSearch.Controls.Add(this.label11);
            this.panelSearch.Controls.Add(this.txtMaSP_Search);
            this.panelSearch.Controls.Add(this.label8);
            this.panelSearch.Location = new System.Drawing.Point(184, 222);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(525, 134);
            this.panelSearch.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(5, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mã, tên sản phẩm:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(179, 640);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Size = new System.Drawing.Size(202, 26);
            this.txtSoLuong.TabIndex = 19;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(179, 518);
            this.txtGia.Name = "txtGia";
            this.txtGia.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGia.Properties.Appearance.Options.UseFont = true;
            this.txtGia.Size = new System.Drawing.Size(202, 26);
            this.txtGia.TabIndex = 17;
            // 
            // dtpNhapHang
            // 
            this.dtpNhapHang.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNhapHang.Location = new System.Drawing.Point(229, 575);
            this.dtpNhapHang.Name = "dtpNhapHang";
            this.dtpNhapHang.Size = new System.Drawing.Size(200, 26);
            this.dtpNhapHang.TabIndex = 16;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(179, 347);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSP.Properties.Appearance.Options.UseFont = true;
            this.txtTenSP.Size = new System.Drawing.Size(202, 26);
            this.txtTenSP.TabIndex = 13;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(179, 291);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSP.Properties.Appearance.Options.UseFont = true;
            this.txtMaSP.Size = new System.Drawing.Size(202, 26);
            this.txtMaSP.TabIndex = 11;
            // 
            // panelThaoTac
            // 
            this.panelThaoTac.Controls.Add(this.btnRefresh);
            this.panelThaoTac.Controls.Add(this.btnHuy);
            this.panelThaoTac.Controls.Add(this.btnLuu);
            this.panelThaoTac.Controls.Add(this.btnXoa);
            this.panelThaoTac.Controls.Add(this.btnSua);
            this.panelThaoTac.Controls.Add(this.btnThem);
            this.panelThaoTac.Location = new System.Drawing.Point(12, 72);
            this.panelThaoTac.Name = "panelThaoTac";
            this.panelThaoTac.Size = new System.Drawing.Size(861, 112);
            this.panelThaoTac.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseForeColor = true;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(712, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 43);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Appearance.Options.UseForeColor = true;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(572, 25);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 42);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(429, 25);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 42);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(291, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 42);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Appearance.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(155, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 41);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Appearance.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(22, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 41);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectImg.Appearance.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSelectImg.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectImg.Appearance.Options.UseFont = true;
            this.btnSelectImg.Appearance.Options.UseForeColor = true;
            this.btnSelectImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectImg.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSelectImg.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectImg.Image")));
            this.btnSelectImg.Location = new System.Drawing.Point(204, 206);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(138, 43);
            this.btnSelectImg.TabIndex = 6;
            this.btnSelectImg.Text = "Chọn hình";
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(35, 640);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(35, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(35, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thời gian nhập hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(35, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(35, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // ptbImage
            // 
            this.ptbImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptbImage.Location = new System.Drawing.Point(39, 60);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(148, 189);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 1;
            this.ptbImage.TabStop = false;
            // 
            // panelInfor
            // 
            this.panelInfor.Controls.Add(this.txtBaoHanh);
            this.panelInfor.Controls.Add(this.label3);
            this.panelInfor.Controls.Add(this.cmbChuyen);
            this.panelInfor.Controls.Add(this.label10);
            this.panelInfor.Controls.Add(this.txtSoLuong);
            this.panelInfor.Controls.Add(this.txtGia);
            this.panelInfor.Controls.Add(this.dtpNhapHang);
            this.panelInfor.Controls.Add(this.txtTenSP);
            this.panelInfor.Controls.Add(this.txtMaSP);
            this.panelInfor.Controls.Add(this.btnSelectImg);
            this.panelInfor.Controls.Add(this.label9);
            this.panelInfor.Controls.Add(this.label7);
            this.panelInfor.Controls.Add(this.label6);
            this.panelInfor.Controls.Add(this.label4);
            this.panelInfor.Controls.Add(this.label2);
            this.panelInfor.Controls.Add(this.ptbImage);
            this.panelInfor.Controls.Add(this.label1);
            this.panelInfor.Location = new System.Drawing.Point(879, 12);
            this.panelInfor.Name = "panelInfor";
            this.panelInfor.Size = new System.Drawing.Size(458, 703);
            this.panelInfor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(85, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sản phẩm";
            // 
            // cmbChuyen
            // 
            this.cmbChuyen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbChuyen.FormattingEnabled = true;
            this.cmbChuyen.Location = new System.Drawing.Point(179, 406);
            this.cmbChuyen.Name = "cmbChuyen";
            this.cmbChuyen.Size = new System.Drawing.Size(202, 27);
            this.cmbChuyen.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(35, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Chuyền:";
            // 
            // txtBaoHanh
            // 
            this.txtBaoHanh.Location = new System.Drawing.Point(229, 463);
            this.txtBaoHanh.Name = "txtBaoHanh";
            this.txtBaoHanh.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBaoHanh.Properties.Appearance.Options.UseFont = true;
            this.txtBaoHanh.Size = new System.Drawing.Size(152, 26);
            this.txtBaoHanh.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(35, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Thời gian bảo hành:";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 724);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelThaoTac);
            this.Controls.Add(this.panelInfor);
            this.Name = "SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSearch)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelThaoTac)).EndInit();
            this.panelThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInfor)).EndInit();
            this.panelInfor.ResumeLayout(false);
            this.panelInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaoHanh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtMaSP_Search;
        private DevExpress.XtraEditors.PanelControl panelSearch;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private System.Windows.Forms.DateTimePicker dtpNhapHang;
        private DevExpress.XtraEditors.TextEdit txtTenSP;
        private DevExpress.XtraEditors.TextEdit txtMaSP;
        private DevExpress.XtraEditors.PanelControl panelThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSelectImg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbImage;
        private DevExpress.XtraEditors.PanelControl panelInfor;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtBaoHanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChuyen;
        private System.Windows.Forms.Label label10;
    }
}