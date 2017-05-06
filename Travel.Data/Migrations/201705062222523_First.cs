namespace Travel.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Travels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 150),
                        NatureTravel = c.String(),
                        Country = c.String(nullable: false, maxLength: 100),
                        City = c.String(),
                        State = c.String(nullable: false, maxLength: 100),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                        Address = c.String(),
                        Hotel = c.String(nullable: false, maxLength: 150),
                        ContactNumber = c.String(),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Travels");
        }
    }
}
