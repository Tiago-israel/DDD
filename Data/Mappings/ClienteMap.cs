using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome);
            builder.Property(p => p.Email);
            builder.Property(p => p.Foto);
            builder.Property(p => p.AssinaturaAlteracao);
            builder.HasMany<Pedido>(c => c.Pedidos).WithOne(p => p.Cliente).HasForeignKey("IdCliente");
        }
    }
}
