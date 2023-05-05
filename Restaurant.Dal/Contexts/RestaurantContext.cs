using Microsoft.EntityFrameworkCore;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Contexts
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<CommentToOrder> CommentsToOrder { get; set; } = null!;
        public DbSet<DeliveryOrder> DeliveryOrders { get; set; } = null!;
        public DbSet<Dish> Dishes { get; set; } = null!;
        public DbSet<Drink> Drinks { get; set; } = null!;
        public DbSet<InRestaurantOrder> InRestaurantOrders { get; set; } = null!;
        public DbSet<MenuPosition> MenuPositions { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<RegionOfWine> RegionsOfWine { get; set; } = null!;
        public DbSet<Table> Tables { get; set; } = null!;
        public DbSet<TakeAwayOrder> TakeAwayOrders { get; set; } = null!;
        public DbSet<Wine> Wines { get; set; } = null!;
        public DbSet<PositionInOrder> PositionsInOrders { get; set; } = null!;
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RestaurantContext).Assembly);
        }
    }

}
