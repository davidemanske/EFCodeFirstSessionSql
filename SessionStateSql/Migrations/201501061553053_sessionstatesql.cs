namespace SessionStateSql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sessionstatesql : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ASPStateTempApplications",
                c => new
                    {
                        AppId = c.Int(nullable: false),
                        AppName = c.String(nullable: false, maxLength: 280),
                    })
                .PrimaryKey(t => t.AppId);
            
            CreateTable(
                "dbo.ASPStateTempSessions",
                c => new
                    {
                        SessionId = c.String(nullable: false, maxLength: 88),
                        Created = c.DateTime(nullable: false),
                        Expires = c.DateTime(nullable: false),
                        LockDate = c.DateTime(nullable: false),
                        LockDateLocal = c.DateTime(nullable: false),
                        LockCookie = c.Int(nullable: false),
                        Timeout = c.Int(nullable: false),
                        Locked = c.Boolean(nullable: false),
                        SessionItemShort = c.Binary(maxLength: 7000),
                        SessionItemLong = c.Binary(),
                        Flags = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SessionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ASPStateTempSessions");
            DropTable("dbo.ASPStateTempApplications");
        }
    }
}
