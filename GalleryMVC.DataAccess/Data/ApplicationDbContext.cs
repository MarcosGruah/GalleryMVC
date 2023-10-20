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
                new Game { Id = Guid.NewGuid(), Title = "Cyberpunk 2077", Developer = "CD PROJEKT RED", Publisher = "CD PROJEKT RED", GenreId = Guid.Parse("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), Price = 59.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Starfield", Developer = "Bethesda Game Studios", Publisher = "Bethesda Softworks", GenreId = Guid.Parse("7c3148a0-15f4-4e97-9d2f-1c035ab1e97a"), Price = 69.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Dota 2", Developer = "Valve", Publisher = "Valve", GenreId = Guid.Parse("4bb407a1-128f-40e2-8363-5ff17312c87d"), Price = 0m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Baldur's Gate 3", Developer = "Larian Studios", Publisher = "Larian Studios", GenreId = Guid.Parse("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), Price = 59.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Don't Starve", Developer = "Klei Entertainment", Publisher = "Klei Entertainment", GenreId = Guid.Parse("fae50298-4855-41de-a3ab-79eb15904f5d"), Price = 9.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Factorio", Developer = "Wube Software LTD.", Publisher = "Wube Software LTD.", GenreId = Guid.Parse("dd7d7e7f-ccd4-4a7f-86a1-2722e0e0a340"), Price = 35.00m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Oxygen Not Included", Developer = "Klei Entertainment", Publisher = "Klei Entertainment", GenreId = Guid.Parse("fae50298-4855-41de-a3ab-79eb15904f5d"), Price = 24.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "The Witcher 3: Wild Hunt", Developer = "CD PROJEKT RED", Publisher = "CD PROJEKT RED", GenreId = Guid.Parse("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), Price = 39.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "The Elder Scrolls V: Skyrim", Developer = "Bethesda Game Studios", Publisher = "Bethesda Softworks", GenreId = Guid.Parse("7c3148a0-15f4-4e97-9d2f-1c035ab1e97a"), Price = 19.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Counter-Strike 2", Developer = "Valve", Publisher = "Valve", GenreId = Guid.Parse("33a3db15-80a6-4e8a-b6cc-2500fc6bfa75"), Price = 0m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Divinity: Original Sin 2", Developer = "Larian Studios", Publisher = "Larian Studios", GenreId = Guid.Parse("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), Price = 44.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Stardew Valley", Developer = "ConcernedApe", Publisher = "ConcernedApe", GenreId = Guid.Parse("fae50298-4855-41de-a3ab-79eb15904f5d"), Price = 14.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Game { Id = Guid.NewGuid(), Title = "Sekiro: Shadows Die Twice", Developer = "FromSoftware", Publisher = "Activision", GenreId = Guid.Parse("0eb1e1f2-b5de-4d69-8237-4d28ab4c90ff"), Price = 59.99m, CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow }
            );

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = Guid.Parse("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), Name = "RPG", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.Parse("5719e94d-9c86-48b1-85c6-5cdd84e2e1db"), Name = "Action", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.Parse("7c3148a0-15f4-4e97-9d2f-1c035ab1e97a"), Name = "Strategy", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.Parse("4bb407a1-128f-40e2-8363-5ff17312c87d"), Name = "Free to Play", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.Parse("0eb1e1f2-b5de-4d69-8237-4d28ab4c90ff"), Name = "Adventure", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.Parse("fae50298-4855-41de-a3ab-79eb15904f5d"), Name = "Indie", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.Parse("dd7d7e7f-ccd4-4a7f-86a1-2722e0e0a340"), Name = "Simulation", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow },
                new Genre { Id = Guid.Parse("33a3db15-80a6-4e8a-b6cc-2500fc6bfa75"), Name = "Shooter", CreatedDate = DateTime.UtcNow, LastEditedDate = DateTime.UtcNow }
            );
        }
    }
}