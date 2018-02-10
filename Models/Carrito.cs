using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class Carrito
	{
		public int carritoId { get; set; }
		public int usuarioId { get; set; }
		public bool abierto { get; set; }
		public DateTime fechaVenta { get; set; }
		public decimal total { get; set; }

		//Relacion de carritos a un usuario
		public virtual Usuario usuario { get; set; }

		//Relacion de carrito a muchos detalles de carrito
		public virtual ICollection<CarritoDetalle> carritosDetalles { get; set; }
	}
}