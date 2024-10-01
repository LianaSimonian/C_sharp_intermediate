using System;

namespace DbConnection
{
    internal class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Opening SQLConnection ");
        }
        public override void Close()
        {
            Console.WriteLine("Closing SQLConnection ");
        }
    }
}
