using Data.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class PedidoItemRepository : IPedidoItemRepository
    {
        public PedidoItem buscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PedidoItem> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Editar(Guid id, PedidoItem entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public PedidoItem Salvar(PedidoItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
