using RepairShop2.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace RepairShop2.Entity.Entities
{
	public class Staff : EntityBase
	{
		[Key]
		public int StaffId { get; set; }
		public string StaffName { get; set; }
		public string StaffSurname { get; set; }
		public string username { get; set; }
		public string password { get; set; }



	}
}
