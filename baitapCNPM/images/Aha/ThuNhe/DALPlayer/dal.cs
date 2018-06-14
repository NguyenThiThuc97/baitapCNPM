using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ThuNhe.DALPlayer
{
    public class dal
    {
        public static string connectionString = "Data Source=DESKTOP-LVCP3CO\\THU;Initial Catalog=Ac;Integrated Security=True";

        public static string CONSTR
        {
            set { connectionString = value; }
        }
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        SqlCommand cmd = null;

        public dal()
        {
            conn = new SqlConnection(connectionString);
            cmd = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string sqlString, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.CommandText = sqlString;
            cmd.CommandType = ct;
            if (p != null)
            {
                foreach (SqlParameter i in p)
                    cmd.Parameters.Add(i);
            }

            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;


        }

        public bool MyExecuteNonQuery(string sqlString, CommandType ct, ref string error, params SqlParameter[] p)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandType = ct;
            cmd.CommandText = sqlString;
            foreach (SqlParameter i in p)
                cmd.Parameters.Add(i);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        //Gán dữ liệu vào Combobox
        public int MyExecuteScalar(string sqlString, CommandType ct, ref string err, params SqlParameter[] p)
        {
            int temp = 0;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = sqlString;
            cmd.CommandType = ct;
            foreach (SqlParameter i in p)
            {
                cmd.Parameters.Add(i);
            }
            try
            {
                temp = (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                err = e.Message;
            }
            finally
            {
                conn.Close();
            }
            return temp;
        }
    }
}
