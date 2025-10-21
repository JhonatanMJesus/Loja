using Microsoft.EntityFrameworkCore;
using Loja.Models;

namespace Loja.Data
{

    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuario> usuario { get; set; }

        public DbSet<Compra> compra { get; set; }

        public DbSet<Categoria> categoria { get; set; }

        public DbSet<Itens> item { get; set; }

        public DbSet<Produto> produto { get; set; }

        public DbSet<ProdutoCategoria> produto_categoria { get; set; }

    }

}