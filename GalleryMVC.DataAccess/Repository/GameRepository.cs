using GalleryMVC.DataAccess.Data;
using GalleryMVC.DataAccess.Repository.IRepository;
using GalleryMVC.Models;

namespace GalleryMVC.DataAccess.Repository
{
    public class GameRepository : Repository<Game>, IGameRepository
    {
        private ApplicationDbContext _db;

        public GameRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public override void Add(Game game)
        {
            game.Id = Guid.NewGuid();
            game.CreatedDate = DateTime.UtcNow;
            game.LastEditedDate = DateTime.UtcNow;
            base.Add(game);
        }

        public void Update(Game obj)
        {
            var game = _db.Games.FirstOrDefault(x => x.Id == obj.Id);
            if (game != null)
            {
                game.Title = obj.Title;
                game.Developer = obj.Developer;
                game.Publisher = obj.Publisher;
                game.Price = obj.Price;
                game.GenreId = obj.GenreId;
                game.LastEditedDate = DateTime.UtcNow;
                _db.Games.Update(game);
            }
        }
    }
}