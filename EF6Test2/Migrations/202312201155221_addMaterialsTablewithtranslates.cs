namespace EF6Test2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMaterialsTablewithtranslates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2147483647),
                        RemoteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.RemoteId, unique: true);
            
            CreateTable(
                "dbo.MaterialTranslations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CultureName = c.String(maxLength: 2147483647),
                        LocalizedName = c.String(maxLength: 2147483647),
                        MaterialId = c.Int(nullable: false),
                        RemoteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materials", t => t.MaterialId, cascadeDelete: true)
                .Index(t => t.MaterialId)
                .Index(t => t.RemoteId, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaterialTranslations", "MaterialId", "dbo.Materials");
            DropIndex("dbo.MaterialTranslations", new[] { "RemoteId" });
            DropIndex("dbo.MaterialTranslations", new[] { "MaterialId" });
            DropIndex("dbo.Materials", new[] { "RemoteId" });
            DropTable("dbo.MaterialTranslations");
            DropTable("dbo.Materials");
        }
    }
}
