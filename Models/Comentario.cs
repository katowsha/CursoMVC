using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class Comentario
	{
		public int comentarioId { get; set; }
		public int usuarioId { get; set; }
		public int productoId { get; set; }
		[Required]
		public string texto { get; set; }

		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString ="{0;dd/MM/yyyy}")]
		[DisplayName("Fecha")]
		public DateTime fecha { get; set; }
	}
}