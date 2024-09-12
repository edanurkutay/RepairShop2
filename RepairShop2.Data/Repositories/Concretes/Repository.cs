using Microsoft.EntityFrameworkCore;
using RepairShop2.Core.Entities;
using RepairShop2.Data.Context;
using RepairShop2.Data.Repositories.Abstractions;
using System.Linq.Expressions;

namespace RepairShop2.Data.Repositories.Concretes
{
	public class Repository<T> : IRepository<T> where T : class, IEntityBase, new()
	{
		private readonly AppDbContex db;
		public Repository(AppDbContex db) 
		{
			this.db = db;
		}
		private DbSet<T> Table { get => db.Set<T>(); }

		public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
		{
			IQueryable<T> query = Table;
			if(predicate != null)
				query = query.Where(predicate);

			if(includeProperties.Any())
				foreach(var item in includeProperties)
					query=query.Include(item);

			return await query.ToListAsync();
				
		}	

		public async Task AddAsync(T entity)
		{
			await Table.AddAsync(entity);
		}

		public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
		{
			IQueryable<T> query = Table;
			query = query.Where(predicate);

			if (includeProperties.Any())
				foreach (var item in includeProperties)
					query = query.Include(item);

			return await query.SingleAsync();
		}

		public async Task<T> GetByGuidAsync(Guid id)
		{
			return await Table.FindAsync(id);
		}

		public async Task<T> UpdateAsync(T entity)
		{
			await Task.Run(() => Table.Update(entity));
			return entity;
		}

		public async Task DleteAsync(T entity)
		{
			await Task.Run(() => Table.Remove(entity));
		}

		public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
		{
			return await Table.AnyAsync(predicate);
		}

		public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
		{
			return await Table.CountAsync(predicate);
		}
	}
}
