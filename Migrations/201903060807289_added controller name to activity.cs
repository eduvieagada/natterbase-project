namespace NatterbaseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcontrollernametoactivity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Activities", "Controller", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Activities", "Controller");
        }
    }
}
