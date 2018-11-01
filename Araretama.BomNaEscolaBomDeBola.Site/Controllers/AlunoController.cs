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
    [Authorize(Roles = "Administrador")]
    public class AlunoController : Controller
    {
        private DbContext _Context;

        private IAraretamaCommonRepository<Aluno, int> _repository = new AlunoRepository(new BomNaEscolaBomDeBolaDbContext());

        // GET: Aluno
        public ActionResult Index(int? page, string sortOrder="", string currentFilter="", string searchString="")
        {
            List<Aluno> a = _repository.All();
            return View(a.ToPagedList((page ?? 1), 5));
        }

        // GET: Aluno/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Aluno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aluno/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Aluno aluno = new Aluno
                {
                    Bairro = collection["bairro"],
                    Cep = collection["cep"],
                    Cidade = collection["cidade"],
                    Complemento = collection["complemento"],
                    Contato = collection["contato"],
                    DataNasc = collection["dataNasc"],
                    Escola = collection["escola"],
                    Estado = collection["estado"],
                    Logradouro = collection["logradouro"],
                    Nome = collection["nome"],
                    Numero = collection["numero"],
                    Observacao = collection["observacao"],
                    Responsavel = collection["responsavel"],
                    Serie = collection["serie"]
                };


                _repository.Insert(aluno);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Aluno/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Aluno/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Aluno/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Aluno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
