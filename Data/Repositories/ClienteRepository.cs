using Data.DataContext;
using Data.Interfaces.Repository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly PedidosDataContext _pedidosDataContext;

        public ClienteRepository(PedidosDataContext pedidosDataContext)
        {
            _pedidosDataContext = pedidosDataContext;
        }

        public Cliente buscarPorId(Guid id)
        {
            return _pedidosDataContext.Clientes.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Cliente> BuscarTodos()
        {
            return _pedidosDataContext.Clientes.Include(c => c.Pedidos).ToList();
        }

        public void Editar(Guid id, Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid id)
        {
            var clienteDb = this.buscarPorId(id);
            if (clienteDb != null)
            {
                _pedidosDataContext.Clientes.Remove(clienteDb);
                _pedidosDataContext.SaveChanges();
            }
        }

        public Cliente Salvar(Cliente entity)
        {
            try
            {
                _pedidosDataContext.Clientes.Add(entity);
                _pedidosDataContext.SaveChanges();
                return entity;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
