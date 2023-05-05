using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("CommentsToOrder")]
    public class CommentToOrder
    {
        [ForeignKey("OrderId")]
        public Order Order { get; set; } = null!;
        [Key]
        public int OrderId { get; set; }
        public string Comment { get; set; } = null!;
        public TypeOfOrder TypeOfOrder { get; set; }
    }
}
