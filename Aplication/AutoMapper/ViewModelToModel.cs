using Aplication.ViewModel;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.AutoMapper
{
    public class ViewModelToModel : Profile
    {
        public ViewModelToModel() {
            CreateMap<ClienteViewModel, Cliente>().ReverseMap();
            CreateMap<ProdutoViewModel, Produto>().ReverseMap();
            CreateMap<PedidoViewModel, Pedido>().ReverseMap();
            CreateMap<PedidoItemViewModel, PedidoItem>().ReverseMap();
        }
    }
}
