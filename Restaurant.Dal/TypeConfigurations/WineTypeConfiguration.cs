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
    public class WineTypeConfiguration : IEntityTypeConfiguration<Wine>
    {
        public void Configure(EntityTypeBuilder<Wine> builder)
        {
            builder.HasData(
                new Wine 
                { 
                    PositionId = new Guid("2c3279d1-2e2b-40cf-80ab-cc2e0167f809"), 
                    Brand = "Ventos", 
                    Country = "Portugal", 
                    IsBottle = true, 
                    Name = "Quinta Bons Ventos", 
                    Price = 300, 
                    RegionName = "Lisboa", 
                    TypeOfWine = "Red", 
                    Year = 2015, 
                    PhotoLink = "https://ik.imagekit.io/Salivon/Menu/2c3279d1-2e2b-40cf-80ab-cc2e0167f809?updatedAt=1684863128831" 
                },
               
                new Wine 
                { 
                    PositionId = new Guid("f2b2b4a2-6930-4d60-bb14-ec740ea92164"), 
                    Brand = "Syrah", 
                    Country = "Portugal", 
                    IsBottle = true, 
                    Name = "Vidigueira Syrah", 
                    Price = 550, 
                    RegionName = "Alentejo", 
                    TypeOfWine = "Red", 
                    Year = 2012, 
                    PhotoLink = "https://ik.imagekit.io/Salivon/Menu/f2b2b4a2-6930-4d60-bb14-ec740ea92164?updatedAt=1684863172948" 
                },

                new Wine
                {
                    PositionId = new Guid("b6a6574f-d702-49c3-829d-c00ac75ede7d"),
                    Brand = "Doce",
                    Country = "Portugal",
                    IsBottle = true,
                    Name = "Quinta Camarate Doce",
                    Price = 750,
                    RegionName = "Setúbal",
                    TypeOfWine = "White",
                    Year = 2019,
                    PhotoLink = "https://ik.imagekit.io/Salivon/Menu/b6a6574f-d702-49c3-829d-c00ac75ede7d?updatedAt=1684863224821"
                },

                new Wine
                {
                    PositionId = new Guid("378aae16-d4f0-4f78-8232-ac7dd40d0687"),
                    Brand = "Alentejo Herdade",
                    Country = "Portugal",
                    IsBottle = true,
                    Name = "Alentejo Herdade Sobroso Cellar Selection",
                    Price = 1200,
                    RegionName = "Alentejo",
                    TypeOfWine = "White",
                    Year = 2016,
                    PhotoLink = "https://ik.imagekit.io/Salivon/Menu/378aae16-d4f0-4f78-8232-ac7dd40d0687?updatedAt=1684863364089"
                },

                new Wine
                {
                    PositionId = new Guid("ace050bf-ecf4-4444-9509-310f996676d3"),
                    Brand = "Bassotets",
                    Country = "Spain",
                    IsBottle = true,
                    Name = "Els Bassotets",
                    Price = 1100,
                    RegionName = "Conca de Barberà",
                    TypeOfWine = "White",
                    Year = 2022,
                    PhotoLink = "https://ik.imagekit.io/Salivon/Menu/ace050bf-ecf4-4444-9509-310f996676d3?updatedAt=1684863752948"
                },

                new Wine
                {
                    PositionId = new Guid("17a90d7e-9726-4d7f-bf96-7ca47080c27c"),
                    Brand = "Observador",
                    Country = "Spain",
                    IsBottle = true,
                    Name = "Davide Observador",
                    Price = 2500,
                    RegionName = "Rías Baixas",
                    TypeOfWine = "White",
                    Year = 2022,
                    PhotoLink = "https://ik.imagekit.io/Salivon/Menu/17a90d7e-9726-4d7f-bf96-7ca47080c27c?updatedAt=1684863814548"
                },

                new Wine
                {
                    PositionId = new Guid("ccec7ad3-2928-4ca9-963e-1d9b705ff1be"),
                    Brand = "Mirum",
                    Country = "Spain",
                    IsBottle = true,
                    Name = "Valdaya Mirum",
                    Price = 3200,
                    RegionName = "Ribera del Duero",
                    TypeOfWine = "White",
                    Year = 2019,
                    PhotoLink = "https://ik.imagekit.io/Salivon/Menu/ccec7ad3-2928-4ca9-963e-1d9b705ff1be?updatedAt=1684863955912"
                }
                );
        }
    }
}
