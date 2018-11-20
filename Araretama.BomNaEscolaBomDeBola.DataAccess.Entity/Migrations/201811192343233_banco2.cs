namespace Araretama.BomNaEscolaBomDeBola.DataAccess.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TB_TURMA", name: "TUR_QUANTIDADE", newName: "QuantidadeDeAlunos");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.TB_TURMA", name: "QuantidadeDeAlunos", newName: "TUR_QUANTIDADE");
        }
    }
}
