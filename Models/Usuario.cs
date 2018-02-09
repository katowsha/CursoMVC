using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class Usuario
	{
		public int usuarioId { get; set; }
		public string nombre { get; set; }
		public string usuario { get; set; }
		public string password { get; set; }
		public string direccion { get; set; }
		public string telefono { get; set; }
		public string email { get; set; }
		public decimal totalVendido { get; set; }
	}
}