using System.Data.Entity;
using EF6Test2.Entities;
using EF6Test2.Migrations;

namespace EF6Test2
{
    public class ApplicationDbContext : DbContext
    {
        static ApplicationDbContext()
        {
            Database.SetInitializer(new AddDbInitializer());

        }

        public ApplicationDbContext() : base("sqlite")
        {
            Database.Initialize(true);
        }

        public DbSet<Material> Materials { get; set; }

        public DbSet<MaterialTranslation> MaterialTranslations { get; set; }

        public DbSet<Work> Works { get; set; }
    }

    public sealed class AddDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        public override void InitializeDatabase(ApplicationDbContext context)
        {
            var migrator = new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>(true);
            migrator.InitializeDatabase(context);
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //base.Seed(context);
        }
    }
}
