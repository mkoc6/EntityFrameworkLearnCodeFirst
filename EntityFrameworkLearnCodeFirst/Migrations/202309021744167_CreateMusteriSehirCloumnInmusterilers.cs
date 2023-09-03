namespace EntityFrameworkLearnCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusteriSehirCloumnInmusterilers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musterilers", "MusteriSehir", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musterilers", "MusteriSehir");
        }
    }
}
