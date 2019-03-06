namespace NatterbaseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedfromdatemodifiedtocreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "Created", c => c.DateTime(nullable: false));
            DropColumn("dbo.Countries", "DateModified");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "DateModified", c => c.DateTime(nullable: false));
            DropColumn("dbo.Countries", "Created");
        }
    }
}
