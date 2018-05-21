using Data.DataContext;
using Data.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly PedidosDataContext _pedidosDataContext;

        public ProdutoRepository(PedidosDataContext pedidosDataContext)
        {
            _pedidosDataContext = pedidosDataContext;
        }

        public Produto buscarPorId(Guid id)
        {
            var produto = _pedidosDataContext.Produtos.FirstOrDefault(x => x.Id == id);
            return produto;
        }

        public IEnumerable<Produto> BuscarTodos()
        {
            var produtos = _pedidosDataContext.Produtos.ToList();
            return produtos;
        }

        public void Editar(Guid id, Produto entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid id)
        {
            var produto = this.buscarPorId(id);
            _pedidosDataContext.Produtos.Remove(produto);
            _pedidosDataContext.SaveChanges();
        }

        public Produto Salvar(Produto entity)
        {
            try
            {
                _pedidosDataContext.Produtos.Add(entity);
                _pedidosDataContext.SaveChanges();
                entity = this.buscarPorId(entity.Id);
                return entity;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
