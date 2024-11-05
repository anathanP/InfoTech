using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IHeroBannerRepo : IRepository<HeroBanner>
    {
        void Update(HeroBanner entity);
    }
}
