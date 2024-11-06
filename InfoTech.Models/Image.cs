using System.ComponentModel.DataAnnotations;

namespace InfoTech.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Address { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Alt { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Title { get; set; }

        public Language? Language { get; set; }
        public Brand? Brand { get; set; }
        public HeroBanner? HeroBanner { get; set; }
        public Service? Service { get; set; }

    }
}
