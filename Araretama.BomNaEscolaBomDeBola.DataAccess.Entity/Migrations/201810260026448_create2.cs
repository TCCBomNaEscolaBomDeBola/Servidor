namespace Araretama.BomNaEscolaBomDeBola.DataAccess.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TB_ALUNO", name: "Cep", newName: "ALU_CEP");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.TB_ALUNO", name: "ALU_CEP", newName: "Cep");
        }
    }
}
