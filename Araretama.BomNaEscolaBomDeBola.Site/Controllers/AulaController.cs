using Araretama.BomNaEscolaBomDeBola.DataAccess.Entity.Context;
using Araretama.BomNaEscolaBomDeBola.Domain;
using Araretama.BomNaEscolaBomDeBola.Repository.Entity;
using AraretamaRepositoy;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Araretama.BomNaEscolaBomDeBola.Site.Controllers
{
    public class AulaController : Controller
    {
        private DbContext _Context;
        PresencaRepository PresencaRepository;
        AulaRepository AulaRepository;
        private IAraretamaCommonRepository<Aula, int> _repository = new AulaRepository(new BomNaEscolaBomDeBolaDbContext());
        
        public AulaController()
        {
            PresencaRepository = new PresencaRepository(new BomNaEscolaBomDeBolaDbContext());
            AulaRepository = new AulaRepository(new BomNaEscolaBomDeBolaDbContext());

        }

       

        // GET: Aula
        public ActionResult Index(int? page, string sortOrder = "", string currentFilter = "", string searchString = "")
        {
            List<Aula> a = _repository.All();
            return View(a.ToPagedList((page ?? 1), 5));
        }

        // GET: Aula/Details/5
        public ActionResult Details(int id)
        {
            return View(AulaRepository.DetalhesAula(id));
        }

        // GET: Aula/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aula/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Aula aula1 = new Aula
                {
                    DataAula = Convert.ToDateTime(collection["DataAula"]),
                    DataEnvio = Convert.ToDateTime(collection["DataEnvio"]),
                    Horario = Convert.ToDateTime(collection["Horario"]),
                    IDTurma = Convert.ToInt32(collection["IDTurma"])

                };


                _repository.Insert(aula1);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Aula/Chamada
        public ActionResult Chamada(int id)
        {
            return View(AulaRepository.DetalhesAula(id));
        }

        // POST: Aula/Chamada
        [HttpPost]
        public ActionResult Chamada(int id, Aula aula, FormCollection collection)
        {
            try
            {
                foreach (var i in aula.Presencas)
                {
                    PresencaRepository.Insert(i);
                }
                aula.DataEnvio = DateTime.Now;
                _repository.Update(aula);

                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Aula/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repository.ByKey(id));
        }

        // POST: Aula/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Aula aula1 = new Aula
                {
                    DataAula = Convert.ToDateTime(collection["DataAula"]),
                    DataEnvio = Convert.ToDateTime(collection["DataEnvio"]),
                    Horario = Convert.ToDateTime(collection["Horario"]),
                    IDTurma = Convert.ToInt32(collection["IDTurma"])

                };
                aula1.Id = id;

                _repository.Update(aula1);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Aula/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repository.ByKey(id));
        }

        // POST: Aula/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Aula aula, FormCollection collection)
        {
            try
            {
                _repository.DeleteByKey(id);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return View(_repository.ByKey(id));

            }
        }
    }
}
