using InfoTech.Models;
using InfoTech.Utilities;

namespace InfoTech.DataAccess.ViewModels
{
    public class HeaderViewModel
    {
        public Image? Logo { get; set; }
        public List<Page>? Pages { get; set; }
        public Sd.Theme Theme { get; set; }
    }
}
