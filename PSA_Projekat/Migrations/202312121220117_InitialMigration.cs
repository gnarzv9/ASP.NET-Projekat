namespace PSA_Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Opremas",
                c => new
                    {
                        Sifra = c.Int(nullable: false, identity: true),
                        Naziv = c.String(maxLength: 30, unicode: false),
                        Proizvodjac = c.String(maxLength: 30, unicode: false),
                        Kolicina = c.Int(nullable: false),
                        TezinaKilograms = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sifra);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Opremas");
        }
    }
}
