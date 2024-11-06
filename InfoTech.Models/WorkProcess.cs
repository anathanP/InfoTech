using System.ComponentModel.DataAnnotations;

namespace InfoTech.Models
{
    public class WorkProcess
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Step { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Description { get; set; }
        [Required]
        public byte DisplayOrder { get; set; }

        public Image? Image { get; set; }
        public int ImageId { get; set; }
    }
}
