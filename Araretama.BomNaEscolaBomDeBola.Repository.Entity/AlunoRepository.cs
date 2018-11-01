using Araretama.BomNaEscolaBomDeBola.Domain;
using Araretama.Common.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araretama.BomNaEscolaBomDeBola.Repository.Entity
{
    public class AlunoRepository: AbstractRepository<Aluno, int>
    {
        public AlunoRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }

   
}
