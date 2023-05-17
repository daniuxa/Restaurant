using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.ClientDTOs
{
    public class ClientDTO
    {
        public int ClientId { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
