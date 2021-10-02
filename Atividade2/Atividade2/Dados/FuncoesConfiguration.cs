using Atividade2.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Atividade2.Dados
{
    public class FuncoesConfiguration : IEntityTypeConfiguration<Funcoes>

    {
        public void Configure(EntityTypeBuilder<Funcoes> builder)
        {
            builder
                .ToTable("Funcoes");

            builder
                .Property(func => func.Id)
                .HasColumnName("Id");

            builder
                .Property(func => func.Descricao)
                .HasColumnName("Descricao");

            builder
                .Property(func => func.NivelAcesso)
                .HasColumnName("NivelAcesso");

            builder
                .Property<DateTime>("UltimaAtualizacao")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getDate()");
              
        }
    }
}
