namespace Proje.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class createDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    DetailFirst = c.String(maxLength: 500),
                    DetailSecond = c.String(maxLength: 500),
                    ImageFirst = c.String(maxLength: 100),
                    ImageSecond = c.String(maxLength: 100),
                    CreateDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(maxLength: 50),
                    Description = c.String(maxLength: 200),
                    Status = c.Boolean(nullable: false),
                    CreateDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Headings",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(maxLength: 50),
                    CreateDate = c.DateTime(nullable: false),
                    CategoryId = c.Int(nullable: false),
                    WriterId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Writers", t => t.WriterId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.WriterId);

            CreateTable(
                "dbo.Contents",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Value = c.String(maxLength: 1000),
                    CreateDate = c.DateTime(nullable: false),
                    HeadingId = c.Int(nullable: false),
                    WriterId = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Headings", t => t.HeadingId, cascadeDelete: true)
                .ForeignKey("dbo.Writers", t => t.WriterId)
                .Index(t => t.HeadingId)
                .Index(t => t.WriterId);

            CreateTable(
                "dbo.Writers",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(maxLength: 50),
                    Surname = c.String(maxLength: 50),
                    Image = c.String(maxLength: 100),
                    Email = c.String(maxLength: 50),
                    Password = c.String(maxLength: 20),
                    CreateDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Contacts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Username = c.String(maxLength: 50),
                    Email = c.String(maxLength: 50),
                    Subject = c.String(maxLength: 50),
                    Message = c.String(maxLength: 1000),
                    CreateDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Headings", "WriterId", "dbo.Writers");
            DropForeignKey("dbo.Contents", "WriterId", "dbo.Writers");
            DropForeignKey("dbo.Contents", "HeadingId", "dbo.Headings");
            DropForeignKey("dbo.Headings", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Contents", new[] { "WriterId" });
            DropIndex("dbo.Contents", new[] { "HeadingId" });
            DropIndex("dbo.Headings", new[] { "WriterId" });
            DropIndex("dbo.Headings", new[] { "CategoryId" });
            DropTable("dbo.Contacts");
            DropTable("dbo.Writers");
            DropTable("dbo.Contents");
            DropTable("dbo.Headings");
            DropTable("dbo.Categories");
            DropTable("dbo.Abouts");
        }
    }
}
