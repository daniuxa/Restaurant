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
    public class DishTypeConfiguration : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder.HasData(
                    new Dish { PositionId = new Guid("a680749e-8e43-4877-9fe4-cb7b3caf130d"), Name = "Humburger", TypeOfDish = "Burger", Price = 500, Weight = 400, PhotoLink = "https://ik.imagekit.io/Salivon/Menu/a680749e-8e43-4877-9fe4-cb7b3caf130d?updatedAt=1684828898277" },
                    new Dish { PositionId = new Guid("78506416-6bc4-469e-9b03-1e2cf5b708a3"), Name = "Steak", TypeOfDish = "Meat", Price = 600, Weight = 500, PhotoLink = "https://ik.imagekit.io/Salivon/Menu/78506416-6bc4-469e-9b03-1e2cf5b708a3?updatedAt=1684828867102" },
                    new Dish { PositionId = new Guid("349ac30a-ffa1-4c2f-a871-a172100d5dd7"), Name = "Kebab", TypeOfDish = "Meat", Price = 400, Weight = 350, PhotoLink = "https://ik.imagekit.io/Salivon/Menu/349ac30a-ffa1-4c2f-a871-a172100d5dd7?updatedAt=1684828595451" },
                    new Dish { PositionId = new Guid("d0d023f5-aea2-4b19-9b18-f949b02ea87d"), Name = "Nugets", TypeOfDish = "Meat", Price = 300, Weight = 250, PhotoLink = "https://ik.imagekit.io/Salivon/Menu/d0d023f5-aea2-4b19-9b18-f949b02ea87d?updatedAt=1684828605346" },
                    new Dish { PositionId = new Guid("c5d0bd03-f244-4429-b59c-181268153359"), Name = "Salmon", TypeOfDish = "Fish", Price = 600, Weight = 250, PhotoLink = "https://ik.imagekit.io/Salivon/Menu/c5d0bd03-f244-4429-b59c-181268153359?updatedAt=1684828638160" },
                    new Dish { PositionId = new Guid("7bdc8f1d-6677-4065-8425-218e4c8bac36"), Name = "Fried with tomato souce", TypeOfDish = "Fish", Price = 700, Weight = 250, PhotoLink = "https://ik.imagekit.io/Salivon/Menu/7bdc8f1d-6677-4065-8425-218e4c8bac36?updatedAt=1684828713325" },
                    new Dish { PositionId = new Guid("2a287245-da79-4f6f-9bca-29c4fd1c8b05"), Name = "Grilled fish", TypeOfDish = "Fish", Price = 500, Weight = 250, PhotoLink = "https://ik.imagekit.io/Salivon/Menu/2a287245-da79-4f6f-9bca-29c4fd1c8b05?updatedAt=1684828669643" },
                    new Dish { PositionId = new Guid("fa744911-5fc6-486a-9cd4-3a09c539a31e"), Name = "Easter fish", TypeOfDish = "Fish", Price = 650, Weight = 250, PhotoLink = "https://ik.imagekit.io/Salivon/Menu/fa744911-5fc6-486a-9cd4-3a09c539a31e?updatedAt=1684828749243" },
                    new Dish { PositionId = new Guid("177b95a1-8ead-4fb1-8510-9bec5c89c16a"), Name = "Dorado", TypeOfDish = "Fish", Price = 400, Weight = 250, PhotoLink = "https://ik.imagekit.io/Salivon/Menu/177b95a1-8ead-4fb1-8510-9bec5c89c16a?updatedAt=1684828620582" },
                    new Dish { PositionId = new Guid("a23bcec4-d07c-4e6a-a131-43a064066304"), Name = "Chef summer fish", TypeOfDish = "Fish", Price = 500, Weight = 250, PhotoLink = "https://ik.imagekit.io/Salivon/Menu/a23bcec4-d07c-4e6a-a131-43a064066304?updatedAt=1684828784696" }
                );
        }
    }
}
