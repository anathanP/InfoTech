using System.ComponentModel.DataAnnotations;
using InfoTech.Utilities;

namespace InfoTech.Models
{
    public class Email
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Address { get; set; }

        public Sd.Status Status { get; set; }
    }
}
