using System;
using System.Data.SqlClient;

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                //using(SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=appDB;Integrated Security=True"))
                using (SqlConnection conn = new SqlConnection("server=.=(localdb)/MSSQLLocalDB;database=appDB;uid=dm;pwd=dmtest"))
                {
                    conn.Open();
                    Console.WriteLine("connect success");
                }
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("all done");
            }
        }
    }
}
