namespace FindTheClueBE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewPropertiesApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DisplayName", c => c.String());
            AddColumn("dbo.AspNetUsers", "ProfileImageUrl", c => c.String());
            AddColumn("dbo.AspNetUsers", "Points", c => c.Double(nullable: false));
            AlterColumn("dbo.Games", "PictureUrl", c => c.String());
            AlterColumn("dbo.Games", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Games", "PictureUrl", c => c.String(nullable: false));
            DropColumn("dbo.AspNetUsers", "Points");
            DropColumn("dbo.AspNetUsers", "ProfileImageUrl");
            DropColumn("dbo.AspNetUsers", "DisplayName");
        }
    }
}
