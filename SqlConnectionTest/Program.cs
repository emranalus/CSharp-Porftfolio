using System;
using System.Data.SqlClient;

namespace SqlConnectionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SqlBaglanti();
            SqlKayitEkle();
        }

        public static void SqlKayitEkle()
        {
            string sqlkomut = @"insert into Shippers(CompanyName,Phone)
                                values('MngKargo', 2124440999)";
            string constr =
                "Server=localhost;" +
                "Database=Northwind;" +
                "User Id=sa;" +
                "Password=123;";

            SqlConnection sqlConnection = new SqlConnection(constr);
            try
            {
                
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(sqlkomut, sqlConnection);
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    Console.WriteLine("Islem Basarili!");
                }
                else
                {
                    Console.WriteLine("Kayit Yapilamadi!");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        private static void SqlBaglanti()
        {
            string sqlCommand = "select * from Customers";
            string constr =
                "Server=localhost;" +
                "Database=Northwind;" +
                "User Id=sa;" +
                "Password=123;";

            SqlConnection db = new SqlConnection(constr);
            db.Open();
            Console.WriteLine("Connection Status: " + db.State);

            // If a set of data comes we greet the dataset with SqlDataReader
            SqlCommand cmd = new SqlCommand(sqlCommand, db);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr["CustomerID"] + " " + rdr["CompanyName"] + " " + rdr["ContactName"]);
            }

            //Console.WriteLine("Hello World!");
            db.Close();
            Console.WriteLine("Connection Status: " + db.State);
        }
    }
}
