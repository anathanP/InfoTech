using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace InfoTech.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        public Image? Image { get; set; }
        public int ImageId { get; set; }
        [Required]
        public string? Content { get; set; }

    }
}
