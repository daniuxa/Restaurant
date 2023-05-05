using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.TypeConfigurations
{
    public class OrderTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .HasMany(x => x.MenuPositions)
                .WithMany(y => y.Orders)
                .UsingEntity<PositionInOrder>(
                    z => z.HasOne(m => m.MenuPosition).WithMany(p => p.PositionsInOrders).HasForeignKey(m => m.MenuPostionId),
                    z => z.HasOne(o => o.Order).WithMany(p => p.PositionsInOrders).HasForeignKey(o => o.OrderId),
                    z =>
                    { 
                        z.HasKey(p => new { p.OrderId, p.MenuPostionId });
                    }
                );
        }
    }
}
