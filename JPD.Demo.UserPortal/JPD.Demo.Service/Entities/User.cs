using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JPD.Demo.Service.Entities
{
    [Table("User", Schema ="dbo")]
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(75)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(75)]
        public string LastName { get; set; }

        public short Age { get; set; }

        [ForeignKey("MailingAddressId")]
        public Address MailingAddress { get; set; }


        [ForeignKey("BillingAddressId")]
        public Address BillingAddress { get; set; }

        public ICollection<Interest> Interests { get; set; } = new List<Interest>();
    }
}
