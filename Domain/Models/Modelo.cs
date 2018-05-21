using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Modelo
    {
        public Guid Id { get; set; }
        public DateTime AssinaturaAlteracao { get; set; } = DateTime.Now;
    }
}
