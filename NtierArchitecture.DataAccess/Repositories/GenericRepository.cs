using Microsoft.EntityFrameworkCore;
using NtierArchitecture.DataAccess.Context;
using NtierArchitecture.DataAccess.IRepositories;
using NtierArchitecture.Entities.Abstractions;
using System.Linq.Expressions;

namespace NtierArchitecture.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity

    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(ApplicationDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            _dbSet.Remove(GetByID(Id));
            _dbContext.SaveChanges();
        }


        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetByID(Guid Id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == Id) ?? throw new Exception("Bulunamadı");
        }

        public bool IfEntityExists(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Any(filter);
        }

        public void Update(T entity)
        {
            _dbContext.SaveChanges();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate);
        }
    }
}
