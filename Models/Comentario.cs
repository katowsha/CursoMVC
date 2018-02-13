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
		public int comentarioID { get; set; }
		public int usuarioID { get; set; }
		public int productoID { get; set; }
		[Required]
		public string texto { get; set; }

		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString ="{0;dd/MM/yyyy}")]
		[DisplayName("Fecha")]
		public DateTime fecha { get; set; }
	}
}