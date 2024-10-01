using System.Collections.Generic;
using System;


namespace DbConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<DbConnection>();
            list.Add(new SqlConnection("SQL connection string", TimeSpan.FromSeconds(5)));
            list.Add(new OracleConnection("Oracle connection string", TimeSpan.FromSeconds(1)));

            //Polymorphism
            foreach (DbConnection c in list)
            {
                c.Open();
                c.Close();
            }
        }
    }
}
