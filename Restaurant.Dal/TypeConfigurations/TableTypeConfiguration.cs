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
    public class TableTypeConfiguration : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {
            builder.HasCheckConstraint("CHK_PK_TableNumber", "TableNumber > 0");

            builder.HasData(
                    new Table { TableNumber = 1, AmountOfPlaces = 1 },
                    new Table { TableNumber = 2, AmountOfPlaces = 2 },
                    new Table { TableNumber = 3, AmountOfPlaces = 3 },
                    new Table { TableNumber = 4, AmountOfPlaces = 4 }
                );
        }
    }
}
