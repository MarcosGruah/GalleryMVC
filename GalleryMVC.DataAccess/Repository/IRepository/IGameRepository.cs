using GalleryMVC.Models;

namespace GalleryMVC.DataAccess.Repository.IRepository
{
    public interface IGameRepository : IRepository<Game>
    {
        void Update(Game obj);
    }
}