namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "WeekDay");
            DropColumn("dbo.AspNetUsers", "Frequency");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Frequency", c => c.String());
            AddColumn("dbo.AspNetUsers", "WeekDay", c => c.String());
        }
    }
}
