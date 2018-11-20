namespace Araretama.BomNaEscolaBomDeBola.DataAccess.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_AULA", "AUL_DATAAULA", c => c.DateTime(nullable: false));
            DropColumn("dbo.TB_AULA", "AUL_DATACHAMADA");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_AULA", "AUL_DATACHAMADA", c => c.DateTime(nullable: false));
            DropColumn("dbo.TB_AULA", "AUL_DATAAULA");
        }
    }
}
