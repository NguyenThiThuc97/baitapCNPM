using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace ThuNhe
{
  
    class KetNoiExcel
    {
        public static OleDbConnection _con;
        public static OleDbCommand _cmd;
        public static OleDbDataAdapter _da;
        public static DataTable dt;
        String pathFile;
        public KetNoiExcel(String pathFile)
        {
            this.pathFile = pathFile;
        }
        public void Connect()
        {
            if (pathFile.Contains("xlsx"))
            {
                _con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathFile + ";" + "Extended Properties=Excel 12.0;");
                _con.Open();
            }
            else
            {
                _con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathFile + ";" + "Extended Properties=Excel 8.0;");
                _con.Open();
            }
        }
        public DataTable GetDataTable(String sql)
        {
            dt = new DataTable();
            try
            {
                Connect();
                _da = new OleDbDataAdapter(sql, _con);
                _da.Fill(dt);
                _con.Close();
                return dt;
            }
            catch(OleDbException ex)
            {
                _con.Close();
                Console.WriteLine("Error" + ex.ToString());
                return dt;
            }
        }
        public int ExecuteNonQuery(String sql)
        {
            int re = 0;
            try
            {
                Connect();
                _cmd = new OleDbCommand(sql, _con);
                _cmd.ExecuteNonQuery();
                _con.Close();
            }
            catch (OleDbException ex)
            {
                _con.Close();
                Console.WriteLine("Error" + ex.ToString());
            }
            return re;
        }
    }
}
