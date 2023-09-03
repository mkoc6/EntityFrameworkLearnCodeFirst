namespace EntityFrameworkLearnCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusterilersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musterilers",
                c => new
                    {
                        MusteriID = c.Int(nullable: false, identity: true),
                        MusteriAd = c.String(),
                        MusteriSoyad = c.String(),
                    })
                .PrimaryKey(t => t.MusteriID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Musterilers");
        }
    }
}
