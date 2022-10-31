using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

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

    public class Product
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
    }

    internal sealed class ContextMigrationConfiguration : DbMigrationsConfiguration<JuinjangContext>
    {
        public ContextMigrationConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }
    }
}