using System;
using System.Data.SqlClient;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("");
            SqlCommand cmd = new SqlCommand("sp_Myproc", conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            SqlConnection conn2 = new SqlConnection("");
            SqlCommand cmd2 = new SqlCommand("sp_Myproc", conn2);
            using (conn2)
            {
                conn2.Open();
                cmd2.ExecuteNonQuery();
            }

        }
    }
}
