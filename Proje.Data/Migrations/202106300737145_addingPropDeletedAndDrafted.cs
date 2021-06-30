namespace Proje.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingPropDeletedAndDrafted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Contacts", "IsDrafted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Messages", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Messages", "IsDrafted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "IsDrafted");
            DropColumn("dbo.Messages", "IsDeleted");
            DropColumn("dbo.Contacts", "IsDrafted");
            DropColumn("dbo.Contacts", "IsDeleted");
        }
    }
}
