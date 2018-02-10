using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class Promocion
	{
		public int promocionId { get; set; }
		public int tipo { get; set; }
		public string nombre { get; set; }
		public decimal descuento { get; set; }
		public DateTime fechaInicio { get; set; }
		public DateTime fechaFin { get; set; }

		//Relacion una promocion a muchos promocion detalle
		public virtual ICollection<PromocionDetalle> promosDetalles { get; set; }
	}
}