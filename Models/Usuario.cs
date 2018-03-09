using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
	public class Usuario
	{
		public Usuario()
		{
			carritos = new HashSet<Carrito>();
			favoritos = new HashSet<Favorito>();
		}

		public int usuarioID { get; set; }

		[Required(ErrorMessage = "Proporcione el nombre.")]
		[DisplayName("Nombre")]
		[StringLength(50)]
		public string nombre { get; set; }

		[Required(ErrorMessage = "Proporcione el apellido p.")]
		[DisplayName("Apellido Paterno")]
		[StringLength(50)]
		public string apellidop { get; set; }

		[Required(ErrorMessage = "Proporcione el apellido m.")]
		[DisplayName("Apellido Materno")]
		[StringLength(50)]
		public string apellidom { get; set; }

		[DisplayName("Contraseña")]
		[Required(ErrorMessage = "Proporcione una contraseña.")]
		[StringLength(10)]
		[DataType(DataType.Password)]
		public string password { get; set; }

		[DisplayName("Dirección")]
		[StringLength(250)]
		public string direccion { get; set; }

		[DisplayName("Teléfono")]
		[StringLength(20)]
		public string telefono { get; set; }

		[DisplayName("Correo electrónico")]
		[DataType(DataType.EmailAddress)]
		public string email { get; set; }

		[DisplayName("Total vendido")]
		public decimal totalVendido { get; set; }

		//Relacionado a varios carritos.
		public virtual ICollection<Carrito> carritos { get; set; }

		//Relacionado a varios favoritos.
		public virtual ICollection<Favorito> favoritos { get; set; }
	}
}