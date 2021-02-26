using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Zoom.Platform.Infrastructure.AppContext;
using Zoom.Platform.Infrastructure.IRepository;

namespace Zoom.Platform.Infrastructure.BaseRepository
{
    class Repository<T> : IRepository<T> where T : class
    {
        ZoomPlatformDBContext _entities;

        #region Constructor
        public Repository(ZoomPlatformDBContext _entities)
        {
            this._entities = _entities;
        }
        #endregion

        public void Add(T Model)
        {
            _entities.Set<T>().Add(Model);
            Save();
        }

        public void Delete(T Model)
        {
            _entities.Remove(Model);
            Save();
        }

        public T Edit(T Model)
        {
            _entities.Set<T>().Update(Model);
            Save();
            return Model;
        }

        public IList<T> FindBy(Expression<Func<T, bool>> predicate)
        {
              return _entities.Set<T>().Where(predicate).ToList();
        }

        public IList<T> Get()
        {
             return _entities.Set<T>().ToList();
        }

        public void Save()
        {
            _entities.SaveChanges();
        }
    }
}
