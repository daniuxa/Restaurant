using Restaurant.Bll.Models.TableDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.OrderDTOs.InRestaurantOrderDTOs
{
    public class InResataurantOrderForCreationDTO : OrderForCreationDTO
    {
        public int TableNumber { get; set; }
    }
}
