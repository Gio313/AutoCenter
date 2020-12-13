using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AutoCenter.Domain.Models
{
    public class Automobile
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50), Required]
        public string Mark { get; set; }

        [MaxLength(50), Required]
        public string Model { get; set; }

        public int CategoryID { get; set; }

        [MaxLength(50), Required]
        public string Colour { get; set; }

        [MaxLength(20), Required]
        public string StateNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal RentFee { get; set; }

        public DateTime RecordDate { get; set; }

        public bool IsDeleted { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
