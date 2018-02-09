using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC.Models
{
	public class Producto
	{

		public int productoId { get; set; }

		[Required(ErrorMessage = "Debe tener un nombre")]
		[DisplayName("Nombre")]
		[StringLength(250)]
		public string nombre { get; set; }

		[Required(ErrorMessage = "Proporcione una imagen")]
		public byte[] imagen { get; set; }

		public string tipoImagen { get; set; }

		[Required(ErrorMessage = "Debe tener una descripcion")]
		[DisplayName("Descripcion")]
		[StringLength(250)]
		public string descripcion { get; set; }

		[Required(ErrorMessage = " Debe tener precio")]
		[DisplayName("Precio de lista")]
		[DataType(DataType.Currency)]
		[Range(0, 100000)]
		[ValidaMultiplode(50)]
		public decimal precioLista { get; set; }

		public int categoriaId { get; set; }

		public bool activo { get; set; }

		[DisplayName("En almacen")]
		public bool enAlmacen { get; set; }

		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		[DisplayName("Fecha de creacion")]
		public DateTime fechaCreacion { get; set; }

		public virtual Categoria categoria {get;set;}
	}

	//Clase validar multiplo de param
	[AttributeUsage(AttributeTargets.Property)]
	public class ValidaMultiplode : ValidationAttribute
	{
		public double Valor { get; set; }
	
		public ValidaMultiplode(double n)
		{
			Valor = n;
			ErrorMessage = "El precio no es multiplo de " + Valor;
		}
		public override bool IsValid(object value)
		{
			var valorAEvaluar = (double)value;
			if ((valorAEvaluar % Valor) == 0)
				return true;
			else
				return false;
		}
	}
}