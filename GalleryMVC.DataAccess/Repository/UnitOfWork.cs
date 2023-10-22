using GalleryMVC.DataAccess.Data;
using GalleryMVC.DataAccess.Repository.IRepository;

namespace GalleryMVC.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IGameRepository Game { get; private set; }
        public IGenreRepository Genre { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Game = new GameRepository(_db);
            Genre = new GenreRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}