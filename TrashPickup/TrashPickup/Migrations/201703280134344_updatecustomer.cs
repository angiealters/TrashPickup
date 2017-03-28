namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegisterViewModels", "WeekDay", c => c.String());
            AddColumn("dbo.RegisterViewModels", "Frequency", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RegisterViewModels", "Frequency");
            DropColumn("dbo.RegisterViewModels", "WeekDay");
        }
    }
}
