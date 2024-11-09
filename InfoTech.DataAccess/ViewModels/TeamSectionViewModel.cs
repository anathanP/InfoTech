using InfoTech.Models;

namespace InfoTech.DataAccess.ViewModels
{
    public class TeamSectionViewModel
    {
        public List<TeamMember>? TeamMembers { get; set; }
        public Section? Section { get; set; }
    }
}
