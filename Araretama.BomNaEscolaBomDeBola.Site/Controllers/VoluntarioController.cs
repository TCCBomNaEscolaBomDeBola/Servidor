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
   // [Authorize(Roles = "Administrador")]
    public class VoluntarioController : Controller
    {
        private DbContext _Context;

        private IAraretamaCommonRepository<Voluntario, int> _repository = new VoluntarioRepository(new BomNaEscolaBomDeBolaDbContext());

        // GET: Voluntario
        public ActionResult Index(int? page, string sortOrder = "", string currentFilter = "", string searchString = "")
        {
            List<Voluntario> a = _repository.All();
            return View(a.ToPagedList((page ?? 1), 5));
        }

        // GET: Voluntario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Voluntario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Voluntario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Voluntario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Voluntario/Edit/5
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

        // GET: Voluntario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Voluntario/Delete/5
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
