using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappings
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("pedido");
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Data);
            builder.Property(p => p.Numero);
            builder.HasOne(p => p.Cliente).WithMany(p => p.Pedidos).HasForeignKey(p => p.IdCliente).HasConstraintName("IdCliente");
        }
    }
}
