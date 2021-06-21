namespace Proje.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class writerTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "Title", c => c.String(maxLength: 100));
        }

        public override void Down()
        {
            DropColumn("dbo.Writers", "Title");
        }
    }
}
