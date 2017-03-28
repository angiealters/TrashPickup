namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerViewModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "WeekDay", c => c.String());
            AddColumn("dbo.AspNetUsers", "Frequency", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Frequency");
            DropColumn("dbo.AspNetUsers", "WeekDay");
        }
    }
}
