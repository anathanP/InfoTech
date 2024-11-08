using InfoTech.Models;

namespace InfoTech.DataAccess.ViewModels
{
    public class ProjectSectionViewModel
    {
        public List<Project>? Projects { get; set; }
        public Section? Section { get; set; }
        public Video? Video { get; set; }
    }
}
