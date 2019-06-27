using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Game.Common.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindAll();
        
    }
}