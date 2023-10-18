using GalleryMVC.DataAccess.Data;
using GalleryMVC.DataAccess.Repository.IRepository;

namespace GalleryMVC.DataAccess.Repository
{
    public class UnityOfWork : IUnityOfWork
    {
        private ApplicationDbContext _db;
        public IGameRepository Game { get; private set; }

        public UnityOfWork(ApplicationDbContext db)
        {
            _db = db;
            Game = new GameRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}