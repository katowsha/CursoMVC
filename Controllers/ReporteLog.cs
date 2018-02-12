using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CursoMVC.Controllers
{
	public class ReporteLog : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			logger(filterContext.RouteData);
		}
		
		private void logger(RouteData ruta)
		{
			var controlador = ruta.Values["controller"];
			var accion = ruta.Values["action"];

			string mensaje = string.Format("Controlador: {0}; Accion: {1}", controlador, accion);

			Debug.WriteLine(mensaje, "Valores de accion:");

			foreach (var item in ruta.Values)
			{
				Debug.WriteLine("--> llave: {0}; Valor: {1}", item.Key, item.Value);
			}
		}
	}
}