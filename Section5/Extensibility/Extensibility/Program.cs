using System;


namespace Extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
            var dbMigrator1 = new DbMigrator(new FileLogger("D:\\Users\\log.txt"));
            dbMigrator1.Migrate();
        }
    }
}
