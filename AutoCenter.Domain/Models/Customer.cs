using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AutoCenter.Domain.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(20), Required]
        public string FirstName { get; set; }

        [MaxLength(30), Required]
        public string LastName { get; set; }

        [MaxLength(30), Required]
        public string PersonalNumber { get; set; }

        [MaxLength(30)]
        public string DrivingLicenceNumber { get; set; }

        [MaxLength(10)]
        public string DrivingLicenceCategory { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(30)]
        public string ContactPhone { get; set; }

        [EmailAddress, MaxLength(80)]
        public string Email { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? RecordDate { get; set; }

        public bool? IsDeleted { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
