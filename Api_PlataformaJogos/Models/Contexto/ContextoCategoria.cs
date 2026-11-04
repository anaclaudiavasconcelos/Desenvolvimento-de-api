using Api_PlataformaJogos.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Api_PlataformaJogos.Models.Contexto
{
    public class ContextoCategoria : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = Environment.GetEnvironmentVariable("db1");
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Categoria>(entidade =>
            {
                
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.Nome);

                entidade.Property(e => e.Descricao);


            }

        );
        }
    }
}
