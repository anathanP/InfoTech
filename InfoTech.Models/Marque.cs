using System.ComponentModel.DataAnnotations;

namespace InfoTech.Models
{
    public class Marque
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string? Name { get; set; }
        [MaxLength(100)]
        public string? Title { get; set; }
    }
}
