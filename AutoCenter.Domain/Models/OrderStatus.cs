#nullable disable

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoCenter.Domain.Models
{
    public class OrderStatus
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(30), Required]
        public string StatusName { get; set; }

        public bool? IsDeleted { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
