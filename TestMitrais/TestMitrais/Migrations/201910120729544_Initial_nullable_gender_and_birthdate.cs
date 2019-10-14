namespace TestMitrais.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_nullable_gender_and_birthdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Gender", c => c.Boolean());
            AlterColumn("dbo.Users", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "Gender", c => c.Boolean(nullable: false));
        }
    }
}
