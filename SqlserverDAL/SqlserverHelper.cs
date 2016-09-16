using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.SqlserverDAL
{
   public  class SqlserverHelper
    {
        private static readonly string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["Student_status_manage_system"].ConnectionString;

        //对SqlCommand.ExecuteNonQuery的封装
        public static int ExecuteNonQuery(string commStr, params SqlParameter[] pms)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = new SqlCommand(commStr, conn))
                {
                    if (pms != null)
                    {
                        comm.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    return comm.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 对SqlCommand.ExecuteScalar的封装
        /// </summary>
        /// <param name="commStr">sql语句</param>
        /// <param name="pms">sql语句的参数</param>
        /// <returns></returns>
        public static object ExecuteScalar(string commStr, params SqlParameter[] pms)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = new SqlCommand(commStr, conn))
                {
                    if (pms != null)
                    {
                        comm.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    return comm.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// 对SqlCommand.ExecuteReader的封装
        /// </summary>
        /// <param name="commStr">sql语句</param>
        /// <param name="pms">sql语句参数数组</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string commStr, params SqlParameter[] pms)
        {
            SqlConnection conn = new SqlConnection(connStr);
            using (SqlCommand comm = new SqlCommand(commStr, conn))
            {
                if (pms != null)
                {
                    comm.Parameters.AddRange(pms);
                }
                try
                {
                    conn.Open();
                    return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch
                {
                    conn.Close();
                    conn.Dispose();
                    throw;
                }
            }
        }

        /// <summary>
        /// 执行SqlDataAdapter.Fill(dt)方法，并返回dt
        /// </summary>
        /// <param name="commStr">sql语句</param>
        /// <param name="pms">sql语句中的参数数组</param>
        /// <returns></returns>
        public static DataTable AdapterDataTable(string commStr, params SqlParameter[] pms)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(commStr, connStr))
            {
                if (pms != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                }
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
