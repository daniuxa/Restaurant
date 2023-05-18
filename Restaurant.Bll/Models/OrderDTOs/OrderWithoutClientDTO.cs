using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.OrderDTOs
{
    public class OrderWithoutClientDTO
    {
        public DateTime DateOfOrder { get; set; }
        public decimal TotalPrice { get; set; }
        public int? ClientId { get; set; }
        public Client? Client { get; set; }
    }
}
