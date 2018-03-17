using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;

namespace CursoMVC.Models
{
	public class Initializer : CreateDatabaseIfNotExists<CursoMVCContext>
	{
		protected override void Seed(CursoMVCContext context)
		{
			var usuarios = new List<Usuario>
			{
				new Usuario
				{
					usuarioID = Guid.NewGuid(),
					nombre = "Juan",
					apellidop = "lopez",
					apellidom = "juarez",
					password = "j1",
					direccion = "Av. Las Palmas 123",
					telefono = "1234-5678",
					email = "juan@outlook.com"
				},

				new Usuario
				{
					usuarioID = Guid.NewGuid(),
					nombre = "Maria",
					apellidop = "ladel",
					apellidom = "barrio",
					password = "mmm1",
					direccion = "Av. zapata 123",
					telefono = "134234-5678",
					email = "maria@outlook.com"
				}

			};

			usuarios.ForEach(s => context.Usuarios.Add(s));
			context.SaveChanges();
			Guid cat1 = Guid.NewGuid();
			Guid cat2 = Guid.NewGuid();
			var categorias = new List<Categoria>
			{
				new Categoria
				{
					categoriaID = cat1,
					nombre = "Utiles escolares",
					fechaCreacion = DateTime.Now
				},
				new Categoria
				{
					categoriaID = cat2,
					nombre = "Accesorios",
					fechaCreacion = DateTime.Now
				}
			};

			categorias.ForEach(s => context.Categorias.Add(s));
			context.SaveChanges();

			var productos = new List<Producto>
			{
				new Producto {
					productoID = Guid.NewGuid(),
					nombre = "Colores",
					descripcion = "Juego de 12 colores",
					precioLista = 20.0m,
					imagen = getFileBytes("\\Imagenes\\colores.jpg"),
					tipoImagen = "image/jpeg",
					categoriaID = cat1,
					activo = true,
					enAlmacen = true,
					fechaCreacion = DateTime.Now
				},
				new Producto {
					productoID = Guid.NewGuid(),
					nombre = "Tijeras",
					descripcion = "Tijeras metálicas",
					precioLista = 25.0m,
					imagen = getFileBytes("\\Imagenes\\tijeras.jpg"),
					tipoImagen = "image/jpeg",
					categoriaID = cat1,
					activo = true,
					enAlmacen = true,
					fechaCreacion = DateTime.Now
				},
				new Producto {
					productoID = Guid.NewGuid(),
					nombre = "Mochila",
					descripcion = "Mochila azul",
					precioLista = 200.0m,
					imagen = getFileBytes("\\Imagenes\\mochila.jpg"),
					tipoImagen = "image/jpeg",
					categoriaID = cat2,
					activo = true,
					enAlmacen = true,
					fechaCreacion = DateTime.Now
				}
			};

			productos.ForEach(s => context.Productos.Add(s));
			context.SaveChanges();

			base.Seed(context);
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