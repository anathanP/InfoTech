using System.ComponentModel.DataAnnotations;

namespace InfoTech.Models
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string? Media { get; set; }
        [Required]
        public string? Link { get; set; }
        [Required]
        public string? Icon { get; set; }

        public TeamMember? TeamMember { get; set; }
        public bool CompanyMedia { get; set; }
    }
}
