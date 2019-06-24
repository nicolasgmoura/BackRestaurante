using BackRestaurante.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackRestaurante.Infra.Data.Map
{
    public class RestauranteMap : IEntityTypeConfiguration<Restaurante>
    {
        public void Configure(EntityTypeBuilder<Restaurante> builder)
        {
            builder.ToTable("Restaurante");

            builder.HasKey(x => x.IdRestaurante);

            builder.Property(x => x.NomeRestaurante)
                .HasColumnName("NomeRestaurante")
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
