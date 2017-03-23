namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Role : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegisterViewModels", "EmployeeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RegisterViewModels", "EmployeeId");
        }
    }
}
