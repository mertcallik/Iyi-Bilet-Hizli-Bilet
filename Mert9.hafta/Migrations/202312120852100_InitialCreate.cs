namespace Mert9.hafta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Pass = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bilets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BiletType = c.String(),
                        BiletPrice = c.Int(nullable: false),
                        MusteriId_MusteriId = c.Int(),
                        PersonelId_PersonelId = c.Int(),
                        TasitId_TasitId = c.Int(),
                        TurId_TurId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Musteris", t => t.MusteriId_MusteriId)
                .ForeignKey("dbo.Personels", t => t.PersonelId_PersonelId)
                .ForeignKey("dbo.Tasits", t => t.TasitId_TasitId)
                .ForeignKey("dbo.Turs", t => t.TurId_TurId)
                .Index(t => t.MusteriId_MusteriId)
                .Index(t => t.PersonelId_PersonelId)
                .Index(t => t.TasitId_TasitId)
                .Index(t => t.TurId_TurId);
            
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        MusteriName = c.String(),
                        MusteriSurName = c.String(),
                        MusteriNation = c.String(),
                        Email = c.String(),
                        Pass = c.String(),
                    })
                .PrimaryKey(t => t.MusteriId);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        PersonelId = c.Int(nullable: false, identity: true),
                        PersonelName = c.String(),
                        PersonelSurname = c.String(),
                        PersonelSalary = c.Int(nullable: false),
                        PersonelBirthDate = c.DateTime(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PersonelId);
            
            CreateTable(
                "dbo.Tasits",
                c => new
                    {
                        TasitId = c.Int(nullable: false, identity: true),
                        TasitType = c.String(),
                        TasitPlate = c.String(),
                    })
                .PrimaryKey(t => t.TasitId);
            
            CreateTable(
                "dbo.Turs",
                c => new
                    {
                        TurId = c.Int(nullable: false, identity: true),
                        HaraktetTime = c.DateTime(nullable: false),
                        Destination = c.String(),
                    })
                .PrimaryKey(t => t.TurId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bilets", "TurId_TurId", "dbo.Turs");
            DropForeignKey("dbo.Bilets", "TasitId_TasitId", "dbo.Tasits");
            DropForeignKey("dbo.Bilets", "PersonelId_PersonelId", "dbo.Personels");
            DropForeignKey("dbo.Bilets", "MusteriId_MusteriId", "dbo.Musteris");
            DropIndex("dbo.Bilets", new[] { "TurId_TurId" });
            DropIndex("dbo.Bilets", new[] { "TasitId_TasitId" });
            DropIndex("dbo.Bilets", new[] { "PersonelId_PersonelId" });
            DropIndex("dbo.Bilets", new[] { "MusteriId_MusteriId" });
            DropTable("dbo.Turs");
            DropTable("dbo.Tasits");
            DropTable("dbo.Personels");
            DropTable("dbo.Musteris");
            DropTable("dbo.Bilets");
            DropTable("dbo.Admins");
        }
    }
}
