﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class PromocionDetalle
	{
		public int promocionDetalleId { get; set; }
		public int productoId { get; set; }

		//Relacion una promo detalle a una promo
		public virtual Promocion promocion { get; set; }
	}
}