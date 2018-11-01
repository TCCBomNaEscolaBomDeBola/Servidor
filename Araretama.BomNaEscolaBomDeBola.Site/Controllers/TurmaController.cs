
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Araretama.BomNaEscolaBomDeBola.Site.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class TurmaController : Controller
    {
        // GET: Turma
        public ActionResult Index()
        {
            return View();
        }

        // GET: Turma/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Turma/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Turma/Create
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

        // GET: Turma/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Turma/Edit/5
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

        // GET: Turma/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Turma/Delete/5
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
