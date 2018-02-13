using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class CarritoDetalle
	{
		[Key]
		[Column(Order = 1)]
		public int carritoID { get; set; }

		[Key]
		[Column(Order = 2)]
		public int productoID { get; set; }

		[Required]
		public int cantidad { get; set; }

		[Required(ErrorMessage = "Tiene que especificar un precio")]
		[DisplayName("Precio Unitario")]
		[Range(0, 10000)]
		public decimal precioUnitario { get; set; }

		[Required]
		public decimal total { get; set; }

		//Relacionado a un carrito
		public virtual Carrito carrito {get;set;}

		//Relacionado a un producto
		public virtual Producto producto { get; set; }

	}
}