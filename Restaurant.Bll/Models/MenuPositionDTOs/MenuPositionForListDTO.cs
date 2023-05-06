using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.MenuPositionDTOs
{
    public class MenuPositionForListDTO
    {
        public Guid PositionId { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; } = null!;
        public string? PhotoLink { get; set; }
    }
}
