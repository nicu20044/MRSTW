using MusicStore.BusinessLogic.Data;
using MusicStore.BusinessLogic.Data.Repositories;
using MusicStore.BusinessLogic.Interfaces;

namespace MusicStore.BusinessLogic
{
    public class BusinessLogic
    {
        public IProduct GetProductBl()
        {
            return new ProductBL(new ProductRepository(new AppDbContext()));
        }
    }
}