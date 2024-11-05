using System.ComponentModel.DataAnnotations;
using InfoTech.Utilities;

namespace InfoTech.Models
{
    public class Section
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Sd.IndexSections IndexSections { get; set; }
        [MaxLength(30)]
        public string? Tag { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        [MaxLength(100)]
        public string? Title { get; set; }
        [MaxLength(30)]
        public string? FillButtonCaption { get; set; }
        [MaxLength(30)]
        public string? EmptyButtonCaption { get; set; }
        [MaxLength(100)]
        public string? FillButtonAction { get; set; }
        [MaxLength(100)]
        public string? EmptyButtonAction { get; set; }
    }
}
