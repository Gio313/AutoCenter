using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AutoCenter.Domain.Models
{
    public class Order
    {
        public int ID { get; set; }

        public int CustomerID { get; set; }

        public int AdministrationEmployeeID { get; set; }

        [Column(TypeName = "datetime"), Required]
        public DateTime? OrderDate { get; set; }

        public int OrderStatusID { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        [ForeignKey("AdministrationEmployeeID")]
        public AdministrationEmployee AdministrationEmployee { get; set; }

        [ForeignKey("OrderStatusID")]
        public OrderStatus OrderStatus { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
