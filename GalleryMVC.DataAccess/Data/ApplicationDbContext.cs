using GalleryMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace GalleryMVC.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Terminal commands to remember
        // add-migration textHere
        // update-database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game { GameId = Guid.NewGuid(), Name = "World of Warcraft" },
                new Game { GameId = Guid.NewGuid(), Name = "Eve Online" },
                new Game { GameId = Guid.NewGuid(), Name = "Dota 2" },
                new Game { GameId = Guid.NewGuid(), Name = "Baldur's Gate 3" },
                new Game { GameId = Guid.NewGuid(), Name = "Factorio" },
                new Game { GameId = Guid.NewGuid(), Name = "Counter-Strike 2" });
        }
    }
}