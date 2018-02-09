using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class Categoria
	{
		public int categoria { get; set; }
		public string nombre { get; set; }
		public DateTime fechaCreacion { get; set; }

		//Relacion a varios productos
		public virtual ICollection<Producto> productos { get; set; }
	}
}