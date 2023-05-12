using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.TableDTOs
{
    public class TableForCreationDTO
    {
        public int TableNumber { get; set; }
        public int AmountOfPlaces { get; set; }
    }
}
