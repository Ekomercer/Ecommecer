using E_Commerce.Data._1.Context;
using E_Commerce.Data._2.Repsitory.Interface.BaseInterface;
using E_Commerce.Domain._1.Entites.Base;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data._2.Repsitory
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        #region Dapper

        public const string GetById = @"select*from @entity where id = @Id";
        public const string GetItAll = @"select*from @entity where IsDeleted = 0";

        public const string UpdateIt = @"update @entity set name = @Name where id = @Id";
        public const string Remove = @"update @entity set IsDeleted = 1 where ide = @Id";

        #endregion


        public readonly AppDbContext _context;
        public readonly DbSet<T> _dbSet;
        public BaseRepository(AppDbContext context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }
        #region Get
        public Task<T> GetBy(int id)
        {
            throw new NotImplementedException();
        }
        public Task<T> GetAll()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region crete,update,delete
        public Task<bool> Create(T entity)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
