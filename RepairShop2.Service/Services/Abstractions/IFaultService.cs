using RepairShop2.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop2.Service.Services.Abstractions
{
	public interface IFaultService
	{
		Task<List<Fault>> GetAllFaultsAsync();

	}
}
