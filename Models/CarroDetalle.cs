using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoMVC.Models
{
	public class CarroDetalle
	{
		[Key]
		[Column(Order = 1)]
		public int carritoID { get; set; }

		[Key]
		[Column(Order = 2)]
		public int productoID { get; set; }

		[Required]
		public int cantidad { get; set; }

		[Required(ErrorMessage = "Proporcione un precio.")]
		[DisplayName("Precio unitario")]
		[Range(0, 10000)]
		public decimal precioUnitario { get; set; }

		[Required]
		public decimal total { get; set; }

		//Relacionado a un carrito.
		public virtual Carrito carrito { get; set; }

		//Relacionado a un producto.
		public virtual Producto producto { get; set; }
	}
}