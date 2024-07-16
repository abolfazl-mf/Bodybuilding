namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class need : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SessionUsers",
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
                        prepayment = c.String(),
                        indebtedness = c.String(),
                        bimeh = c.String(),
                        visibility = c.String(),
                        onregister = c.String(),
                        offregister = c.String(),
                        manager = c.String(),
                        session = c.String(),
                        sessionsprice = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SessionUsers");
        }
    }
}
