using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Produto : Modelo
    {
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
