using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class Carrito
	{
		public Carrito()
		{
			carritosDetalles = new HashSet<CarritoDetalle>();
		}

		public int carritoId { get; set; }

		[Required]
		public int usuarioId { get; set; }

		[Required]
		public bool abierto { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		[DisplayName("Fecha de Venta")]
		[DisplayFormat(DataFormatString ="{0:dd/MM/yyy}")]
		public DateTime fechaVenta { get; set; }

		[Required]
		public decimal total { get; set; }

		//Relacion de carritos a un usuario
		public virtual Usuario usuario { get; set; }

		//Relacion de carrito a muchos detalles de carrito
		public virtual ICollection<CarritoDetalle> carritosDetalles { get; set; }
	}
}