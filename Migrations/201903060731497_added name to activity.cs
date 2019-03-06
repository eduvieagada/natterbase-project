namespace NatterbaseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addednametoactivity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Activities", "Name", c => c.String());
            AddColumn("dbo.Countries", "DateModified", c => c.DateTime(nullable: false));
            DropColumn("dbo.Countries", "DateCreated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "DateCreated", c => c.DateTime(nullable: false));
            DropColumn("dbo.Countries", "DateModified");
            DropColumn("dbo.Activities", "Name");
        }
    }
}
