using Data.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido buscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Editar(Guid id, Pedido entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public Pedido Salvar(Pedido entity)
        {
            throw new NotImplementedException();
        }
    }
}
