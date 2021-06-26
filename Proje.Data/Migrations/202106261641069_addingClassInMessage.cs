namespace Proje.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addingClassInMessage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    SenderMail = c.String(maxLength: 50),
                    ReceiverMail = c.String(maxLength: 50),
                    Subject = c.String(maxLength: 100),
                    Content = c.String(maxLength: 1000),
                    MessageDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
