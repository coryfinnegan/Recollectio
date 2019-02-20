using Microsoft.EntityFrameworkCore;

namespace Recollectio.Models
{
    public class AlbumContext : DbContext
    {
        public AlbumContext (DbContextOptions<AlbumContext> options) : base (options)
        {

        }

        public DbSet<Recollectio.Models.Album> Album { get; set; }
    }
}