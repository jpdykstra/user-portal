using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JPD.Demo.Service.Entities
{
    [Table("Address", Schema = "dbo")]
    public class Address
    {
        [Key]
        public Guid AddressId { get; set; }

        [Required]
        [MaxLength(250)]
        public string AddressLine1 { get; set; }

        [MaxLength(250)]
        public string AddressLine2 { get; set; }

        [Required]
        [MaxLength(250)]
        public string City { get; set; }

        [Required]
        [MaxLength(2)]
        public string State { get; set; }

        [Required]
        [MaxLength(10)]
        public string ZipCode { get; set; }
    }
}
