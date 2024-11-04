using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InfoTech.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Location { get; set; }
        [Required]
        [MaxLength(50)]
        public string? State { get; set; }
        [Required]
        [MaxLength(50)]
        public string? City { get; set; }
        [Required]
        [MaxLength(10)]
        public string? PostalCode { get; set; }
        [MaxLength(11)]
        [DefaultValue("0")]
        public string? Block { get; set; }
    }
}
