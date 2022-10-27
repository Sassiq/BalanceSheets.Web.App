using BalanceSheetsApp.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheets.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BalanceSheetsDbContext context;

        public Repository(BalanceSheetsDbContext context)
        {
            this.context = context;
        }

        public async Task Add(T item)
        {
            await context.Set<T>().AddAsync(item);
            await context.SaveChangesAsync();
        }

        public async Task Delete(T item)
        {
            context.Entry(item).State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }

        public async Task<T> Get(int id)
        {
            T entity = await context.Set<T>().FindAsync(id);
            if (entity is not null)
            {
                context.Entry(entity).State = EntityState.Detached;
            }

            return entity;
        }

        public async Task<ICollection<T>> GetAll()
        {
            return await context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task Update(T item)
        {
            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task<T> Get(ISpecification<T> specification)
        {
            return await ApplySpecification(context.Set<T>(), specification).FirstOrDefaultAsync();
        }

        public async Task<ICollection<T>> GetAll(ISpecification<T> specification)
        {
            return await ApplySpecification(context.Set<T>(), specification).ToListAsync();
        }

        private IQueryable<T> ApplySpecification(IQueryable<T> query, ISpecification<T> specification)
        {
            IQueryable<T> result = specification.Apply(query);
            if (specification.Includes != null)
            {
                foreach (var item in specification.Includes)
                {
                    result = result.Include(item);
                }
            }

            return result.AsNoTracking();
        }
    }
}
