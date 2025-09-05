using GameLibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GameLibraryApi.Data
{
    public class GamingLibraryContext : DbContext
    {
        public GamingLibraryContext(DbContextOptions<GamingLibraryContext> options) : base(options)
        {

        }
    }
}

