namespace Proje.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addingClassImage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(maxLength: 250),
                    Path = c.String(maxLength: 250),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Images");
        }
    }
}
