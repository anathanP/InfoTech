using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface ISocialMediaRepo : IRepository<SocialMedia>
    {
        void Update(SocialMedia socialMedia);
    }
}
