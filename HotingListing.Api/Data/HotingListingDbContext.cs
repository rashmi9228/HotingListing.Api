using Microsoft.EntityFrameworkCore;

namespace HotingListing.Api.Data
{
    public class HotingListingDbContext : DbContext
    {
        public HotingListingDbContext(DbContextOptions<HotingListingDbContext> options) :  base(options) 
        {
            
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }  
    }
}
