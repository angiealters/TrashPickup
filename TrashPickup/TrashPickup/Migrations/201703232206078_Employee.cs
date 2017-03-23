namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RegisterViewModels", "StreetAddress", c => c.String());
            AlterColumn("dbo.RegisterViewModels", "City", c => c.String());
            AlterColumn("dbo.RegisterViewModels", "State", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RegisterViewModels", "State", c => c.String(nullable: false));
            AlterColumn("dbo.RegisterViewModels", "City", c => c.String(nullable: false));
            AlterColumn("dbo.RegisterViewModels", "StreetAddress", c => c.String(nullable: false));
        }
    }
}
