using RepairShop2.Data.Context;
using RepairShop2.Data.Repositories.Abstractions;
using RepairShop2.Data.Repositories.Concretes;

namespace RepairShop2.Data.UnitOfWorks
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AppDbContex dbContext;
		public UnitOfWork(AppDbContex dbContext) 
		{
			this.dbContext = dbContext;
		}
		public async ValueTask DisposeAsync()
		{
			await dbContext.DisposeAsync();
		}

		public int Save()
		{
			return dbContext.SaveChanges();
		}

		public async Task<int> SaveAsync()
		{
			return await dbContext.SaveChangesAsync();
		}

		IRepository<T> IUnitOfWork.GetRepository<T>()
		{
			return new Repository<T>(dbContext);
		}
	}
}
