using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

namespace ProductPrice
{
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