using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.PositionsInOrders
{
    public class PositionsInOrdersForCreationDTO
    {
        public Guid MenuPostionId { get; set; }
        public int Quantity { get; set; }
        public string? Comment { get; set; }
    }
}
