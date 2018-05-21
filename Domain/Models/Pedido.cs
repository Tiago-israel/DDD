using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Pedido : Modelo
    {

        public Guid IdCliente { get; set; }
        public DateTime Data { get; set; }
        public long Numero { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
