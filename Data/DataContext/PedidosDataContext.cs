using Data.Mappings;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataContext
{
    public class PedidosDataContext : DbContext
    {
        public PedidosDataContext(DbContextOptions<PedidosDataContext> options) : base(options)
        {

        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<PedidoItem> PedidosItens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new PedidoMap()); 
        }
    }
}
