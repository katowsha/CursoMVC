using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class CarritoDetalle
	{
		public int carritoId { get; set; }
		public int productoId { get; set; }
		public int cantidad { get; set; }
		public decimal precioUnitario { get; set; }
		public decimal total { get; set; }
	}
}