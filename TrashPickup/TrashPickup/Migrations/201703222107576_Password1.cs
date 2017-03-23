namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Password1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegisterViewModels", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.RegisterViewModels", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RegisterViewModels", "LastName");
            DropColumn("dbo.RegisterViewModels", "ZipCode");
        }
    }
}
