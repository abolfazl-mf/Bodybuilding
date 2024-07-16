namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class good : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.personels", "bimeh", c => c.String());
            AddColumn("dbo.personels", "visibility", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.personels", "visibility");
            DropColumn("dbo.personels", "bimeh");
        }
    }
}
