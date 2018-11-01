namespace Araretama.BomNaEscolaBomDeBola.DataAccess.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class voluntario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_VOLUNTARIO",
                c => new
                    {
                        VOL_ID = c.Int(nullable: false, identity: true),
                        VOL_NOME = c.String(nullable: false, maxLength: 200),
                        VOL_LOGIN = c.String(nullable: false),
                        VOL_SENHA = c.String(nullable: false),
                        VOL_EMAIL = c.String(),
                        VOL_CONTATO = c.String(),
                    })
                .PrimaryKey(t => t.VOL_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TB_VOLUNTARIO");
        }
    }
}
