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
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().Property(b => b.Price).HasPrecision(14, 2);

            modelBuilder.Entity<Game>().HasData(
                new Game { Id = Guid.NewGuid(), Title = "Cyberpunk 2077", Developer = "CD PROJEKT RED", Publisher = "CD PROJEKT RED", Price = 59.99m },
                new Game { Id = Guid.NewGuid(), Title = "Starfield", Developer = "Bethesda Game Studios", Publisher = "Bethesda Softworks", Price = 69.99m },
                new Game { Id = Guid.NewGuid(), Title = "Dota 2", Developer = "Valve", Publisher = "Valve", Price = 0m },
                new Game { Id = Guid.NewGuid(), Title = "Baldur's Gate 3", Developer = "Larian Studios", Publisher = "Larian Studios", Price = 59.99m },
                new Game { Id = Guid.NewGuid(), Title = "Don't Starve", Developer = "Klei Entertainment", Publisher = "Klei Entertainment", Price = 9.99m },
                new Game { Id = Guid.NewGuid(), Title = "Factorio", Developer = "Wube Software LTD.", Publisher = "Wube Software LTD.", Price = 35.00m },
                new Game { Id = Guid.NewGuid(), Title = "Oxygen Not Included", Developer = "Klei Entertainment", Publisher = "Klei Entertainment", Price = 24.99m },
                new Game { Id = Guid.NewGuid(), Title = "The Witcher 3: Wild Hunt", Developer = "CD PROJEKT RED", Publisher = "CD PROJEKT RED", Price = 39.99m },
                new Game { Id = Guid.NewGuid(), Title = "The Elder Scrolls V: Skyrim", Developer = "Bethesda Game Studios", Publisher = "Bethesda Softworks", Price = 19.99m },
                new Game { Id = Guid.NewGuid(), Title = "Counter-Strike 2", Developer = "Valve", Publisher = "Valve", Price = 0m },
                new Game { Id = Guid.NewGuid(), Title = "Divinity: Original Sin 2", Developer = "Larian Studios", Publisher = "Larian Studios", Price = 44.99m },
                new Game { Id = Guid.NewGuid(), Title = "Stardew Valley", Developer = "ConcernedApe", Publisher = "ConcernedApe", Price = 14.99m },
                new Game { Id = Guid.NewGuid(), Title = "Sekiro: Shadows Die Twice", Developer = "FromSoftware", Publisher = "Activision", Price = 59.99m });

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = Guid.NewGuid(), Name = "RPG" },
                new Genre { Id = Guid.NewGuid(), Name = "Action" },
                new Genre { Id = Guid.NewGuid(), Name = "Strategy" },
                new Genre { Id = Guid.NewGuid(), Name = "Free to Play" },
                new Genre { Id = Guid.NewGuid(), Name = "Adventure" },
                new Genre { Id = Guid.NewGuid(), Name = "Indie" },
                new Genre { Id = Guid.NewGuid(), Name = "Simulation" },
                new Genre { Id = Guid.NewGuid(), Name = "Shooter" }
                );
        }
    }
}