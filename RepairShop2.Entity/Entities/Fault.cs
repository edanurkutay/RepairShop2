using RepairShop2.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepairShop2.Entity.Entities
{
	public class Fault : EntityBase
	{
		[Key]
		public int FaultId { get; set; }
		public string FaultyDevice {  get; set; }
		public string FaultMessage { get; set; }
		public string FaultState { get; set; }
		public int Price { get; set; }

		[ForeignKey(nameof(Customer))]
		public int CustomerId { get; set; }

		public Customer Customer { get; set; }
		public Bill? Bill { get; set; }
	}
}
