using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}
