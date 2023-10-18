using GalleryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryMVC.DataAccess.Repository.IRepository
{
    public interface IGameRepository : IRepository<Game>
    {
        void Update(Game obj);

        void Save();
    }
}