using System.ComponentModel.DataAnnotations;

namespace InfoTech.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Description { get; set; }
        [Required]
        public string? Content { get; set; }
        public Service? Service { get; set; }
        public int ServiceId { get; set; }
        public Image? Image { get; set; }
        public int ImageId { get; set; }
    }
}
