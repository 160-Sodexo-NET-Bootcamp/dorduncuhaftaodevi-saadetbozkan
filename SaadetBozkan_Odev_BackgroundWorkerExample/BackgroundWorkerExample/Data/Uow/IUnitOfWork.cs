
using Data.DataModel;
using Data.Generic;

namespace Data.Uow
{
    public interface IUnitOfWork
    {
        GenericRepository<ModelExample> ModelExample { get; }
        int Complate();
    }
}
