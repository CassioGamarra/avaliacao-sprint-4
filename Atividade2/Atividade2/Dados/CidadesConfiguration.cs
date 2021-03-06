using Atividade2.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Atividade2.Dados
{
    public class CidadesConfiguration : IEntityTypeConfiguration<Cidades>
    {
        public void Configure(EntityTypeBuilder<Cidades> builder)
        {
            builder
                .ToTable("Cidades");

            builder
                .Property(c => c.Id)
                .HasColumnName("Id");

            builder
                .Property(c => c.Nome)
                .HasColumnName("Nome");

            builder
                .Property(c => c.Populacao)
                .HasColumnName("Populacao")
                .IsRequired();

            builder
                .Property(c => c.TaxaCriminalidade)
                .HasColumnName("TaxaCriminalidade")
                .IsRequired();

            builder
                .Property(c => c.ImpostoSobreProduto)
                .HasColumnName("ImpostoSobreProduto")
                .IsRequired();

            builder
                .Property(c => c.EstadoCalamidade)
                .HasColumnName("EstadoCalamidade")
                .IsRequired();

            builder
                .Property<DateTime>("UltimaAtualizacao")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getDate()");

        }
    }
}
