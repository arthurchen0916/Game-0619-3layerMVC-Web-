using Game.Common;
using Game.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Game.Dal.Base
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        internal GameContext _dbContext
        {
            get;
            set;
        }

        public BaseRepository()
        {
            _dbContext = new GameContext();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().SingleOrDefault(x => x.Id == id);
        }

        public void Add(T item)
        {
            _dbContext.Set<T>().Add(item);
            _dbContext.SaveChanges();
        }

        public void Remove(T item)
        {
            _dbContext.Set<T>().Remove(item);
            _dbContext.SaveChanges();
        }

        public void Update(T item)
        {
            var entry = _dbContext.Entry<T>(item);

            if (entry.State == EntityState.Detached)
            {
                var set = _dbContext.Set<T>();

                T attachedEntity = set.Find(item.Id);

                if (attachedEntity != null)
                {
                    var attachedEntry = _dbContext.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(item);
                }
                else
                {
                    entry.State = EntityState.Modified;
                }
            }
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate.Compile()).AsQueryable();
        }

        public IEnumerable<T> FindAll()
        {
            return _dbContext.Set<T>().AsQueryable();
        }

        public IEnumerable<T> SqlQuery(string sql, params object[] parameters)
        {
            return _dbContext.Database.SqlQuery<T>(sql, parameters);
        }
    }
}