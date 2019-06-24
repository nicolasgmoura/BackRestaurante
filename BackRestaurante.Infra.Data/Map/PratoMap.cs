using BackRestaurante.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace BackRestaurante.Infra.Data.Map
{
    public class PratoMap : IEntityTypeConfiguration<Prato>
    {
        public void Configure(EntityTypeBuilder<Prato> builder)
        {
            builder.ToTable("Prato");

            builder.HasKey(x => x.IdPrato);

            builder.Property(x => x.NomePrato)
                .HasColumnName("NomePrato")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Preco)
               .HasColumnName("Preco")
               .IsRequired();
        }
    }
}
