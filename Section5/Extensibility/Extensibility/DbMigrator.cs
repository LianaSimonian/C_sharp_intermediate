using System;

namespace Extensibility
{
    internal class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("migration started at  " + DateTime.Now);
            //Details of migrating the database
            _logger.LogInfo("migration finished at  " + DateTime.Now);
            
        }
    }
}