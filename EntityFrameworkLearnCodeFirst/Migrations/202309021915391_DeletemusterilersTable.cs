namespace EntityFrameworkLearnCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletemusterilersTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Musterilers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Musterilers",
                c => new
                    {
                        MusteriID = c.Int(nullable: false, identity: true),
                        MusteriAd = c.String(),
                        MusteriSehir = c.String(),
                        MusteriUnvan = c.String(),
                    })
                .PrimaryKey(t => t.MusteriID);
            
        }
    }
}
