using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("PositionsInOrders")]
    public class PositionInOrder
    {
        [ForeignKey("OrderId")]
        public Order Order { get; set; } = null!;
        public int OrderId { get; set; }
        [ForeignKey("MenuPostionId")]
        public MenuPosition MenuPosition { get; set; } = null!;
        public Guid MenuPostionId { get; set; }
        public int Quantity { get; set; }
        public string? Comment { get; set; }
    }
}
