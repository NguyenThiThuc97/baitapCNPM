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
   public  class BAL_DsTBKH
    {
        //_DsTBKH_
        dal db = null;
        public BAL_DsTBKH()
        {
            db = new dal();
        }
        public DataSet _DsTBKH_()
        {
            return db.ExecuteQueryDataSet("execute _DsTBKH_", CommandType.Text, null);
        }
        //
        public DataSet _sp_DsLoaiTB()
        {
            return db.ExecuteQueryDataSet("select * from Chuyen", CommandType.Text, null);
        }
        //
        public bool XoaKH(string MaThietBiKH, ref string err)
        {
            return db.MyExecuteNonQuery("sp_XoaThietBiKH", CommandType.StoredProcedure, ref err, new SqlParameter("@MaThietBiKH", MaThietBiKH));
        }
        public bool SuaDSThietBiKH(String MaThietBiKH, string TenThietBiKH, string MaKH, string MaLoaiTB, string ThuocNhom,String NgayHetHanBaoHanh, ref string err)
        {
            return db.MyExecuteNonQuery("SuaDSThietBiKH", CommandType.StoredProcedure, ref err, new SqlParameter("@MaThietBiKH", MaThietBiKH),
                new SqlParameter("@TenThietBiKH", TenThietBiKH),
                new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@MaLoaiTB", MaLoaiTB),
                new SqlParameter("@ThuocNhom", ThuocNhom),
             new SqlParameter("@NgayHetHanBaoHanh", NgayHetHanBaoHanh));
        }
        public DataSet TimKiemThietBiKhacHang(String MaThietBiKH)
        {


            return db.ExecuteQueryDataSet("select  * from DSThietBiKH where MaThietBiKH='" + MaThietBiKH + "'   ", CommandType.Text, null);

        }//
    }
}
