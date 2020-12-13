#nullable disable

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCenter.Domain.Models
{
    [Table("Technicians")]
    public class Technician : Employee
    {
        public int CategoryID { get; set; }

        [MaxLength(30)]
        public string DrivingLicenceNumber { get; set; }

        [MaxLength(10)]
        public string DrivingLicenceCategory { get; set; }

        public string Qualification { get; set; }

        public string Experience { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}
