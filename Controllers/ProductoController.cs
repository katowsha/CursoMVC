using CursoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC.Controllers
{
    public class ProductoController : Controller
    {
		private CursoMVCContext context = new CursoMVCContext();
		// GET: Producto
		public ActionResult Index()
        {
            return View("Index",context.Productos.ToList());
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
			Producto producto = context.Productos.Find(id);
			if (producto == null)
				return HttpNotFound();
            return View(producto);
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
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

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            return Content("Aun no se ha codificado la vista para edicion...");
        }

        // POST: Producto/Edit/5
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

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Producto/Delete/5
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
		public FileContentResult GetImage(int id)
		{
			Producto producto = context.Productos.Find(id);
			if (producto != null)
				return File(producto.imagen, producto.tipoImagen);
			else
				return null;
		}

		public ActionResult Fabrica(int id)
		{
			return new RedirectResult("http://www.google.com");
		}

		

	}
}
