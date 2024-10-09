using System;
using DbConnection;

namespace DbCommand
{
    internal class DbCommand
    {
        public DbConnection.DbConnection Connection { get; private set; }
        public string Instruction { get; private set; }

        public DbCommand(DbConnection.DbConnection connection, string instruction)
        {
            if (connection == null)
                throw new ArgumentNullException(nameof(connection),"DbConnection cannot be null");
            if (string.IsNullOrEmpty(instruction))
                throw new ArgumentException("instruction cannot be null or empty ");
            Connection = connection;
            Instruction = instruction;
        }

        private void run()
        {
            Console.WriteLine("Executing command: {0}", Instruction);
        }

        public void Execute()
        {
            Connection.Open();
            run();
            Connection.Close();
        }
    }
}

