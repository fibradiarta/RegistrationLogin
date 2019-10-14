namespace TestMitrais.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "PhoneNumber", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.Users", "PhoneNumber", c => c.String(maxLength: 15));
            AlterColumn("dbo.Users", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Users", "FirstName", c => c.String(maxLength: 50));
        }
    }
}
