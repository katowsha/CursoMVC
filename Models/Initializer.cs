using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;

namespace CursoMVC.Models
{
	public class Initializer : DropCreateDatabaseAlways<CursoMVCContext>
	{
		protected override void Seed(CursoMVCContext context)
		{
			base.Seed(context);

			var categorias = new List<Categoria>
			{
				new Categoria
				{
					nombre = "Utiles escolares",
					fechaCreacion = DateTime.Now

				},
				new Categoria
				{
					nombre = "Accesorios",
					fechaCreacion = DateTime.Now
				}
			};

			categorias.ForEach(s => context.Categorias.Add(s));
			context.SaveChanges();

			var productos = new List<Producto>
			{
				new Producto
				{
					nombre = "ProductoPrueba",
					descripcion = "Descripcion de prueba",
					precioLista = 20,
					imagen = getFileBytes("\\Imagenes\\prueba.jpg"),
					categoriaId = 1

				}
			};

			productos.ForEach(s => context.Productos.Add(s));
			context.SaveChanges();
		}
		private byte[] getFileBytes(string path)
		{
			FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
			byte[] fileBytes;
			using (BinaryReader br = new BinaryReader(fileOnDisk))
			{
				fileBytes = br.ReadBytes((int)fileOnDisk.Length);
			}
			return fileBytes;
		}
	}
}