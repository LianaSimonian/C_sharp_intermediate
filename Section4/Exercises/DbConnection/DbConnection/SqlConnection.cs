using System;

namespace DbConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString,TimeSpan timeOut) : base(connectionString,timeOut)
        {
        }

        public override void Open()
        {   
            Console.WriteLine("Opening SQLConnection ");
            if (TimeOut.Seconds > 10)
                throw new TimeoutException("sql Connection time is up ");
        }
        public override void Close()
        {
            Console.WriteLine("Closing SQLConnection ");
        }
    }
}