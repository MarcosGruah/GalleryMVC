using GalleryMVC.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace GalleryMVC.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}