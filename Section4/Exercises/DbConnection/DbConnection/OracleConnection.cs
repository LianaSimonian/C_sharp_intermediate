using System;

namespace DbConnection
{
    internal class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle connection");
            if (TimeOut.Seconds > 10)
                throw new TimeoutException("Oracle connection time is up");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection ");
        }
    }
}
