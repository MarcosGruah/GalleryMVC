namespace GalleryMVC.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IGameRepository Game { get; }
        IGenreRepository Genre { get; }

        void Save();
    }
}