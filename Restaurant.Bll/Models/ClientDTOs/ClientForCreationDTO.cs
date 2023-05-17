using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.ClientDTOs
{
    public class ClientForCreationDTO
    {
        public string PhoneNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
