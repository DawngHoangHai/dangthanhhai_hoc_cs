using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ketNoiCSDL
{
    static class Connections
    {
        private static string ketnoiCSD = @"Data Source=LAPTOP-HK4D25QC\SQLEXPRESS;Initial Catalog=COSODULIEU;Integrated Security=True"; // tao ra 
        public static SqlConnection ketNoiConnection()
        {
            return new SqlConnection(ketnoiCSD);
        }
        public static DataTable HienThiBang(string sqlselect)
        {
            SqlConnection con = ketNoiConnection();
            con.Open();
            SqlDataAdapter MayBom = new SqlDataAdapter(sqlselect, con);
            DataTable table = new DataTable();
            MayBom.Fill(table);
            con.Close();
            MayBom.Dispose();
            return table;
        }
        public static void Insert_UpDate_Del(string sql)
        {
            SqlConnection con = ketNoiConnection();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, con);
            sqlCommand.ExecuteNonQuery();
            con.Close();
            sqlCommand.Dispose();
        }
    }
}
