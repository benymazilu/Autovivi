namespace Autovivi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class georgel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "FuelType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "FuelType", c => c.String());
        }
    }
}
