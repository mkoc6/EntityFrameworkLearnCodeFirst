namespace EntityFrameworkLearnCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusteriSehirColumnKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "Kategoriisim", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kategoris", "Kategoriisim");
        }
    }
}
