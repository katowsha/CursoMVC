using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoMVC.Models
{
	public class Favorito
	{
		[Key]
		[Column(Order = 1)]
		public int usuarioID { get; set; }

		[Key]
		[Column(Order = 2)]
		public int productoID { get; set; }

		//Relacionado a un producto.
		public virtual Producto producto { get; set; }
	}
}