using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class Usuario
	{
		public Usuario()
		{
			Carritos = new HashSet<Carrito>();
			Favoritos = new HashSet<Favorito>();
		}

		public int usuarioID { get; set; }

		[Required(ErrorMessage = "Proporcione el nombre")]
		[DisplayName("Nombre")]
		[StringLength(50)]
		public string nombre { get; set; }

		[Required(ErrorMessage = "Proporcione un nickname")]
		[StringLength(50)]
		public string usuario { get; set; }

		[Required(ErrorMessage = "Propocione una contraseña")]
		[StringLength(15)]
		public string password { get; set; }

		[DisplayName("Direccion")]
		public string direccion { get; set; }

		[DisplayName("Telefono")]
		public string telefono { get; set; }

		[DisplayName("e-mail")]
		public string email { get; set; }

		[DisplayName("Total vendido")]
		public decimal totalVendido { get; set; }

		//Relacion un usuario para muchos carritos
		public virtual ICollection<Carrito> Carritos { get; set; }
		
		//Relacion un usuario para muchos favoritos
		public virtual ICollection<Favorito> Favoritos { get; set; }
	}
}