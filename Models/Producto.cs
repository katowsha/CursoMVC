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
		public int productoID { get; set; }

		[Required(ErrorMessage = "Proporcione un nombre.")]
		[DisplayName("Nombre")]
		[StringLength(250)]
		public string nombre { get; set; }

		[Required(ErrorMessage = "Proporcione una imagen.")]
		public byte[] imagen { get; set; }

		public string tipoImagen { get; set; }

		[Required(ErrorMessage = "Proporcione una descripción.")]
		[DisplayName("Descripción")]
		[StringLength(250)]
		[DataType(DataType.MultilineText)]
		public string descripcion { get; set; }

		[Required(ErrorMessage = "Proporcione un precio.")]
		[DisplayName("Precio de Lista")]
		[Range(0, 10000)]
		[ValidaMultiploDe(50)]
		public decimal precioLista { get; set; }

		[DisplayName("Categoría")]
		[Required(ErrorMessage = "Seleccione una categoría.")]
		public int categoriaID { get; set; }

		[DisplayName("Activo")]
		public bool activo { get; set; }

		[DisplayName("En almacen")]
		public bool enAlmacen { get; set; }

		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
		[DisplayName("Fecha de creación")]
		public DateTime fechaCreacion { get; set; }


		//Relacionado a una categoría.
		public virtual Categoria categoria { get; set; }

	}


	//Clase validar multiplo de param
	[AttributeUsage(AttributeTargets.Property)]
	public class ValidaMultiploDe : ValidationAttribute
	{
		public double Valor { get; set; }

		public ValidaMultiploDe(double n)
		{
			Valor = n;
			ErrorMessage = "El precio no es múltiplo de " + Valor;
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