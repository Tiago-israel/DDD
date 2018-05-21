using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class PedidoItem : Modelo
    {
        public long Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public Guid IdProduto { get; set; }
        public Guid IdPedido { get; set; }


        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }
    }
}
