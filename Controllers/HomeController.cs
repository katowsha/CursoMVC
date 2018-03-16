using CursoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC.Controllers
{
	public class HomeController : Controller
	{
		private CursoMVCContext context = new CursoMVCContext();
        // GET: Home
        public ActionResult Index()
        {
			List<Producto> productos;
			productos = (
				from p in context.Productos
				orderby p.fechaCreacion descending
				select p).Take(3).ToList();

			ViewBag.Titulo = "<h1> Bienvenido a Office Diput </h1>";
			ViewBag.ProductosNuevos = productos;

			return View();
        }
    }
}