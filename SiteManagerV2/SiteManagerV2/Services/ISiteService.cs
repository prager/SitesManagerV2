using SiteManagerV2.Entity;

namespace SiteManagerV2.Services
{
    public interface ISiteService
    {
        Task<List<Site>> GetAllSites();
    }
}
