namespace GitHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateContactModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContactModels", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.ContactModels", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContactModels", "Email", c => c.String());
            AlterColumn("dbo.ContactModels", "Name", c => c.String());
        }
    }
}
