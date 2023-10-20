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
            Guid testId = Guid.NewGuid();

            modelBuilder.Entity<Game>().Property(b => b.Price).HasPrecision(14, 2);

            modelBuilder.Entity<Game>().HasData(
                new Game { Id = Guid.NewGuid(), Title = "Cyberpunk 2077", Developer = "CD PROJEKT RED", Publisher = "CD PROJEKT RED", GenreId = testId, Price = 59.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Starfield", Developer = "Bethesda Game Studios", Publisher = "Bethesda Softworks", GenreId = testId, Price = 69.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Dota 2", Developer = "Valve", Publisher = "Valve", Price = 0m, GenreId = testId, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Baldur's Gate 3", Developer = "Larian Studios", Publisher = "Larian Studios", GenreId = testId, Price = 59.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Don't Starve", Developer = "Klei Entertainment", Publisher = "Klei Entertainment", GenreId = testId, Price = 9.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Factorio", Developer = "Wube Software LTD.", Publisher = "Wube Software LTD.", GenreId = testId, Price = 35.00m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Oxygen Not Included", Developer = "Klei Entertainment", Publisher = "Klei Entertainment", GenreId = testId, Price = 24.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "The Witcher 3: Wild Hunt", Developer = "CD PROJEKT RED", Publisher = "CD PROJEKT RED", GenreId = testId, Price = 39.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "The Elder Scrolls V: Skyrim", Developer = "Bethesda Game Studios", Publisher = "Bethesda Softworks", GenreId = testId, Price = 19.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Counter-Strike 2", Developer = "Valve", Publisher = "Valve", Price = 0m, GenreId = testId, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Divinity: Original Sin 2", Developer = "Larian Studios", Publisher = "Larian Studios", GenreId = testId, Price = 44.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Stardew Valley", Developer = "ConcernedApe", Publisher = "ConcernedApe", GenreId = testId, Price = 14.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Sekiro: Shadows Die Twice", Developer = "FromSoftware", Publisher = "Activision", GenreId = testId, Price = 59.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow });

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = Guid.NewGuid(), Name = "RPG", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Action", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Strategy", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Free to Play", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Adventure", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Indie", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Simulation", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.NewGuid(), Name = "Shooter", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow }
                );
        }
    }
}