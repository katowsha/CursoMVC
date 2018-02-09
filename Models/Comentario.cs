using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class Comentario
	{
		public int comentarioId { get; set; }
		public int usuarioId { get; set; }
		public int productoId { get; set; }
		public string texto { get; set; }
		public DateTime fecha { get; set; }
	}
}