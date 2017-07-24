namespace EF6SQLite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Photo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Photo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Url = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photo", "UserId", "dbo.User");
            DropIndex("dbo.Photo", new[] { "UserId" });
            DropTable("dbo.Photo");
        }
    }
}
