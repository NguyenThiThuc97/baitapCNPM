using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using baitapCNPM.DAL;
namespace baitapCNPM.BAL
{
   public class BAL_XuLyHoaDon
    {
        DBMain db = null;
        public BAL_XuLyHoaDon()
        {
            db = new DBMain();
        }
        public DataSet DsHoaDon()
        {
            return db.ExecuteQueryDataSet("select * from HoaDon", CommandType.Text, null);
        }
        //
        public DataSet DsCTHoaDon()
        {
            return db.ExecuteQueryDataSet("select * from ChiTietHoaDon", CommandType.Text, null);
        }
        //
        public bool XoaHD(string MaHD, ref string err)
        {
            return db.MyExecuteNonQuery("XoaHD", CommandType.StoredProcedure, ref err, new SqlParameter("@MaHD", MaHD));
        }//
        public bool XoaHDCT(string MaHD, string MaThietBiKH, string MaThietBiCY, ref string err)
        {
            return db.MyExecuteNonQuery("XoaChiTietHD", CommandType.StoredProcedure, ref err, new SqlParameter("@MaHD", MaHD), new SqlParameter("@MaThietBiKH", MaThietBiKH), new SqlParameter("@MaThietBiCY", MaThietBiCY));
        }
        //
        public DataSet DanhSachChiTietHD(String MaKH)
        {
            return db.ExecuteQueryDataSet("  select MaThietBiKH, MaThietBiCY, MaNhanVienSuaChua, DonGia, SoLuong, ThanhTien, GhiChu"+

       " from ChiTietHoaDon where"+
        " ChiTietHoaDon.MaHd = '"+MaKH+"'"+
      "  group by ChiTietHoaDon.MaHd, MaThietBiKH, MaThietBiCY, MaNhanVienSuaChua, DonGia, SoLuong, ThanhTien, GhiChu", CommandType.Text, null);
        }
        public DataSet TimKiemHoaDon(String MaHD)
        {
            return db.ExecuteQueryDataSet("select * from HoaDon where MaHD like '%" + MaHD + "%'  ", CommandType.Text, null);
        }//    
    }
}
