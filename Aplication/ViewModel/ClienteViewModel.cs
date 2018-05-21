using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.ViewModel
{
    public class ClienteViewModel : ModeloViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }
        public string File { get; set; }
        public virtual ICollection<PedidoViewModel> Pedidos { get; set; }
    }
}
