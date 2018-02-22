using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class PromocionDetalle
	{
		[Key]
		[Column(Order = 1)]
		public int promocionDetalleId { get; set; }

		[Key]
		[Column(Order = 2)]
		public int productoId { get; set; }

		//Relacion una promo detalle a una promo
		public virtual Promocion promocion { get; set; }
	}
}