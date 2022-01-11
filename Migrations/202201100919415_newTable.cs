namespace class_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employyes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Class_ = c.String(),
                        NumOfEmployyes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employyes");
        }
    }
}
