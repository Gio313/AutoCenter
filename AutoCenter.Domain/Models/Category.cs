#nullable disable

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoCenter.Domain.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Required,MaxLength(50)]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public  ICollection<Technician> Technicians { get; set; }

        public  ICollection<Automobile> Automobiles { get; set; }
    }
}
