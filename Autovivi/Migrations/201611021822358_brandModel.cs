namespace Autovivi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class brandModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BrandModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarModel = c.String(),
                        Vehicle_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_Id)
                .Index(t => t.Vehicle_Id);
            
            AddColumn("dbo.Adds", "PostDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vehicles", "GearBox", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BrandModels", "Vehicle_Id", "dbo.Vehicles");
            DropIndex("dbo.BrandModels", new[] { "Vehicle_Id" });
            AlterColumn("dbo.Vehicles", "GearBox", c => c.String());
            DropColumn("dbo.Adds", "PostDate");
            DropTable("dbo.BrandModels");
        }
    }
}
