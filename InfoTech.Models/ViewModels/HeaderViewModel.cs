using System.Security.Principal;

namespace InfoTech.Models.ViewModels
{
    public class HeaderViewModel
    {
        public Email? Email { get; set; }
        public Phone? Phone { get; set; }
        public List<Language>? Languages { get; set; }
        public List<SocialMedia>? SocialMedias { get; set; }
    }
}
