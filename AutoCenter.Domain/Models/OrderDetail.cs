using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AutoCenter.Domain.Models
{
    public class OrderDetail
    {
        [Key]
        public int ID { get; set; }

        public int OrderID { get; set; }

        public int AutomobileID { get; set; }

        [Column(TypeName = "money")]
        public decimal RentFee { get; set; }

        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        [ForeignKey("AutomibileID")]
        public Automobile Automobile { get; set; }
    }
}
