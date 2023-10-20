namespace GalleryMVC.DataAccess.Repository.IRepository
{
    public interface IUnityOfWork
    {
        IGameRepository Game { get; }
        IGenreRepository Genre { get; }

        void Save();
    }
}