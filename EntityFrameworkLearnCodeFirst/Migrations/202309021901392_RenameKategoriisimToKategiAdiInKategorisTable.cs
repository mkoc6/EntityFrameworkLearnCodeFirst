namespace EntityFrameworkLearnCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKategoriisimToKategiAdiInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriAdi", c => c.String());
            DropColumn("dbo.Kategoris", "Kategoriisim");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "Kategoriisim", c => c.String());
            DropColumn("dbo.Kategoris", "KategoriAdi");
        }
    }
}
