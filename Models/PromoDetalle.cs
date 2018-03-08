using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoMVC.Models
{
	public class PromoDetalle
	{
		[Key]
		[Column(Order = 1)]
		public int promoID { get; set; }

		[Key]
		[Column(Order = 2)]
		public int productoID { get; set; }

		//Relacionado a una promoción.
		public virtual Promocion promocion { get; set; }
	}
}