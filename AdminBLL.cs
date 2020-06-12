using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace MyLibrary
{
    class AdminBLL
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public static int SimpleQuery(string sql)
        {

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return (int)reader["user_Availnumber"] - (int)reader["user_Lendnumber"];
                }
                else
                {
                    return -1;
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
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["user_cardno"].ToString();
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

        public static string SimpleQuery3(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["user_seated"].ToString();
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
