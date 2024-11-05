using System.ComponentModel.DataAnnotations;

namespace InfoTech.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        public Image? Image { get; set; }
        public int ImageId { get; set; }
    }
}
