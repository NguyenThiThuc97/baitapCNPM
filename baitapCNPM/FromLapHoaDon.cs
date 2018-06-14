using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using baitapCNPM.BAL;
namespace ThuNhe
{
    public partial class FromLapHoaDon : Form
    {
        BAL_LapHD kh = new BAL_LapHD();
        DataSet ds = new DataSet();
        public FromLapHoaDon()
        {
            InitializeComponent();
        }

        private void DaKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = DaKH.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            String Bien =
              DaKH.Rows[r].Cells[0].Value.ToString();
            ds = kh.DanhSachPhieuDK(Bien);
            DaPhieu.DataSource = ds.Tables[0];
            //
            TxtMAKH.Text = Bien;

            //

        }

        private void FromLapHoaDon_Load(object sender, EventArgs e)
        {
            TxtSL.Text = "0";
            TxtThanhTien.Text = "0";
            ds = kh.DsKhachHang();
            DaKH.DataSource = ds.Tables[0];
            //
            ds = kh.LayTenSp();
            DaSP.DataSource = ds.Tables[0];
            // ds = kh.LayTenSp();
            // DaSanPham.DataSource = ds.Tables[0];
            //

            // ds = kh.DsHD();
            //  DaHD.DataSource = ds.Tables[0];
            ds = kh.DsHoaDon();
            DaHD.DataSource = ds.Tables[0];
            //
            ds = kh.DsCTHD(TxtHoaDon.Text);
            DaCTHD.DataSource = ds.Tables[0];
        }
        private void DaPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = DaPhieu.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            String Bien =
              DaPhieu.Rows[r].Cells[0].Value.ToString();
            ds = kh.DanhSachCTPhieuDK(Bien);
            DaTB.DataSource = ds.Tables[0];
        }

        private void BtnOKHD_Click(object sender, EventArgs e)
        {
            string err = "";
            bool trangthai = false;
            try
            {
                trangthai = kh.sp_ThemHoaDon(TxtHoaDon.Text, TxtMAKH.Text, TxtMaNV.Text, "", "", "", ref err);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (trangthai)
            {
                MessageBox.Show("Thêm dữ liệu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds = kh.DsHoaDon();
                DaHD.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DaSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành select MaSP,TenSP,Gia,ThoiHanBaoHanh,SoLuong from SanPham
            int r = DaSP.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            TxtMaSP.Text =
                 DaSP.Rows[r].Cells[0].Value.ToString();
            TxtDonGia.Text =
              DaSP.Rows[r].Cells[2].Value.ToString();
            TxtGhiChu.Text =
            DaSP.Rows[r].Cells[3].Value.ToString();

        }

        private void BttOkey_Click(object sender, EventArgs e)
        {
            String dk = "";
            string err = "";
            bool trangthai = false;
            if (Ck_TrucTrac.Checked)
                dk = "Sửa chữa";
            else
                dk = "";
            try
            {
                trangthai = kh.sp_ThemChiTietHDHoaDon(TxtHoaDon.Text, TxtMaTBKH.Text, TxtMaSP.Text, TxtMaNVSC.Text, TxtTinhTRang.Text, TxtCTSC.Text, TxtDonGia.Text, TxtSL.Text, TxtThanhTien.Text, TxtGhiChu.Text, dk, ref err);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (trangthai)
            {
                MessageBox.Show("Thêm dữ liệu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds = kh.DsCTHD(TxtHoaDon.Text);
                DaCTHD.DataSource = ds.Tables[0];
                //
                //ds = kh.KiemTra(TxtMaTBKH.Text);
                // DaCTHD.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double t = double.Parse(TxtDonGia.Text.ToString());
                double t1 = double.Parse(TxtSL.Text.ToString());
                double t2 = t * t1;
                TxtThanhTien.Text = t2 + "";
            }
            catch (Exception)
            { }
        }

        private void BtnKetThuc_Click(object sender, EventArgs e)
        {
            ds = kh.TongTien(TxtHoaDon.Text);
          TxtTCP.Text = ds.Tables[0].Rows[0][0].ToString();
            //
            //
            ds = kh.TongThietBi(TxtHoaDon.Text);
            TxtCPLK.Text = ds.Tables[0].Rows[0][0].ToString();
            //
            ds = kh.TongThietBi(TxtHoaDon.Text);
            TxtCPSC.Text = ds.Tables[0].Rows[0][0].ToString();
            //
            //sua hoa don.
            // String Bien2 = "";
            string err = "";
            bool trangthai = false;
            try
            {
                trangthai = kh.SuaHoaDon(TxtHoaDon.Text, TxtCPSC.Text, TxtCPLK.Text, TxtTCP.Text, ref err);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            if (trangthai)
            {
                MessageBox.Show("Cập nhật hóa đơn thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds = kh.DsHoaDon();
                DaHD.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không sữa được dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtThanhToan_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void TxtThanhToan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double Tien = double.Parse(TxtTCP.Text.ToString()) - double.Parse(TxtThanhToan.Text.ToString());
                TxtCLai.Text = Tien + "";
            }
            catch (Exception)
            { }

            
        }

        private void DaTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành select MaSP,TenSP,Gia,ThoiHanBaoHanh,SoLuong from SanPham
            int r = DaTB.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            TxtMaTBKH.Text =
                 DaTB.Rows[r].Cells[0].Value.ToString();
        }

        private void TxtLamLai_Click(object sender, EventArgs e)
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = string.Empty;
                }
            }
        }

        private void TxtSdt_TextChanged(object sender, EventArgs e)
        {

            ds = kh.TimKiemKhacHang(TxtSdt.Text);
            DaKH.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ck_TrucTrac_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtInHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
