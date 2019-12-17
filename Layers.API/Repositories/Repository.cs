using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Layers.API.Models;
using Layers.API.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Layers.API.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly IServiceScope _serviceScope;
        internal readonly LayersDbContext _contextDb;
        internal readonly DbSet<T> _dbSetEntity;
        public Repository(IServiceProvider serviceProvider)
        {
            this._serviceScope = serviceProvider.CreateScope();

            this._contextDb = this._serviceScope.ServiceProvider.GetRequiredService<LayersDbContext>();

            this._dbSetEntity = this._contextDb.Set<T>();
        }
        public virtual IEnumerable<T> GetAll()
        {
            return this._dbSetEntity.ToList();
        }
        public virtual T GetEntityByIdent(String ident)
        {
            return this._dbSetEntity.Find(ident);
        }
        public virtual T CreateEntity(T entity)
        {
            this._dbSetEntity.Add(entity);
            return entity;
        }
        public virtual Boolean UpdateEntity(T entity)
        {
            this._dbSetEntity.Attach(entity);
            this._contextDb.Entry(entity).State = EntityState.Modified;

            return true;
        }
        public virtual Boolean DeleteEntityByIdent(String ident)
        {
            T entity = this._dbSetEntity.Find(ident);
            return DeleteEntity(entity);
        }
        public virtual Boolean DeleteEntity(T entity)
        {
            this._dbSetEntity.Attach(entity);
            this._contextDb.Entry(entity).State = EntityState.Modified;

            return true;
        }

        public virtual void Save()
        {
            this._contextDb.SaveChanges();
        }
    }
}