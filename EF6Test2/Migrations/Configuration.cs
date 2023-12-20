using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

namespace EF6Test2.Migrations
{
    public class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(ApplicationDbContext context)
        {

        }
    }
}
