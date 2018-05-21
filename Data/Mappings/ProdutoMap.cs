using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produto");
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Preco);
            builder.Property(p => p.Descricao);
            builder.Property(p => p.AssinaturaAlteracao);
        }
    }
}
