using Microsoft.EntityFrameworkCore;

namespace Br.Ufmt.Web.Curso
{
    public class CursoContext : DbContext
    {
        public DbSet<Contas> Contas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Despesas> Despesas { get; set; }
        public DbSet<Receitas> Receitas { get; set; }
        public DbSet<Empenhos> Empenhos { get; set; }
        public DbSet<Liquidacoes> Liquidacoes { get; set; }
        public DbSet<Pagamentos> Pagamentos { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Vendas> Vendas { get; set; }
        public DbSet<Clientes> Clientes { get; set; }


        public CursoContext(DbContextOptions<CursoContext> op) : base(op)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseHiLo("seq_id_disciplina");
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
            modelBuilder.Entity<Contas>().ToTable("Contas");
            modelBuilder.Entity<Despesas>().ToTable("Despesas");
            modelBuilder.Entity<Receitas>().ToTable("Receitas");
            modelBuilder.Entity<Empenhos>().ToTable("Empenhos");
            modelBuilder.Entity<Liquidacoes>().ToTable("Liquidacoes");
            modelBuilder.Entity<Pagamentos>().ToTable("Pagamentos");
            modelBuilder.Entity<Estoque>().ToTable("Estoque");
            modelBuilder.Entity<Vendas>().ToTable("Vendas");
            modelBuilder.Entity<Clientes>().ToTable("Clientes");

        }
    }
}