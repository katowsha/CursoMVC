﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
		[DisplayName("Nombre")]
		[StringLength(100)]
		public string nombre { get; set; }

		//Relacionado a varios productos.
		public virtual ICollection<Producto> productos { get; set; }
	}
}