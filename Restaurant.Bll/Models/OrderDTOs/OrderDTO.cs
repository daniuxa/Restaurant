﻿using Restaurant.Bll.Models.ClientDTOs;
using Restaurant.Bll.Models.PositionsInOrders;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.OrderDTOs
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public DateTime DateOfOrder { get; set; }
        public decimal TotalPrice { get; set; }
        public ClientDTO Client { get; set; } = null!;
        public IEnumerable<PositionInOrderDTO> PositionsInOrders { get; set; } = new List<PositionInOrderDTO>();
    }
}
