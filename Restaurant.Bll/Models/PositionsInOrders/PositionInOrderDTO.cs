using Restaurant.Bll.Models.MenuPositionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.PositionsInOrders
{
    public class PositionInOrderDTO
    {
        //public Guid PositionId { get; set; }
        public MenuPositionDTO MenuPosition { get; set; } = null!;
        public int Quantity { get; set; }
        public string? Comment { get; set; }
    }
}