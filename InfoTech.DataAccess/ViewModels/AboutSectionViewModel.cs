using InfoTech.Models;

namespace InfoTech.DataAccess.ViewModels
{
    public class AboutSectionViewModel
    {
        public List<AboutTag>? AboutTags { get; set; }
        public Section? Section { get; set; }
        public int ClientCount { get; set; }
        public Phone? Phone { get; set; }
        public Image? Image { get; set; }
        public Video? Video { get; set; }
    }
}
