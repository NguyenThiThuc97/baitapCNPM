using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
namespace baitapCNPM.DAL
{
    class DBMain
    {
        static SqlConnection conn = null;
        static SqlCommand comm = null;
        static SqlDataAdapter da = null;

        static string strKetNoi = "";
        public bool accesssDB(string user, string pass)
        {

            strKetNoi = @"Data Source=NDTT\NDTT;Initial Catalog=baitaplonCNPM" + ";User ID=" + user + ";Password=" + pass + ";";
            conn = new SqlConnection(strKetNoi);
            comm = conn.CreateCommand();
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DBMain()
        {
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType cmt, params SqlParameter[] p)
        {
            DataSet ds = null;
            try
            {
                comm.CommandType = cmt;
                comm.CommandText = strSQL;
                da = new SqlDataAdapter(comm);
                ds = new DataSet();
                da.Fill(ds);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR" + e.ToString());
            }
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;

        }
        public int CheckUserLogin(CommandType type, string comdText, params SqlParameter[] param)
        {
            int result = -1;
            //
            comm.Parameters.Clear();
            comm.CommandType = type;
            comm.CommandText = comdText;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            try
            {
                // Aggregate Function
                result = (int)comm.ExecuteScalar();
            }
            catch (SqlException)
            {

            }
            finally
            {
                conn.Close();
            }
            //		sqlString	"select dbo.ThongKeTienThuoc('11/28/2017', '11/28/2017')"	string

            return result;
        }
        public double MyExecuteScalar(string sqlString, CommandType ct, ref string err, params SqlParameter[] p)
        {
            string temp = null;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = sqlString;
            comm.CommandType = ct;
            foreach (SqlParameter i in p)
                comm.Parameters.Add(i);
            try
            {
                temp = comm.ExecuteScalar().ToString();

            }
            catch (SqlException ex)
            {
                err = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return double.Parse(temp);
        }
    }
}
