using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ThuNhe.DALPlayer;
namespace ThuNhe.BALPlayer
{
   public class BAL_LapHD
    {
        //tao ket noi
        dal db = null;
        public BAL_LapHD()
        {
            db = new dal();
        }
        //lay thong tin san pham
        public DataSet DsKhachHang()
        {
            return db.ExecuteQueryDataSet("execute LoadDsKH", CommandType.Text, null);
        }
        //
        //lay thong tin san pham
        public DataSet DsHoaDon()
        {
            return db.ExecuteQueryDataSet("select * from HoaDon", CommandType.Text, null);
        }
        //
        //bang Hoa Don
        public DataSet DsHD()
        {
            return db.ExecuteQueryDataSet("select MaHD from HoaDon", CommandType.Text, null);
        }
        //
        //_tim kiem khach hang.
        public DataSet TimKiemKhacHang(String SoDienThoai)
        {
            return db.ExecuteQueryDataSet("select * from DsKhachHang where SodienThoai like '%" + SoDienThoai + "%'  ", CommandType.Text, null);
        }//
        public DataSet DanhSachPhieuDK(String MaKH)
        {
            return db.ExecuteQueryDataSet("select  MaPhieu,MaNhanVien,NgayLap,NgayTra from Phieu where MaKH='" + MaKH + "' group by MaPhieu,MaNhanVien,NgayLap,NgayTra ", CommandType.Text, null);
        }
        public DataSet DanhSachCTPhieuDK(String MaPhieu)
        {
            return db.ExecuteQueryDataSet("select  MaThietBiKH from ChiTietPhieu where MaPhieu='" + MaPhieu + "' group by MaPhieu,MaThietBiKH ", CommandType.Text, null);
        }


        public DataSet LayTenSp()
        {
            return db.ExecuteQueryDataSet("select MaSP,TenSP,Gia,ThoiHanBaoHanh,SoLuong from SanPham ", CommandType.Text, null);
        }

        public DataSet _TimKiemMaSP(String MaSP)
        {

            return db.ExecuteQueryDataSet("  select* from SanPham where MaSP='" + MaSP + "'", CommandType.Text, null);

        }
        //tim kiem hoa don
        public DataSet _TimKiemHD(String MaHD)
        {

            return db.ExecuteQueryDataSet("  select MaHD from HoaDon where MaSP='" + MaHD + "'", CommandType.Text, null);

        }
        /// them chi tiet hoa don
        public bool sp_ThemChiTietHDHoaDon(String MaHD, string MaThietBiKH, string MaThietBiCY, string MaNHanVienSuaChua, string TinhTrangTB, string ChiTietSuaCHua, String DonGia, String SoLuong, String ThanhTien,String GhiChu,String @TrucTrac, ref string err)
        {
            return db.MyExecuteNonQuery("sp_ThemChiTietHDHoaDon", CommandType.StoredProcedure, ref err, new SqlParameter("@MaHD", MaHD),
                new SqlParameter("@MaThietBiKH", MaThietBiKH),
                 new SqlParameter("@MaThietBiCY", MaThietBiCY),
                new SqlParameter("@MaNHanVienSuaChua", MaNHanVienSuaChua),
                new SqlParameter("@TinhTrangTB", TinhTrangTB),
                new SqlParameter("@ChiTietSuaCHua", ChiTietSuaCHua),
            new SqlParameter("@DonGia", DonGia),
            new SqlParameter("@SoLuong", SoLuong),
            new SqlParameter("@ThanhTien", ThanhTien),
             new SqlParameter("@GhiChu", GhiChu),
                 new SqlParameter("@TrucTrac", TrucTrac));

        }
        //them hoa don
        public bool sp_ThemHoaDon(String MaHD, string MaKH, string MaNhanVienHD, string ChiPhiChinhSua, string ChiPhiLinhKien,String TongChiPhi, ref string err)
        {
            return db.MyExecuteNonQuery("sp_ThemHoaDon", CommandType.StoredProcedure, ref err, new SqlParameter("@MaHD", MaHD),
                new SqlParameter("@MaKH", MaKH),
                 new SqlParameter("@MaNhanVienHD", MaNhanVienHD),
                new SqlParameter("@ChiPhiChinhSua", ChiPhiChinhSua),
                new SqlParameter("@ChiPhiLinhKien", ChiPhiLinhKien),
                new SqlParameter("@TongChiPhi", TongChiPhi));

        }
        //lay tong thanh tien
        public DataSet TongTien(String MaHD)
        {

            return db.ExecuteQueryDataSet("  select dbo.TinhHoaDon ('"+ MaHD + "')", CommandType.Text, null);

        }
        //lay so luong thiet bi
        //lay tong thanh tien
        public DataSet TongThietBi(String MaHD)
        {

            return db.ExecuteQueryDataSet(" select dbo.ChiPhiLK ('"+ MaHD + "')", CommandType.Text, null);

        }
        public DataSet TongCPSC(String MaHD)
        {

            return db.ExecuteQueryDataSet("select dbo.CPSC ('"+ MaHD + "')", CommandType.Text, null);

        }
        //sửa Hóa đơn
        public bool SuaHoaDon(String MaHD, string ChiPhiChinhSua, string ChiPhiLinhKien, String TongChiPhi, ref string err)
        {
            return db.MyExecuteNonQuery("SuaHoaDonIt", CommandType.StoredProcedure, ref err, new SqlParameter("@MaHD", MaHD),
                new SqlParameter("@ChiPhiSuaChua", ChiPhiChinhSua),
                new SqlParameter("@ChiPhiLinhKien", ChiPhiLinhKien),
                new SqlParameter("@TongChiPhi", TongChiPhi));
        }
        //
        public DataSet DsCTHD(String MaHD)
        {

            return db.ExecuteQueryDataSet(" select MathietBiKH,MaThietBiCY,MaNHanVienSuaChua,"

           +" TinhTrangTB, ChiTietSuaCHua, DonGia, SoLuong, ThanhTien, GhiChu from ChiTietHoaDon where ChiTietHoaDon.MaHD = '"+MaHD+"' group by ChiTietHoaDon.MaHD, MathietBiKH, MaThietBiCY, MaNHanVienSuaChua,"
           +" TinhTrangTB, ChiTietSuaCHua, DonGia, SoLuong, ThanhTien, GhiChu", CommandType.Text, null);

        }
        //kiem tra co bao hanh hay ko  
        
    }
}
