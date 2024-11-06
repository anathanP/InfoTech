using InfoTech.Models;

namespace InfoTech.DataAccess.ViewModels
{
    public class WorkProcessViewModel
    {
        public List<WorkProcess>? WorkProcesses { get; set; }
        public Section? Section { get; set; }
        public Image? Image { get; set; }
    }
}
