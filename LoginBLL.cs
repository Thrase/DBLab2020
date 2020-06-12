using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace MyLibrary
{
    class LoginBLL
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public static int[] SimpleQuery(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            int[] a = new int[2];
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    a[0] = (int)reader["login_Auth"];
                    a[1] = (int)reader["login_Canlogin"];
                    return a;
                }
                else
                {
                    a[0] = -1;
                    a[1] = -1;
                    return a;
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        public static string SimpleQuery2(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            int[] a = new int[2];
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["login_Account"].ToString();
                }
                else
                {
                    return "";
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }


    }
}
