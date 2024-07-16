namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class happy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.personels", "managerprice", c => c.String());
            AddColumn("dbo.SessionUsers", "managerprice", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SessionUsers", "managerprice");
            DropColumn("dbo.personels", "managerprice");
        }
    }
}
