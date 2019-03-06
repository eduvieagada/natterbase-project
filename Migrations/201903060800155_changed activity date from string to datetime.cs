namespace NatterbaseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedactivitydatefromstringtodatetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Activities", "DatePerformed", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Activities", "DatePerformed", c => c.String());
        }
    }
}
