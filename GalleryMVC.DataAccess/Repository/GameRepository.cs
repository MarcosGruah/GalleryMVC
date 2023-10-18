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

        public void Update(Game obj)
        {
            _db.Games.Update(obj);
        }
    }
}