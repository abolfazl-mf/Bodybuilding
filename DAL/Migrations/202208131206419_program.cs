namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class program : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.personels", "bodyprogram", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.personels", "bodyprogram");
        }
    }
}
