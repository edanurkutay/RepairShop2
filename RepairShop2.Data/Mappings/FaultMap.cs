using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RepairShop2.Entity.Entities;

namespace RepairShop2.Data.Mappings
{
	public class FaultMap : IEntityTypeConfiguration<Fault>
	{
		public void Configure(EntityTypeBuilder<Fault> builder)
		{
			builder.Property(x => x.Price).HasDefaultValue(0);
			builder.Property(x=>x.FaultState).HasDefaultValue("Oluşturuldu");
		}
	}
}
