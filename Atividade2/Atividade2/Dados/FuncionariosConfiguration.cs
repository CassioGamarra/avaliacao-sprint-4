using Atividade2.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Atividade2.Dados
{
    public class FuncionariosConfiguration : IEntityTypeConfiguration<Funcionarios>
    {
        public void Configure(EntityTypeBuilder<Funcionarios> builder)
        {
            builder
                .ToTable("Funcionarios");

            builder
                .Property(f => f.Id)
                .HasColumnName("Id");

            builder
                .Property(f => f.Nome)
                .HasColumnName("Nome");

            builder
                .Property(f => f.DataNascimento)
                .HasColumnName("DataNascimento")
                .IsRequired(); 

            builder
                .Property<DateTime>("UltimaAtualizacao")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getDate()");

            builder.Property<Guid>("CidadeId");

            builder
                .HasOne(f => f.Cidade)
                .WithMany(c => c.Funcionarios)
                .HasForeignKey("CidadeId"); 
        }
    }
}
