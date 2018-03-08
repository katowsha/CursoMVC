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
		public int carritoID { get; set; }

		[Required]
		public int usuarioID { get; set; }

		[Required]
		public bool abierto { get; set; }

		[DataType(DataType.DateTime)]
		[DisplayName("Fecha de Venta")]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
		public DateTime fechaVenta { get; set; }

		public decimal total { get; set; }

		//Relacionado a un usuario.
		public virtual Usuario usuario { get; set; }
	}
}