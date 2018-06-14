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
    public class BAL_KH_SP_Phieu
    {
        //tao ket noi
        dal db = null;
        public BAL_KH_SP_Phieu()
        {
            db = new dal();
        }
        //lay thong tin san pham
        public DataSet DsKhachHang()
        {
            return db.ExecuteQueryDataSet("execute LoadDsKH", CommandType.Text, null);
        }
        //
        public DataSet _DSThietBiKH()
        {
            return db.ExecuteQueryDataSet("execute _DSThietBiKH", CommandType.Text, null);
        }
        //_DSThietBiKH
        public DataSet _sp_DsLoaiTB()
        {
            return db.ExecuteQueryDataSet("select * from Chuyen", CommandType.Text, null);
        }
        //
        public DataSet _TongHopPhieu()
        {
            return db.ExecuteQueryDataSet("execute _TongHopPhieu", CommandType.Text, null);
        }
        //_TongHopPhieu
        public DataSet TimKiemKhacHang( String SoDienThoai)
        {
            
           
                return db.ExecuteQueryDataSet("select * from DsKhachHang where SodienThoai like '%"+ SoDienThoai + "%'  ", CommandType.Text, null);
                       
        }//
        public DataSet _TongHopChiTietPhieuDK(String MaPhieu)
        {


            // return db.ExecuteQueryDataSet("exec _TongHopChiTietPhieuDK1 ('" + MaPhieu + "')", CommandType.Text, null);
            return db.ExecuteQueryDataSet(" select  ChiTietPhieu.MaThietBiKH,DSThietBiKH.TenThietBiKH from ChiTietPhieu,DsThietBiKH where MaPhieu='"+MaPhieu+"' and DSThietBiKH.MaThietBiKH=ChiTietPhieu.MaThietBiKH",CommandType.Text,null);

        }
        //
        public DataSet _TimKiemDsTBKH(String MaKH)
        {


            return db.ExecuteQueryDataSet("exec  DsTB_MaKH  '"+ MaKH + "'", CommandType.Text, null);

        }

        /* public bool ThemKhachHang(String MaKH, string Ten, string SoDienThoai, string DiaChi,ref string err)
         {
             return db.MyExecuteNonQuery("ThemKhachHang", CommandType.StoredProcedure, ref err, new SqlParameter("@MaKH", MaKH),
                 new SqlParameter("@Ten", Ten),
                 new SqlParameter("@SoDienThoai", CMND),
                 new SqlParameter("@DiaChi", SDT),
         }*/
        /* public bool XoaKH(string MaKH, ref string err)
         {
             return db.MyExecuteNonQuery("_Tg_XoaKhachHang", CommandType.StoredProcedure, ref err, new SqlParameter("@MaKH", MaKH));
         }*/
        /* public DataSet TimKiemKhacHang(String SoDienThoai, String Ten)
         {
             return db.ExecuteQueryDataSet("execute TimKiemKhachHang ('" + SoDienThoai + "','" + Ten + "')", CommandType.Text, null);
         }
         public bool XoaKH(string MaKH, ref string err)
         {
             return db.MyExecuteNonQuery("sp_XoaKhachHang", CommandType.StoredProcedure, ref err, new SqlParameter("@MaKH", MaKH));
         }
         public DataSet DsThietBiDK(String MaKH)
         {
             return db.ExecuteQueryDataSet("execute sp_DSThietBiDK22 ('" + MaKH + "')", CommandType.Text, null);
         }
         public bool CapNhatKH(String MaKH, string Ten, string SoDienThoai, string GioiTinh, string DiaChi, ref string err)
         {
             return db.MyExecuteNonQuery("SuaKhachHang", CommandType.StoredProcedure, ref err, new SqlParameter("@MaKH", MaKH),
                 new SqlParameter("@TenKH", Ten),
                 new SqlParameter("@SoDienThoai", SoDienThoai),
                 new SqlParameter("@GioiTinh", GioiTinh),
                 new SqlParameter("@DiaChi", DiaChi));
         }*/
        public bool ThemKhachHang(String MaKH, string Ten, string SoDienThoai, string GioiTinh, string DiaChi, ref string err)
        {
            return db.MyExecuteNonQuery("ThemKhachHang", CommandType.StoredProcedure, ref err, new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@TenKH", Ten),
                new SqlParameter("@SoDienThoai", SoDienThoai),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@DiaChi", DiaChi));
        }
       
        public bool ThemDSThietBiKH(String MaThietBiKH, string TenThietBiKH, string MaKH, string MaLoaiTB, string ThuocNhom, String NgayHetHanBaoHanh, ref string err)
        {
            return db.MyExecuteNonQuery("ThemDSThietBiKH", CommandType.StoredProcedure, ref err, new SqlParameter("@MaThietBiKH", MaThietBiKH),
                new SqlParameter("@TenThietBiKH", TenThietBiKH),
                new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@MaLoaiTB", MaLoaiTB),
                new SqlParameter("@ThuocNhom", ThuocNhom),
            new SqlParameter("@NgayHetHanBaoHanh", NgayHetHanBaoHanh));
        }
        //Thêm Thiet bi
        public bool ThemPhieuHen(String MaPhieu, string MaKH, string MaNhanVien, string NgayTra, ref string err)
        {
            return db.MyExecuteNonQuery("ThemPhieuHen", CommandType.StoredProcedure, ref err, new SqlParameter("@MaPhieu", MaPhieu),
                new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@MaNhanVien", MaNhanVien),
                new SqlParameter("@NgayTra", NgayTra));
        }
        //
        public bool ThemChiTietPhieuHen(String MaPhieu, string MaThietBiKH, ref string err)
        {
            return db.MyExecuteNonQuery("ThemChiTietPhieu", CommandType.StoredProcedure, ref err, new SqlParameter("@MaPhieu", MaPhieu),
                new SqlParameter("@MaThietBiKH", MaThietBiKH));
        }

        // so ngay con lai bao hanh.
        public DataSet SoNgayConLai(string MaTB)
        {

            return db.ExecuteQueryDataSet("	select dbo.ThoiGianConLai('"+ MaTB + "')", CommandType.Text, null);

        }
        //cap nhat thiet bi khi da qua htoi han.
        public bool SuaDSThietBiKH(String MaThietBiKH,string ThuocNhom, String NgayHetHanBaoHanh, ref string err)
        {
            return db.MyExecuteNonQuery("Update_DsThietBiKH_ThoiHan", CommandType.StoredProcedure, ref err, new SqlParameter("@MaThietBiKH", MaThietBiKH),
                new SqlParameter("@ThuocNhom", ThuocNhom),
             new SqlParameter("@NgayHetHanBaoHanh", NgayHetHanBaoHanh));
        }
    }
}
