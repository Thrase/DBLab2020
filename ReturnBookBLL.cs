using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MyLibrary
{
    class ReturnBookBLL
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public static DataSet Query(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                sda.Fill(ds, "lendinfo");
                return ds;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sda.Dispose();
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
    }
}
