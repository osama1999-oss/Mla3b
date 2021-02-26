using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Zoom.Platform.Infrastructure.IRepository
{
   public interface IRepository<T>
    {
        IList<T> Get();
        IList<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T Model);
        void Delete(T Model);
        T Edit(T Model);
        void Save();

    }
}
