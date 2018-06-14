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
  
    public class BAL_DSKH
    {
        DBMain db = null;
        public BAL_DSKH()
        {
            db = new DBMain();
        }
        public DataSet DsKhachHang()
        {
            return db.ExecuteQueryDataSet("execute LoadDsKH", CommandType.Text, null);
        }
        //
        public DataSet TimKiemKhacHang(String SoDienThoai)
        {
            return db.ExecuteQueryDataSet("	select * from DsKhachHang where SodienThoai like '%" + SoDienThoai + "%'", CommandType.Text, null);
        }
        //
        public bool XoaKH(string MaKH, ref string err)
        {
            return db.MyExecuteNonQuery("sp_XoaKhachHang", CommandType.StoredProcedure, ref err, new SqlParameter("@MaKH", MaKH));
        }
        //
        public bool CapNhatKH(String MaKH, string Ten, string SoDienThoai, string GioiTinh, string DiaChi, ref string err)
        {
            return db.MyExecuteNonQuery("SuaKhachHang", CommandType.StoredProcedure, ref err, new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@TenKH", Ten),
                new SqlParameter("@SoDienThoai", SoDienThoai),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@DiaChi", DiaChi));
        }
    }
}
