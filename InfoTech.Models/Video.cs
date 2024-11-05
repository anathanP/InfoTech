using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace InfoTech.Models
{
    public class Video
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Title { get; set; }
        [Required]
        public string? Link { get; set; }

    }
}
