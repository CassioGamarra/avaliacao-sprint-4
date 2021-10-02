using Microsoft.EntityFrameworkCore;
using Atividade2.Negocio;

namespace Atividade2.Dados
{
    public class CidadesContexto : DbContext
    {
        public DbSet<Cidades> Cidades { get; set;}
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<PrefeitosAtuais> PrefeitosAtuais { get; set; }
        public DbSet<Funcoes> Funcoes { get; set; }
        public DbSet<FuncoesFuncionarios> FuncoesFuncionarios { get; set; }
        public DbSet<VW_ALL_FUNCIONARIOS> VW_ALL_FUNCIONARIOS { get; set; }
        public DbSet<SP_ADD_CIDADE> SP_ADD_CIDADE { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=Cidades; Uid=sa; Pwd=Cjgo3291@; Trusted_Connection=no");
        }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CidadesConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionariosConfiguration());
            modelBuilder.ApplyConfiguration(new PrefeitosAtuaisConfiguration());
            modelBuilder.ApplyConfiguration(new FuncoesConfiguration());
            modelBuilder.ApplyConfiguration(new FuncoesFuncionariosConfiguration());
            modelBuilder.ApplyConfiguration(new VW_ALL_FUNCIONARIOSConfiguration());
        }
    }
}
