using System.Data.Entity;
using ProductPrice.Database.Entity;

namespace ProductPrice.Database
{
    public class JuinjangContext : DbContext
    {
        public JuinjangContext() : base("JuinjangConnection")
        {
            System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<JuinjangContext, ContextMigrationConfiguration>(true));
        }

        public DbSet<Product> Products { get; set; }
    }
}