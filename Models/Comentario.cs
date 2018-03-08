using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
	public class Comentario
	{
		public int comentarioID { get; set; }
		public int usuarioID { get; set; }
		public int productoID { get; set; }

		[Required]
		public string texto { get; set; }

		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
		[DisplayName("Fecha")]
		public DateTime fechaCreacion { get; set; }
	}
}