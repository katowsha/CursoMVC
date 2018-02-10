using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class Favorito
	{
		[Key]
		[Column(Order = 1)]
		public int usuarioId { get; set; }
		[Key]
		[Column(Order = 2)]
		public int productoId { get; set; }

		//Relacionado a un producto
		public virtual Producto producto { get; set; }
	}
}