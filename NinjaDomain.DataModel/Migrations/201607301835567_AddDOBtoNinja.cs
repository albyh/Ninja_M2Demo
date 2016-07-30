namespace NinjaDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDOBtoNinja : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ninjas", "DateofBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ninjas", "DateofBirth");
        }
    }
}
