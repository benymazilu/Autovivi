namespace Autovivi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class batman : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "Brand", c => c.Int());
            AlterColumn("dbo.Vehicles", "ProductionYear", c => c.Int());
            AlterColumn("dbo.Vehicles", "FuelType", c => c.Int());
            AlterColumn("dbo.Vehicles", "VehicleType", c => c.Int());
            AlterColumn("dbo.Vehicles", "GearBox", c => c.Int());
            AlterColumn("dbo.Vehicles", "Options", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehicles", "BodyStyle", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "BodyStyle", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehicles", "Options", c => c.String());
            AlterColumn("dbo.Vehicles", "GearBox", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehicles", "VehicleType", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehicles", "FuelType", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehicles", "ProductionYear", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehicles", "Brand", c => c.Int(nullable: false));
        }
    }
}
