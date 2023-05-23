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
    public class DrinkTypeConfiguration : IEntityTypeConfiguration<Drink>
    {
        public void Configure(EntityTypeBuilder<Drink> builder)
        {
            builder.HasData(
                new Drink { 
                PositionId = new Guid("cdc8e3c4-42c5-47e9-932d-5d196c04351e"),
                    Name = "Espresso",
                    Price = 100,
                    TypeOfDrink = "Coffe",
                    Volume = 30,
                    PhotoLink = "https://ik.imagekit.io/Salivon/Menu/cdc8e3c4-42c5-47e9-932d-5d196c04351e?updatedAt=1684867378345" 
                },

                new Drink
                {
                    PositionId = new Guid("eb80cd9d-6586-4d76-ae91-a8e6bf5c8b5e"),
                    Name = "Cappuccino",
                    Price = 130,
                    TypeOfDrink = "Coffe",
                    Volume = 50,
                    PhotoLink = "https://ik.imagekit.io/Salivon/Menu/eb80cd9d-6586-4d76-ae91-a8e6bf5c8b5e"
                },

                new Drink
                {
                    PositionId = new Guid("cc26f172-64bd-4b14-aeca-2ffe1f7d4d63"),
                    Name = "Latte",
                    Price = 140,
                    TypeOfDrink = "Coffe",
                    Volume = 50,
                    PhotoLink = "https://ik.imagekit.io/Salivon/Menu/cc26f172-64bd-4b14-aeca-2ffe1f7d4d63"
                },

                new Drink
                {
                    PositionId = new Guid("47d6710b-32e5-429d-8723-e7971f6bef17"),
                    Name = "Orange juice",
                    Price = 130,
                    TypeOfDrink = "Juice",
                    Volume = 200,
                    PhotoLink = "https://ik.imagekit.io/Salivon/Menu/47d6710b-32e5-429d-8723-e7971f6bef17"
                },

                new Drink
                {
                    PositionId = new Guid("ab10d367-35f4-4da6-ab7f-01413eddd8d4"),
                    Name = "Apple juice",
                    Price = 130,
                    TypeOfDrink = "Juice",
                    Volume = 200,
                    PhotoLink = "https://ik.imagekit.io/Salivon/Menu/ab10d367-35f4-4da6-ab7f-01413eddd8d4"
                },

                new Drink
                {
                    PositionId = new Guid("b46d3334-e53f-4dfa-bea9-3a1aef72d5d1"),
                    Name = "Black tea",
                    Price = 100,
                    TypeOfDrink = "Tea",
                    Volume = 150,
                    PhotoLink = "https://ik.imagekit.io/Salivon/Menu/b46d3334-e53f-4dfa-bea9-3a1aef72d5d1"
                }
                );
        }
    }
}
