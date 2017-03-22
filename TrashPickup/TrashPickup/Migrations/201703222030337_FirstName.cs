namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AlterColumn("dbo.RegisterViewModels", "StreetAddress", c => c.String(nullable: false));
            AlterColumn("dbo.RegisterViewModels", "City", c => c.String(nullable: false));
            AlterColumn("dbo.RegisterViewModels", "State", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RegisterViewModels", "State", c => c.String());
            AlterColumn("dbo.RegisterViewModels", "City", c => c.String());
            AlterColumn("dbo.RegisterViewModels", "StreetAddress", c => c.String());
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
