namespace Proje.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addingClassAdmin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Username = c.String(maxLength: 250),
                    Password = c.String(maxLength: 250),
                    Role = c.String(maxLength: 1),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
