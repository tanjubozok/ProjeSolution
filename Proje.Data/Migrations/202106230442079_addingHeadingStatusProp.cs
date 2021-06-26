namespace Proje.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addingHeadingStatusProp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "Status", c => c.Boolean(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Headings", "Status");
        }
    }
}
