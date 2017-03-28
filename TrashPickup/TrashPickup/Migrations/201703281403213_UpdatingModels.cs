namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingModels : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.RegisterViewModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RegisterViewModels",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 100),
                        ConfirmPassword = c.String(),
                        StreetAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        WeekDay = c.String(),
                        Frequency = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
        }
    }
}
