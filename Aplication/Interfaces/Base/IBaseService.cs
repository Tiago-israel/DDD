using Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Interfaces.Base
{
    public interface IBaseService<T> where T : ModeloViewModel
    {
        T BuscarPorId(Guid id);
        IEnumerable<T> BuscarTodos();
        T Salvar(T entity);
        void Editar(Guid id, T entity);
        void Excluir(Guid id);
    }
}
