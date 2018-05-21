using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.ViewModel
{
    public class PedidoViewModel : ModeloViewModel
    {
        public Guid IdCliente { get; set; }
        public DateTime Data { get; set; }
        public long Numero { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}
