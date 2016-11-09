namespace Autovivi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class models : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "Condition", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Condition", c => c.String());
        }
    }
}
