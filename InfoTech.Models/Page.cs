using System.ComponentModel.DataAnnotations;

namespace InfoTech.Models
{
    public class Page
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Description { get; set; }
        [Required]
        [MaxLength(20)]
        public string? Action { get; set; }
        [MaxLength(100)]
        public string? Keywords { get; set; }
        [MaxLength(30)]
        public string? Author { get; set; }

        public List<SubPage>? SubPages { get; set; }

    }
}
