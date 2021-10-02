using Atividade2.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Atividade2.Dados
{
    public class PrefeitosAtuaisConfiguration : IEntityTypeConfiguration<PrefeitosAtuais>
    {
        public void Configure(EntityTypeBuilder<PrefeitosAtuais> builder)
        {
            builder
                .ToTable("PrefeitosAtuais");

            builder
                .Property(pa => pa.Id)
                .HasColumnName("Id");

            builder
                .Property(pa => pa.Nome)
                .HasColumnName("Nome");

            builder
                .Property(pa => pa.InicioMandato)
                .HasColumnName("InicioMandato")
                .IsRequired();
            builder
               .Property(pa => pa.FimMandato)
               .HasColumnName("FimMandato")
               .IsRequired();
             
            builder.Property<Guid>("CidadeId");

            builder
                .HasOne(pa => pa.Cidade)
                .WithMany(c => c.PrefeitosAtuais)
                .HasForeignKey("CidadeId");
        }
    }
}
