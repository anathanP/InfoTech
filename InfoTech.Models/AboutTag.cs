using System.ComponentModel.DataAnnotations;

namespace InfoTech.Models
{
    public class AboutTag
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Tag { get; set; }
    }
}
