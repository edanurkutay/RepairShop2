using RepairShop2.Entity.Entities;
using RepairShop2.Service.Services.Abstractions;
using RepairShop2.Data.UnitOfWorks;


namespace RepairShop2.Service.Services.Concrete
{
	public class FaultService : IFaultService
	{
		private readonly IUnitOfWork unitOfWork;
		public FaultService(IUnitOfWork unitOfWork) 
		{
			this.unitOfWork = unitOfWork;
		}
		public async Task<List<Fault>> GetAllFaultsAsync()
		{
			return await unitOfWork.GetRepository<Fault>().GetAllAsync();
		}
	}
}
