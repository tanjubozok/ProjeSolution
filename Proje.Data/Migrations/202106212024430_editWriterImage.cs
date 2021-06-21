namespace Proje.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class editWriterImage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "Image", c => c.String(maxLength: 200));
        }

        public override void Down()
        {
            AlterColumn("dbo.Writers", "Image", c => c.String(maxLength: 100));
        }
    }
}
