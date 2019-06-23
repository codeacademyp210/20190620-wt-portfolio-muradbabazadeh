namespace Adam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutMes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Header = c.String(),
                        Context = c.String(),
                        Birthday = c.String(),
                        Skype = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BecomeYear = c.String(),
                        Current = c.String(),
                        Period = c.String(),
                        Company = c.String(),
                        Location = c.String(),
                        Position = c.String(),
                        Context = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HeaderSections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Headerh1 = c.String(),
                        Paragraph = c.String(),
                        Title = c.String(),
                        TopSpan = c.String(),
                        MiddleSpan = c.String(),
                        ProfileImg = c.String(),
                        RightImg = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HeaderSections");
            DropTable("dbo.Experiences");
            DropTable("dbo.AboutMes");
        }
    }
}
