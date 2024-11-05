using System.ComponentModel.DataAnnotations;

namespace InfoTech.Models
{
    public class HeroBanner
    {
        [Key]
        public int Id { get; set; }
        public Image? Image { get; set; }
        public int ImageId { get; set; }
        [MaxLength(30)]
        public string? Tag { get; set; }
        [MaxLength(60)]
        public string? Title { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        [MaxLength(30)]
        public string? FillButtonCaption { get; set; }
        [MaxLength(30)]
        public string? EmptyButtonCaption { get; set; }
    }
}
