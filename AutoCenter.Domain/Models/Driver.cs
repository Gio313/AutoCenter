using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Domain.Models
{
    [Table("Drivers")]
    public class Driver : Employee
    {
        [Required,MaxLength(30)]
        public string DrivingLicenceNumber { get; set; }

        [Required, MaxLength(10)]
        public string DrivingLicenceCategory { get; set; }

        public ICollection<DriversInOrderDetail> DriversInOrderDetails { get; set; }  
    }
}
