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
  public  class BAL_Phieu
    {
        dal db = null;
        public BAL_Phieu()
        {
            db = new dal();
        }
        //lay thong tin Thiet bi
        public DataSet DsPhieu()
        {
            return db.ExecuteQueryDataSet("select * from Phieu", CommandType.Text, null);
        }
        //
        public bool XoaKH(string MaPhieu, ref string err)
        {
            return db.MyExecuteNonQuery("sp_XoaPhieuHen", CommandType.StoredProcedure, ref err, new SqlParameter("@MaPhieu", MaPhieu));
        }
        //
        public bool sp_XoaCHiTietPhieuHen(string MaPhieu,string MaThietBiKH, ref string err)
        {
            return db.MyExecuteNonQuery("sp_XoaCHiTietPhieuHen", CommandType.StoredProcedure, ref err, new SqlParameter("@MaPhieu", MaPhieu), new SqlParameter("@MaThietBiKH", MaThietBiKH));
        }
        //
        public DataSet TimKiemPhieu(String MaPhieu)
        {
            return db.ExecuteQueryDataSet("select  * from Phieu where MaPhieu='" + MaPhieu + "'", CommandType.Text, null);
        }
        public bool CapNhatKH(String MaPhieu, string NgayTra, ref string err)
        {
            return db.MyExecuteNonQuery("SuaPhieuHen", CommandType.StoredProcedure, ref err, new SqlParameter("@MaPhieu", MaPhieu),
                new SqlParameter("@NgayTra", NgayTra));
        }
        //
        public DataSet _TimKiemPhieuCT(String MaPhieu)
        {

            return db.ExecuteQueryDataSet("select ChitietPhieu.MaPhieu,ChiTietPhieu.MaThietBiKH from Phieu, ChiTietPhieu where ChiTietPhieu.MaPhieu = '" + MaPhieu+ "' group by ChitietPhieu.MaPhieu,ChiTietPhieu.MaThietBiKH", CommandType.Text, null);

        }
    }
}
