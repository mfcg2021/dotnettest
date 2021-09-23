using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiAngular.Model
{
    public class ent : Controller
    {
        // GET: ent
        public ActionResult Index()
        {
            return View();
        }

        // GET: ent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ent/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ent/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ent/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
