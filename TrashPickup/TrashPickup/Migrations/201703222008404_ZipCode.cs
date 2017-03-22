namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZipCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegisterViewModels", "State", c => c.String());
            AddColumn("dbo.AspNetUsers", "ZipCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ZipCode");
            DropColumn("dbo.RegisterViewModels", "State");
        }
    }
}
