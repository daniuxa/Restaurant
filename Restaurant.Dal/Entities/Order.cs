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
        public DateTime OpenDateTime { get; set; }
        public DateTime CloseDateTime { get; set; }
        public decimal TotalPrice { get; set; }

        public string PhoneNumberOfClient { get; set; } = null!;
        [ForeignKey("PhoneNumberOfClient")]
        [Required]
        public Client Client { get; set; } = null!;
        public IEnumerable<MenuPosition> MenuPositions { get; set; } = new List<MenuPosition>();
        public IEnumerable<PositionInOrder> PositionsInOrders { get; set; } = new List<PositionInOrder>();

    }
}
