using MusicStore.BusinessLogic.Interfaces;

namespace MusicStore.BusinessLogic
{
    public class BussinesLogic
    {
        public IProduct GetProductBL()
        {
            return new ProductBL();
        }
    }
}