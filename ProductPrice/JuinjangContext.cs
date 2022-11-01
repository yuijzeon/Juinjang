using System.Data.Entity;

namespace ProductPrice
{
    public class JuinjangContext : DbContext
    {
        public JuinjangContext() : base("JuinjangConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<JuinjangContext, ContextMigrationConfiguration>(true));
        }

        public DbSet<Product> Products => Set<Product>();
    }
}