using DbConnection;
using System;
using System.Collections.Generic;

namespace DbCommand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<DbCommand>();
            list.Add(new DbCommand(new SqlConnection("SQl connection string",TimeSpan.FromMinutes(5)),"Select * from Users"));
            list.Add(new DbCommand(new OracleConnection("Oracle connection string", TimeSpan.FromMinutes(7)), "Select name from Users"));
            
            //Polymorphic behavior
            foreach (var item in list)
                item.Execute();
        }
    }
}
