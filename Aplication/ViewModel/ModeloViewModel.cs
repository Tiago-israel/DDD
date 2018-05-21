using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.ViewModel
{
    public class ModeloViewModel
    {
        public Guid Id { get; set; }
        public DateTime AssinaturaAlteracao { get; set; } = DateTime.Now;
    }
}
