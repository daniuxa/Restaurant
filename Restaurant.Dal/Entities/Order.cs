using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("Orders")]
    public abstract class Order
    {
        public int OrderId { get; set; }
        public DateTime DateOfOrder { get; set; }
        public decimal TotalPrice { get; set; }

        public int ClientId{ get; set; }
        [ForeignKey("ClientId")]
        [Required]
        public Client Client { get; set; } = null!;
        public IEnumerable<MenuPosition> MenuPositions { get; set; } = new List<MenuPosition>();
        public IEnumerable<PositionInOrder> PositionsInOrders { get; set; } = new List<PositionInOrder>();

    }
}
