using Atividade2.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Atividade2.Dados
{
    public class FuncoesFuncionariosConfiguration : IEntityTypeConfiguration<FuncoesFuncionarios>
    {
        public void Configure(EntityTypeBuilder<FuncoesFuncionarios> builder)
        {
            builder
                .ToTable("FuncoesFuncionarios");

            builder.Property<Guid>("FuncionarioId").IsRequired();
            builder.Property<Guid>("FuncaoId").IsRequired();  

            builder.HasKey("FuncionarioId", "FuncaoId");

            builder
                .HasOne(ff => ff.Funcionario)
                .WithMany(item => item.Funcoes)
                .HasForeignKey("FuncionarioId");

            builder
                .HasOne(ff => ff.Funcao)
                .WithMany(item => item.Funcionarios)
                .HasForeignKey("FuncaoId");
        }
    }
}
