using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCenter.Domain.Models
{
    [Table("AdministrationEmployees")]

    public class AdministrationEmployee : Employee
    {
        [Required,MaxLength(60)]
        public string Position { get; set; }

        public string Education { get; set; }

        public string Experience { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
