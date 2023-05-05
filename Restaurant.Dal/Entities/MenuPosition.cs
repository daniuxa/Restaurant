using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("MenuPositions")]
    public abstract class MenuPosition
    {
        [Key]
        public Guid PositionId { get; set; }
        public decimal Price { get; set; }
        public string NameOfDish { get; set; } = null!;
        public IEnumerable<Order> Orders { get; set; } = new List<Order>();
        public IEnumerable<PositionInOrder> PositionsInOrders { get; set; } = new List<PositionInOrder>();

    }
}

