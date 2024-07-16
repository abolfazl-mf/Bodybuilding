namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class n1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.userlogins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        username = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.userlogins");
        }
    }
}
