using Restaurant.Bll.Models.ClientDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.OrderDTOs
{
    public class OrderForCreation
    {
        public int OrderId { get; set; }
        public DateTime DateOfOrder { get; set; }
        public ClientForCreationDTO Client { get; set; } = null!;
    }
}
