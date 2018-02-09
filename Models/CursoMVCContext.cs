using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CursoMVC.Models
{
	public class CursoMVCContext : DbContext
	{
		public DbSet<Categoria> Categorias { get; set; }
		public DbSet<Producto> Productos { get; set; }
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Carrito> Carritos { get; set; }
	}
}