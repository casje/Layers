using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Layers.API.Models;

namespace Layers.API.Repositories
{
    public interface IRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();
        T GetEntityByIdent(String ident);
        T CreateEntity(T entity);
        Boolean UpdateEntity(T entity);
        Boolean DeleteEntityByIdent(String ident);
        Boolean DeleteEntity(T entity);
        void Save();
    }
}