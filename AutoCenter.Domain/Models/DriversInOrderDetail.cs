using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AutoCenter.Domain.Models
{
    [Table("DriversInOrderDetails")]
    public class DriversInOrderDetail: OrderDetail
    {
        public int DriverID { get; set; }

        [Column(TypeName = "money")]
        public decimal DriverRent { get; set; }

        [ForeignKey("DriverID")]
        public Driver Driver { get; set; }
    }
}
