using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
	public class Categoria
	{
		public Categoria()
		{
			productos = new HashSet<Producto>();
		}

		public int categoriaID { get; set; }

		[Required(ErrorMessage = "Proporcione un nombre.")]
		[DisplayName("Categorìa")]
		[StringLength(100)]
		public string nombre { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
		[DisplayName("Fecha de creación")]
		public DateTime fechaCreacion { get; set; }

		//Relacionado a varios productos.
		public virtual ICollection<Producto> productos { get; set; }

	}
}