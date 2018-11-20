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
    public class AulaRepository : AbstractRepository<Aula, int>
    {

        private DbContext _context;


        public AulaRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public Aula DetalhesAula(int IdAula)
        {
            Aula aula = new Aula();
            aula = _context.Set<Aula>().Where(p => p.Id == IdAula).FirstOrDefault();
            aula.Turma = _context.Set<Turma>().Where(p => p.Id == aula.IDTurma).FirstOrDefault();
            aula.Turma.Alunos = _context.Set<Aluno>().Where(p => p.Id == aula.IDTurma).ToList();
            aula.Turma.Voluntarios = _context.Set<Voluntario>().Where(p => p.Id == aula.IDTurma).ToList();
            foreach (var i in aula.Turma.Alunos)
            {
                aula.Presencas.Add(_context.Set<Presenca>().Where(p => p.IDAluno == i.Id).FirstOrDefault());
            }
            
            return aula;
        }
       
    }
}
