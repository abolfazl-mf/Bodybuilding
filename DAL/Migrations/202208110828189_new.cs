namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.personels", "onregister", c => c.String());
            AddColumn("dbo.personels", "offregister", c => c.String());
            AddColumn("dbo.personels", "manager", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.personels", "manager");
            DropColumn("dbo.personels", "offregister");
            DropColumn("dbo.personels", "onregister");
        }
    }
}
