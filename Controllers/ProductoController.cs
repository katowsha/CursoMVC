using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CursoMVC.Models;

namespace CursoMVC.Controllers
{
    public class ProductoController : Controller
    {
        private CursoMVCContext db = new CursoMVCContext();

        // GET: Producto
        public ActionResult Index()
        {
            var productos = db.Productos.Include(p => p.categoria);
            return View(productos.ToList());
        }

        // GET: Producto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            ViewBag.categoriaID = new SelectList(db.Categorias, "categoriaID", "nombre");
			Producto producto = new Producto();
			producto.fechaCreacion = DateTime.Now;
            return View(producto);
        }

        // POST: Producto/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Producto producto, HttpPostedFileBase imagen)

		{
            if (ModelState.IsValid)
            {
				if (imagen != null)
				{
					producto.tipoImagen = imagen.ContentType;
					producto.imagen = new byte[imagen.ContentLength];
					imagen.InputStream.Read(producto.imagen, 0, imagen.ContentLength);
				}
				db.Productos.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.categoriaID = new SelectList(db.Categorias, "categoriaID", "nombre", producto.categoriaID);
            return View(producto);
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            ViewBag.categoriaID = new SelectList(db.Categorias, "categoriaID", "nombre", producto.categoriaID);
            return View(producto);
        }

        // POST: Producto/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "productoID,nombre,imagen,tipoImagen,descripcion,precioLista,categoriaID,activo,enAlmacen,fechaCreacion")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categoriaID = new SelectList(db.Categorias, "categoriaID", "nombre", producto.categoriaID);
            return View(producto);
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // POST: Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Producto producto = db.Productos.Find(id);
            db.Productos.Remove(producto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

		public FileContentResult GetImage(int id)
		{
			Producto producto = db.Productos.Find(id);
			if (producto != null)
			{
				return File(producto.imagen, producto.tipoImagen);
			}
			else
			{
				return null;
			}
		}

		public ActionResult Fabrica(int id)
		{
			return new RedirectResult("http://www.google.com");
		}

		protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
