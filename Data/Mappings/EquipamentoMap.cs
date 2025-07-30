using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReservaApp.Models;

namespace ReservaApp.Data.Mappings
{
    public class EquipamentoMap : IEntityTypeConfiguration<Equipamento>
    {
        public void Configure(EntityTypeBuilder<Equipamento> builder)
        {
            builder.ToTable("Equipamento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.NomeEquipamento)
                .IsRequired()
                .HasColumnName("NomeEquipamento")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.NomePessoa)
                .IsRequired()
                .HasColumnName("NomePessoa")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(X => X.DataReservado)
                .IsRequired()
                .HasColumnName("DataReservado")
                .HasColumnType("SMALLDATETIME")
                .HasMaxLength(60);

            builder.Property(x => x.DataDevolucao)
                .IsRequired()
                .HasColumnName("DataDevolucao")
                .HasColumnType("SMALLDATETIME")
                .HasMaxLength(60);

            builder
                .HasIndex(x => x.NomeEquipamento, "IX_NomeEquipamento");
        }
    }
}