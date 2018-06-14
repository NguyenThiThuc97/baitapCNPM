using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using baitapCNPM.DAL;
using System.Drawing;


namespace baitapCNPM.BAL
{
    class BL_SanPham
    {
        DBMain db = null;
        public BL_SanPham()
        {
            db = new DBMain();

        }
        public DataSet LayChuyen()
        {
            return db.ExecuteQueryDataSet("select * from Chuyen", CommandType.Text);
        }
        public DataSet LaySanPham()
        {
            return db.ExecuteQueryDataSet("select MaSP, TenSP, ChucNang, ThoiHanBaoHanh, HinhAnh, Gia, ThoiGianNhapHang, SoLuong from sanpham, chuyen where sanpham.MaChuyen=Chuyen.MaChuyen", CommandType.Text);

        }
        //@MaSP char(10), @TenSanPham nvarchar(50), @MaChuyen char(10), @ThoiHanBaoHanh numeric(18,0), @HinhAnh image, @Gia numeric(18,0), @NgayNhap datetime, @SoLuongConLai numeric(18,0)
        public bool ThemSanPham(string masp, string tensp, string chuyen, int baohanh, byte[] hinhanh, double gia, DateTime ngaynhap, int soluongconlai, ref string err)
        {
            return db.MyExecuteNonQuery("ThemSanPham", CommandType.StoredProcedure, ref err, new SqlParameter("@MaSP", masp)
                                                                                                , new SqlParameter("@TenSanPham", tensp)
                                                                                                , new SqlParameter("@MaChuyen", chuyen)
                                                                                                , new SqlParameter("@ThoiHanBaoHanh", baohanh)
                                                                                                , new SqlParameter("@HinhAnh", hinhanh)
                                                                                                , new SqlParameter("@Gia", gia)
                                                                                                , new SqlParameter("@NgayNhap", ngaynhap)
                                                                                                , new SqlParameter("@SoLuongConLai", soluongconlai));

        }
        public bool SuaSanPham(string masp, string tensp, string chuyen, int baohanh, byte[] hinhanh, double gia, DateTime ngaynhap, int soluongconlai, ref string err)
        {
            return db.MyExecuteNonQuery("CapNhatSanPham", CommandType.StoredProcedure, ref err, new SqlParameter("@MaSP", masp)
                                                                                                , new SqlParameter("@TenSanPham", tensp)
                                                                                                , new SqlParameter("@MaChuyen", chuyen)
                                                                                                , new SqlParameter("@ThoiHanBaoHanh", baohanh)
                                                                                                , new SqlParameter("@HinhAnh", hinhanh)
                                                                                                , new SqlParameter("@Gia", gia)
                                                                                                , new SqlParameter("@NgayNhap", ngaynhap)
                                                                                                , new SqlParameter("@SoLuongConLai", soluongconlai));

        }
        public bool XoaSanPham(string masp, ref string err)
        {
            return db.MyExecuteNonQuery("XoaSanPham", CommandType.StoredProcedure, ref err, new SqlParameter("@MaSP", masp));

        }
        public DataSet TimKiemSP(string strTimKiem)
        {
            return db.ExecuteQueryDataSet("exec TimKiemSP '" + strTimKiem + "'", CommandType.Text);
        }
        public DataSet SPTonKho(int nam)
        {
            return db.ExecuteQueryDataSet("exec ThongKeTonKho "+nam, CommandType.Text);
        }
    }
}
