namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hello : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.personels", "prepayment", c => c.String());
            AddColumn("dbo.personels", "indebtedness", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.personels", "indebtedness");
            DropColumn("dbo.personels", "prepayment");
        }
    }
}
