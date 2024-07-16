namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.personels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        family = c.String(),
                        fathername = c.String(),
                        sport = c.String(),
                        nationalcode = c.String(),
                        phonenumber = c.String(),
                        age = c.Int(nullable: false),
                        give = c.String(),
                        receive = c.String(),
                        kindOfGive = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.personels");
        }
    }
}
