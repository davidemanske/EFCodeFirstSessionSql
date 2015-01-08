using System.Runtime.Remoting.Contexts;

namespace SessionStateSql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sessionstatesqlstoredprocs : DbMigration
    {
        public override void Up()
        {
            // Stored Procedures
            foreach (var script in DbMigrationExtensions.PrpareSqlScripts(SQLScripts.SessionStateUp))
            {
                Sql(script);
            }
        }
        
        public override void Down()
        {
            foreach (var script in DbMigrationExtensions.PrpareSqlScripts(SQLScripts.SessionStateDown))
            {
                Sql(script);
            }            
        }

        
    }
}
