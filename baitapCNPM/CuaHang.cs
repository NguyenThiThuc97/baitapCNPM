using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace baitapCNPM
{
    public partial class CuaHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CuaHang()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool _IsActive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(baitapCNPM.NhanVien))
                {
                    form.Activate();
                    _IsActive = true;
                }
            }
            if (!_IsActive)
            {
                baitapCNPM.NhanVien PreTest = new baitapCNPM.NhanVien();
                PreTest.MdiParent = this;
                PreTest.Show();
            }
            //NhanVien nhanvien = new NhanVien();
            //this.Hide();
            //nhanvien.ShowDialog();
            //this.Show();
        }

        private void SanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            SanPham sanpham = new SanPham();
            this.Hide();
            sanpham.ShowDialog();
            this.Show();
        }

        private void KhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThuNhe.FrmKhachHang khachhang = new ThuNhe.FrmKhachHang();
            this.Hide();
            khachhang.ShowDialog();
            this.Show();
        }

        private void ThongKeTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            RP_ThongKeTonKho tonkho = new RP_ThongKeTonKho();
            this.Hide();
            tonkho.ShowDialog();
            this.Show();
        }

        private void ThietBiKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThuNhe.FrmThietBiKhachhang thietbikhachhang = new ThuNhe.FrmThietBiKhachhang();
            this.Hide();
            thietbikhachhang.ShowDialog();
            this.Show();
        }

        private void HoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThuNhe.FromLapHoaDon hd = new ThuNhe.FromLapHoaDon();
            this.Hide();
            hd.ShowDialog();
            this.Show();
        }

        private void PhieuHen_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThuNhe.FrmPhieu hd = new ThuNhe.FrmPhieu();
            this.Hide();
            hd.ShowDialog();
            this.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThuNhe.Form1 hd = new ThuNhe.Form1();
            this.Hide();
            hd.ShowDialog();
            this.Show();
        }

        private void CuaHang_Load(object sender, EventArgs e)
        {

        }
    }
}