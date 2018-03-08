using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
	public class Promocion
	{
		public Promocion()
		{
			detalle = new HashSet<PromoDetalle>();
		}

		public int promocionID { get; set; }

		[Required]
		public int tipo { get; set; }
		[Required]
		public string nombre { get; set; }
		public decimal descuento { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
		[DisplayName("Fecha de inicio")]
		public DateTime fechaIni { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
		[DisplayName("Fecha de fin")]
		public DateTime fechaFin { get; set; }

		//Relacionado a varios promo detalles.
		public virtual ICollection<PromoDetalle> detalle { get; set; }
	}
}