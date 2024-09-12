using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RepairShop2.Entity.Entities;

namespace RepairShop2.Data.Mappings
{
	internal class BillMap : IEntityTypeConfiguration<Bill>
	{
		public void Configure(EntityTypeBuilder<Bill> builder)
		{
			builder.Property(x=>x.BillDate).HasDefaultValue(DateTime.Now);
		}

	}
}
 