using AmazingBank.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingBank.DomainModel.Interfaces.Repositories
{
    public interface IRepository<T, EntityId> where T : EntityBase<EntityId>
    {
        void Create(T entity);
        IEnumerable<T> Read();
        T ReadAll(EntityId id);
        void Update(T entity);
        void Delete(T entity);
    }
}
