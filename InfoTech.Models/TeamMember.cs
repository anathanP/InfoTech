using System.ComponentModel.DataAnnotations;

namespace InfoTech.Models
{
    public class TeamMember
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Family { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Content { get; set; }

        public Image? Image { get; set; }
        public int ImageId { get; set; }
        public List<SocialMedia>? SocialMedias { get; set; }
    }
}
