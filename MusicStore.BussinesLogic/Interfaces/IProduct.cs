using MusicStore.Domain.Entities.Product;
using System.Collections.Generic;

namespace MusicStore.BusinessLogic.Interfaces
{
    public interface IProduct
    {
        List<ProductData> AddProduct(ProductData product);
        List<ProductData> DeleteProduct(int productId);
        List<ProductData> GetProductById(int productId);
        List<ProductData> UpdateProduct(ProductData product);
        List<ProductData> GetProducts();
        List<ProductData> GetProductsByArtist(int artistId);
        List<ProductData> GetProductsByGenre(string genre);
        List<ProductData> GetProductsByBPM(int bpm);
        List<ProductData> GetProductsByScale(string scale);
        
        
    }
}