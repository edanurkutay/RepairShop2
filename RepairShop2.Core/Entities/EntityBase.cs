namespace RepairShop2.Core.Entities
{
	public abstract class EntityBase : IEntityBase
	{
		public virtual string username { get; set; }
		public virtual string password { get; set; }

	}
}
