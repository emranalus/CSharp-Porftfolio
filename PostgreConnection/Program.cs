using Npgsql;
using System;

namespace PostgreConnection
{
    internal class Program
    {

        static string constr = @"Server=127.0.0.1
                        ;Port=5432
                        ;Database=Northwind
                        ;User Id=postgres
                        ;Password=123;";

        static void Main(string[] args)
        {
            PostgreBaglan();
        }

        public static void PostgreBaglan()
        {

            string sql = "select * from Customers";
            NpgsqlConnection npgsql = new NpgsqlConnection(constr);
            npgsql.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, npgsql);
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr["customer_id"] + " " + rdr["company_name"] + " " + rdr["contact_name"]);
            }

            npgsql.Close();

        }

    }
}
