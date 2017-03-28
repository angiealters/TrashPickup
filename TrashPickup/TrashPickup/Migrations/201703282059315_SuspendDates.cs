namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SuspendDates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "SuspendStartDate", c => c.String());
            AddColumn("dbo.AspNetUsers", "SuspendEndDate", c => c.String());
            DropColumn("dbo.AspNetUsers", "SuspendDates");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "SuspendDates", c => c.String());
            DropColumn("dbo.AspNetUsers", "SuspendEndDate");
            DropColumn("dbo.AspNetUsers", "SuspendStartDate");
        }
    }
}
