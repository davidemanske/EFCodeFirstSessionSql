using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace SessionStateSql.Models
{
    public partial class SessionContext : DbContext
    {
        static SessionContext()
        {
            Database.SetInitializer<SessionContext>(null);
        }

        public SessionContext()
            : base("Name=SessionContext")
        {
        }

        public DbSet<ASPStateTempApplication> ASPStateTempApplications { get; set; }
        public DbSet<ASPStateTempSession> ASPStateTempSessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
