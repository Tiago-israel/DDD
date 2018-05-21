using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces.Base
{
    public interface IBaseRepository<T> where T : Modelo
    {
        T Salvar(T entity);
        void Editar(Guid id, T entity);
        void Excluir(Guid id);
        IEnumerable<T> BuscarTodos();
        T buscarPorId(Guid id);
    }
}
