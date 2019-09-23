using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JPD.Demo.Service.Entities
{
    [Table("Interest", Schema = "dbo")]
    public class Interest
    {
        [Key]
        public Guid InterestId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
    }
}
