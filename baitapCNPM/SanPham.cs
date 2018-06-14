using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baitapCNPM.BAL;
using System.Data.SqlClient;
using System.IO;

namespace baitapCNPM
{
    public partial class SanPham : Form
    {
        MemoryStream ms;
        byte[] arrImage;
        BL_SanPham sanpham = new BL_SanPham();
        DataSet ds = new DataSet();
        DataSet dscmbChuyen = new DataSet();
        
        bool f;
        public SanPham()
        {
            InitializeComponent();
        }
        void LoadChuyen()
        {
            try
            {

                dscmbChuyen = sanpham.LayChuyen();
                cmbChuyen.DataSource = dscmbChuyen.Tables[0];
                cmbChuyen.DisplayMember = "chucnang";
                cmbChuyen.ValueMember = "machuyen";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadData()
        {
            try
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;

                btnHuy.Enabled = false;
                btnRefresh.Enabled = false;
                panelSearch.Enabled = true;
                panelInfor.Enabled = false;
                ds = sanpham.LaySanPham();
                dgvSanPham.DataSource = ds.Tables[0];
                LoadChuyen();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Bạn không có quyền truy cập");
                this.Close();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadData();
            panelInfor.Enabled = true;
            txtMaSP.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            f = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoadData();
            panelInfor.Enabled = true;
            txtMaSP.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            f = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                int r = dgvSanPham.CurrentCell.RowIndex;

                string MaSP = dgvSanPham.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    string err = "";
                    bool trangthai = sanpham.XoaSanPham(MaSP, ref err);
                    if (trangthai)
                    {

                        MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string chuyenchuyen = "";
            if (cmbChuyen.Text == "Ti Vi")
            {
                chuyenchuyen = "Chuyen1";
            }
            else
            {
                if (cmbChuyen.Text == "Smart Phone")
                {
                    chuyenchuyen = "Chuyen2";

                }
                else
                {
                    if (cmbChuyen.Text == "Điện lạnh")
                    {
                        chuyenchuyen = "Chuyen3";

                    }
                    else
                    {
                        if (cmbChuyen.Text == "Điện gia dụng")
                        {
                            chuyenchuyen = "Chuyen4";

                        }
                        else
                        {

                            if (cmbChuyen.Text == "Thiết bị khác")
                            {
                                chuyenchuyen = "Chuyen5";

                            }
                            else
                            {

                                chuyenchuyen = "Chuyen6";

                            }

                        }
                    }
                }
            }
            try
            {
                if (f)
                {
                    string err = "";
                    bool trangthai = false;

                    //@MaSP char(10), @TenSanPham nvarchar(50), @MaChuyen char(10), @ThoiHanBaoHanh numeric(18,0), @HinhAnh image, @Gia numeric(18,0), @NgayNhap datetime, @SoLuongConLai numeric(18,0)

                    try
                    {
                        trangthai = sanpham.ThemSanPham(txtMaSP.Text, txtTenSP.Text, chuyenchuyen, int.Parse(txtBaoHanh.Text),arrImage, double.Parse(txtGia.Text), DateTime.Parse(dtpNhapHang.Text), int.Parse(txtSoLuong.Text), ref err);
                       
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (trangthai)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại!!! \n ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    

                }
                else
                {
                    string err = "";
                    bool trangthai = false;
                    
                    try
                    {
                        trangthai = sanpham.SuaSanPham(txtMaSP.Text, txtTenSP.Text, chuyenchuyen, int.Parse(txtBaoHanh.Text), arrImage, double.Parse(txtGia.Text), DateTime.Parse(dtpNhapHang.Text), int.Parse(txtSoLuong.Text), ref err);
                        
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    if (trangthai)
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin sản phẩm thất bại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                ds = sanpham.TimKiemSP(txtMaSP_Search.Text);
                dgvSanPham.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "D:\\DATA";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|(*.png)|*.png|All files (*.*)|*.*";
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                ptbImage.Image = System.Drawing.Image.FromFile(odlgOpenFile.FileName);
                //
                ms = new MemoryStream();
                ptbImage.Image.Save(ms, ptbImage.Image.RawFormat);
                arrImage = ms.GetBuffer();
                ms.Close();
            }
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //@MaSP char(10), @TenSanPham nvarchar(50), @MaChuyen char(10), @ThoiHanBaoHanh numeric(18,0), @HinhAnh image, @Gia numeric(18,0), @NgayNhap datetime, @SoLuongConLai numeric(18,0)

            int r = dgvSanPham.CurrentCell.RowIndex;
            this.txtMaSP.Text = dgvSanPham.Rows[r].Cells[0].Value.ToString();
            this.txtTenSP.Text = dgvSanPham.Rows[r].Cells[1].Value.ToString();
            this.cmbChuyen.Text = dgvSanPham.Rows[r].Cells[2].Value.ToString();
            this.txtBaoHanh.Text = dgvSanPham.Rows[r].Cells[3].Value.ToString();
            this.ptbImage.Image = (System.Drawing.Image)dgvSanPham.Rows[r].Cells[4].FormattedValue;
            this.txtGia.Text = dgvSanPham.Rows[r].Cells[5].Value.ToString();
            this.dtpNhapHang.Text = dgvSanPham.Rows[r].Cells[6].Value.ToString();
            this.txtSoLuong.Text = dgvSanPham.Rows[r].Cells[7].Value.ToString();
        }
    }
}
