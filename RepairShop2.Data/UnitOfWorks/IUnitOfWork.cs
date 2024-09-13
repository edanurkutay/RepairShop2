using RepairShop2.Core.Entities;
using RepairShop2.Data.Repositories.Abstractions;
using RepairShop2.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop2.Data.UnitOfWorks
{
	public interface IUnitOfWork : IAsyncDisposable
	{
		IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();
		Task<int> SaveAsync();
		int Save();

	}
}
	