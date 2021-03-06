using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TheOfficeFurnitureWarehouse.Core;

namespace TheOfficeFurnitureWarehouse.Data.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly TheOfficeFurnitureWarehouseDbContext dbContext;

        public GenericRepository(TheOfficeFurnitureWarehouseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int Commit()
        {
            return dbContext.SaveChanges();
        }

        public TEntity Create(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
            return entity;
        }

        public void Delete(Guid id)
        {
            var entity = dbContext.Set<TEntity>().Find(id);
            dbContext.Set<TEntity>().Remove(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().AsNoTracking();
        }

        public TEntity GetById(Guid id)
        {
            return dbContext.Set<TEntity>().AsNoTracking().FirstOrDefault(_ => _.Id == id);
        }

        public TEntity Update(TEntity entity)
        {
            dbContext.Set<TEntity>().Update(entity);
            return entity;
        }
    }
}
