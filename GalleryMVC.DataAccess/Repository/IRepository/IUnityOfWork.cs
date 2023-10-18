namespace GalleryMVC.DataAccess.Repository.IRepository
{
    public interface IUnityOfWork
    {
        IGameRepository Game { get; }

        void Save();
    }
}