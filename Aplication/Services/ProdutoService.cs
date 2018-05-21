using Aplication.Interfaces;
using Aplication.Interfaces.Base;
using Aplication.ViewModel;
using AutoMapper;
using Data.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) {
            _produtoRepository = produtoRepository;
        }

        public ProdutoViewModel BuscarPorId(Guid id)
        {
            var produtoDB = _produtoRepository.buscarPorId(id);
            var produtoViewModel = Mapper.Map<ProdutoViewModel>(produtoDB);
            return produtoViewModel;
        }

        public IEnumerable<ProdutoViewModel> BuscarTodos()
        {
            var produtosDB = _produtoRepository.BuscarTodos();
            var produtosViewModel = Mapper.Map<IEnumerable<ProdutoViewModel>>(produtosDB);
            return produtosViewModel;
        }

        public void Editar(Guid id, ProdutoViewModel entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public ProdutoViewModel Salvar(ProdutoViewModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
