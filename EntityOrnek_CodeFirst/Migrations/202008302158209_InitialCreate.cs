namespace EntityOrnek_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(),
                        UrunMarka = c.String(),
                        UrunKategori = c.String(),
                        UrunStok = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Urunlers");
        }
    }
}
