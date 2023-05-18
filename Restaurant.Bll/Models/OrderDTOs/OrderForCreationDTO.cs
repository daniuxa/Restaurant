using Restaurant.Bll.Models.ClientDTOs;
using Restaurant.Bll.Models.PositionsInOrders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.OrderDTOs
{
    public class OrderForCreationDTO
    {
        public DateTime DateOfOrder { get; set; }
        public ClientForCreationDTO Client { get; set; } = null!;
        public IEnumerable<PositionsInOrdersForCreationDTO> PositionsInOrders { get; set; } = new List<PositionsInOrdersForCreationDTO>();
    }
}
