namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Password : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "StreetAddress", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "StreetAddress", c => c.Double(nullable: false));
        }
    }
}
