using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class Promocion
	{
		public Promocion()
		{
			promosDetalles = new HashSet<PromocionDetalle>();
		}
		public int promocionID { get; set; }

		[Required]
		public int tipo { get; set; }

		[Required]
		public string nombre { get; set; }
		public decimal descuento { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		[DisplayName("Fehca de inicio")]
		public DateTime fechaInicio { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		[DisplayName("Fehca de fin")]
		public DateTime fechaFin { get; set; }

		//Relacion una promocion a muchos promocion detalle
		public virtual ICollection<PromocionDetalle> promosDetalles { get; set; }
	}
}