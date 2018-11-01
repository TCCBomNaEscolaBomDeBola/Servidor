namespace Araretama.BomNaEscolaBomDeBola.DataAccess.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_ALUNO",
                c => new
                    {
                        ALU_ID = c.Int(nullable: false, identity: true),
                        ALU_NOME = c.String(nullable: false, maxLength: 200),
                        ALU_DATANASC = c.String(),
                        ALU_ESCOLA = c.String(),
                        ALU_SERIE = c.String(),
                        ALU_RESPONSAVEL = c.String(),
                        ALU_CONTATO = c.String(),
                        ALU_LOGRADOURO = c.String(),
                        ALU_NUMERO = c.String(),
                        Cep = c.String(),
                        ALU_BAIRRO = c.String(),
                        ALU_CIDADE = c.String(),
                        ALU_ESTADO = c.String(),
                        ALU_COMPLEMENTO = c.String(),
                        ALU_OBSERVACAO = c.String(),
                    })
                .PrimaryKey(t => t.ALU_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TB_ALUNO");
        }
    }
}
