using System.Collections.Generic;

namespace Data.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(long id);
        T GetById(long id);
        IEnumerable<T> GetAll();

    }
}
