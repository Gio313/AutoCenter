using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCenter.Domain.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(20), Required]
        public string FirstName { get; set; }

        [MaxLength(30), Required]
        public string LastName { get; set; }

        [MaxLength(30), Required]
        public string PersonalNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(30)]
        public string ContactPhone { get; set; }

        [EmailAddress, MaxLength(80)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime HireDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
