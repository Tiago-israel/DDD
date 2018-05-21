using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Cliente : Modelo
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
