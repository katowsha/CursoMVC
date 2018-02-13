using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CursoMVC.Models
{
	public class CursoMVCContext : DbContext
	{
		public CursoMVCContext()
		{
			Database.SetInitializer(new Initializer());
		}
			
		public DbSet<Categoria> Categorias
		{ get; set; }
		public DbSet<Producto> Productos
		{ get; set; }
		public DbSet<Usuario> Usuarios
		{ get; set; }
		public DbSet<Carrito> Carritos
		{ get; set; }
		public DbSet<CarritoDetalle> CarrosDetalle
		{ get; set; }
		public DbSet<Comentario> Comentarios
		{ get; set; }
		public DbSet<Favorito> Favoritos
		{ get; set; }
		public DbSet<Promocion> Promociones
		{ get; set; }
		public DbSet<PromocionDetalle> PromoDetalles
		{ get; set; }
	}
}