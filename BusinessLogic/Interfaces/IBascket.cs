using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IBascket
    {
        List <ProductToBascketModel> AddToBascket(ProductToBascketModel product);
        List <ProductToBascketModel> RemoveFromBascket(ProductToBascketModel id);

    }
}
