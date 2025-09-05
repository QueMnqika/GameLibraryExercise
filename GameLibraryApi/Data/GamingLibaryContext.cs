using GameLibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GameLibraryApi.Data
{
    public class GamingLibraryContext : DbContext
    {
        public DbSet<GameInformation> GameInformations { get; set; }
        public GamingLibraryContext(DbContextOptions<GamingLibraryContext> options) : base(options)
        {

        }
    }
}

