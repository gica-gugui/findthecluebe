namespace FindTheClueBE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedRatingColumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "RatingCounter", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "RatingCounter", c => c.String(nullable: false));
        }
    }
}
