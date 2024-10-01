using System.Collections.Generic;


namespace DbConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<DbConnection>();
            list.Add(new SqlConnection("SQL connection string"));
            list.Add(new OracleConnection("Oracle connection string"));

            //Polymorphism
            foreach (DbConnection c in list)
            {
                c.Open();
                c.Close();
            }
        }
    }
}
