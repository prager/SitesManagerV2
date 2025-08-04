using Microsoft.EntityFrameworkCore;
using SiteManagerV2.Data;
using SiteManagerV2.Entity;

namespace SiteManagerV2.Services
{
    public class SiteService : ISiteService
    {
        private readonly DataContext _context;

        public SiteService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Site>> GetAllSites()
        {
            await Task.Delay(1000); //simulate delay
            var sites = await _context.Sites.ToListAsync();
            return sites;
        }
    }
}
