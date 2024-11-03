using InfoTech.Models;

namespace InfoTech.DataAccess.ViewModels
{
    public class TopHeaderViewModel
    {
        public Email? Email { get; set; }
        public Phone? Phone { get; set; }
        public List<Language>? Languages { get; set; }
        public List<SocialMedia>? SocialMedias { get; set; }
    }
}
