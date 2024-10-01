using System;

namespace DbConnection
{
    internal abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan TimeOut { get; set; }

        public DbConnection(string connectionString)
        { 
            if (connectionString == null)
                throw new ArgumentNullException("ConnectionString cannot be Null");
            if (connectionString.Length == 0)
                throw new ArgumentException("ConnectionString cannot be empty");

            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
