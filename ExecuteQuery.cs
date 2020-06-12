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
    class ExecuteQuery
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public static DataSet Query(string sql, string srct)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                sda.Fill(ds, srct);
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
    }
}
