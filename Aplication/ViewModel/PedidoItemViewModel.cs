using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.ViewModel
{
    public class PedidoItemViewModel : ModeloViewModel
    {
        public long Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public Guid IdProduto { get; set; }
        public Guid IdPedido { get; set; }


        public ProdutoViewModel Produto { get; set; }
        public PedidoViewModel Pedido { get; set; }
    }
}
