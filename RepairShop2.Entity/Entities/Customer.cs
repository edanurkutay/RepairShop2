using RepairShop2.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace RepairShop2.Entity.Entities
{
	public class Customer : EntityBase
	{
		[Key]
		public int CustomerId { get; set; }
		public string CustomerName { get; set; }
		public string CustomerSurname { get; set; }
		public string CustomerTC { get; set; }
		public string CustomerPhone {  get; set; }
		public string CustomerAddress { get; set; }
		
		public ICollection<Fault>? Faults { get; set; }

	}
}
