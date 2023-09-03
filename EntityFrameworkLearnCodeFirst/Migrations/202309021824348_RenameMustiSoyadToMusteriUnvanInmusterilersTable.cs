namespace EntityFrameworkLearnCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMustiSoyadToMusteriUnvanInmusterilersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musterilers", "MusteriUnvan", c => c.String());
            DropColumn("dbo.Musterilers", "MusteriSoyad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musterilers", "MusteriSoyad", c => c.String());
            DropColumn("dbo.Musterilers", "MusteriUnvan");
        }
    }
}
