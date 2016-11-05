namespace Autovivi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostDate = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                        Vehicle_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Vehicle_Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Messages = c.String(),
                        Add_Id = c.Int(),
                        User_Id = c.Int(),
                        Receiever_Id = c.Int(),
                        Sender_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adds", t => t.Add_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.Receiever_Id)
                .ForeignKey("dbo.Users", t => t.Sender_Id)
                .Index(t => t.Add_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Receiever_Id)
                .Index(t => t.Sender_Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.Int(nullable: false),
                        Model = c.String(),
                        ProductionYear = c.Int(nullable: false),
                        FuelType = c.Int(nullable: false),
                        VehicleType = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Mileage = c.Int(nullable: false),
                        CubicCapacity = c.Int(nullable: false),
                        Condition = c.String(),
                        Damage = c.String(),
                        Description = c.String(),
                        CountryOrigin = c.String(),
                        Colour = c.String(),
                        GearBox = c.Int(nullable: false),
                        Power = c.Int(nullable: false),
                        Options = c.String(),
                        BodyStyle = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Id", "dbo.People");
            DropForeignKey("dbo.Adds", "Vehicle_Id", "dbo.Vehicles");
            DropForeignKey("dbo.BrandModels", "Vehicle_Id", "dbo.Vehicles");
            DropForeignKey("dbo.Messages", "Sender_Id", "dbo.Users");
            DropForeignKey("dbo.Messages", "Receiever_Id", "dbo.Users");
            DropForeignKey("dbo.Messages", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Adds", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Messages", "Add_Id", "dbo.Adds");
            DropIndex("dbo.Users", new[] { "Id" });
            DropIndex("dbo.BrandModels", new[] { "Vehicle_Id" });
            DropIndex("dbo.Messages", new[] { "Sender_Id" });
            DropIndex("dbo.Messages", new[] { "Receiever_Id" });
            DropIndex("dbo.Messages", new[] { "User_Id" });
            DropIndex("dbo.Messages", new[] { "Add_Id" });
            DropIndex("dbo.Adds", new[] { "Vehicle_Id" });
            DropIndex("dbo.Adds", new[] { "User_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.BrandModels");
            DropTable("dbo.Vehicles");
            DropTable("dbo.People");
            DropTable("dbo.Messages");
            DropTable("dbo.Adds");
        }
    }
}
