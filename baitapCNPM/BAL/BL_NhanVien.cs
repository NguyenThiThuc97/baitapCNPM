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
    class BL_NhanVien
    {
        DBMain db = null;
        public BL_NhanVien()
        {
            db = new DBMain();

        }
        public DataSet LayChuyen()
        {
            return db.ExecuteQueryDataSet("select * from Chuyen", CommandType.Text);
        }
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("select NhanVien.MaNV, Ho_ChuLot, Ten, GioiTinh, NgaySinh, SDT, HinhAnh, MatKhau, ChucNang, tenquyen  from nhanvien, Quyen, PhanQuyen, Chuyen where NhanVien.MaNV=PhanQuyen.MaNV and PhanQuyen.MaQuyen=Quyen.MaQuyen and Chuyen.MaChuyen=NhanVien.Chuyen", CommandType.Text);
        }
        //@ID nvarchar(100),@TenTruoc nvarchar(50), @TenNV nvarchar(50), @Sex bit, @Bi_Day datetime, @SDT numeric(18,0), @HinhAnh image, @pass nvarchar(100), @MaChuyen char(10)
        public bool ThemNhanVien(string manv, string tentruoc, string ten, int sex, string ngaysinh, double sdt, byte[] img, string matkhau, string chuyen, ref string err)
        {
            return db.MyExecuteNonQuery("ThemNhanVien", CommandType.StoredProcedure, ref err,
                                                                                            new SqlParameter("@ID", manv),
                                                                                            new SqlParameter("@TenTruoc", tentruoc),
                                                                                            new SqlParameter("@TenNV", ten),
                                                                                            new SqlParameter("@Sex", sex),
                                                                                            new SqlParameter("@Bi_Day", ngaysinh),
                                                                                            new SqlParameter("@SDT", sdt),
                                                                                            new SqlParameter("@HinhAnh", img),
                                                                                            new SqlParameter("@pass", matkhau),
                                                                                            new SqlParameter("@MaChuyen", chuyen));
        }
        public bool SuaNhanVien(string manv, string tentruoc, string ten, int sex, string ngaysinh, double sdt, byte[] img, string matkhau, string chuyen, ref string err)
        {
            return db.MyExecuteNonQuery("SuaNhanVien", CommandType.StoredProcedure, ref err,
                                                                                            new SqlParameter("@ID", manv),
                                                                                            new SqlParameter("@TenTruoc", tentruoc),
                                                                                            new SqlParameter("@TenNV", ten),
                                                                                            new SqlParameter("@Sex", sex),
                                                                                            new SqlParameter("@Bi_Day", ngaysinh),
                                                                                            new SqlParameter("@SDT", sdt),
                                                                                            new SqlParameter("@HinhAnh", img),
                                                                                            new SqlParameter("@pass", matkhau),
                                                                                            new SqlParameter("@MaChuyen", chuyen));
        }
        public bool XoaNhanVien(string manv, ref string err)
        {
            return db.MyExecuteNonQuery("XoaNhanVien", CommandType.StoredProcedure, ref err, new SqlParameter("@ID", manv));
        }
        public DataSet LayQuyen()
        {
            return db.ExecuteQueryDataSet("select * from quyen", CommandType.Text);
        }
        public bool ThemQuyen(string manv, string maquyen, ref string err)
        {
            return db.MyExecuteNonQuery("insert into phanquyen values('" + manv + "', '" + maquyen + "')", CommandType.Text, ref err);
        }
        public bool SuaQuyen(string manv, string maquyen, ref string err)

        {
            return db.MyExecuteNonQuery("update phanquyen set maquyen='" + maquyen + "' where manv='" + manv + "'", CommandType.Text, ref err);
        }
        public DataSet TimKiem(string strTimKiem)
        {
            return db.ExecuteQueryDataSet("exec TimKiem '" + strTimKiem + "'", CommandType.Text);
        }
    }
}
