namespace Mert9.hafta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Email", c => c.String());
            AddColumn("dbo.Turs", "DeparturePoint", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Turs", "DeparturePoint");
            DropColumn("dbo.Admins", "Email");
        }
    }
}
