using Aplication.Interfaces;
using Aplication.Interfaces.Base;
using Aplication.ViewModel;
using AutoMapper;
using Data.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public ClienteViewModel BuscarPorId(Guid id)
        {
            var clienteDB = _clienteRepository.buscarPorId(id);
            var clienteViewModel = Mapper.Map<ClienteViewModel>(clienteDB);
            return clienteViewModel;
        }

        public IEnumerable<ClienteViewModel> BuscarTodos()
        {
            var clientesDB = _clienteRepository.BuscarTodos();
            var clientesViewModel = Mapper.Map<IEnumerable<ClienteViewModel>>(clientesDB);
            return clientesViewModel;
        }

        public void Editar(Guid id, ClienteViewModel entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid id)
        {
            _clienteRepository.Excluir(id);
        }

        public ClienteViewModel Salvar(ClienteViewModel entity)
        {
            var clienteDB = Mapper.Map<Cliente>(entity);
            var clienteViewModel = Mapper.Map<ClienteViewModel>(_clienteRepository.Salvar(clienteDB));
            return clienteViewModel;
        }
    }
}
