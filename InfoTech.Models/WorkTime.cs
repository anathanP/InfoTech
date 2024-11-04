using System.ComponentModel.DataAnnotations;
using InfoTech.Utilities;

namespace InfoTech.Models
{
    public class WorkTime
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Sd.DayOfWeek StartDay { get; set; }

        public Sd.DayOfWeek? EndDay { get; set; }
        [Required]
        public TimeOnly StartTime { get; set; }
        [Required]
        public TimeOnly EndTime { get; set; }
    }
}
