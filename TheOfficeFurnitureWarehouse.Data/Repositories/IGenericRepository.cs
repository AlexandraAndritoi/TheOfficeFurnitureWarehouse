using System;
using System.Linq;
using TheOfficeFurnitureWarehouse.Core;

namespace TheOfficeFurnitureWarehouse.Data.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        IQueryable<TEntity> GetAll();

        TEntity GetById(Guid id);

        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity);

        void Delete(Guid id);

        int Commit();
    }
}
