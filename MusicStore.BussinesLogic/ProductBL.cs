using System.Collections.Generic;
using MusicStore.BusinessLogic.Core.UserArtist;
using MusicStore.BusinessLogic.Interfaces;
using MusicStore.Domain.Entities.Product;

namespace MusicStore.BusinessLogic
{
    public class ProductBL : ArtistApi, IProduct
    {
        public List<ProductData> AddProduct(ProductData product)
        {
            return base.AddProduct(product);
        }
        public List<ProductData> DeleteProduct(int productId)
        {
            return base.DeleteProduct(productId);
        }
        public List<ProductData> GetProductById(int productId)
        {
            return base.GetProductById(productId);
        }
        public List<ProductData> UpdateProduct(ProductData product)
        {
            return base.UpdateProduct(product);
        }
        public List<ProductData> GetProducts()
        {
            return base.GetProducts();
        }
        public List<ProductData> GetProductsByArtist(int artistId)
        {
            return base.GetProductsByArtist(artistId);
        }
        public List<ProductData> GetProductsByGenre(string genre)
        {
            return base.GetProductsByGenre(genre);
        }
        
        public List<ProductData> GetProductsByBPM(int bpm)
        {
            return base.GetProductsByBPM(bpm);
        }
        public List<ProductData> GetProductsByScale(string scale)
        {
            return base.GetProductsByScale(scale);
        }
        
    }
}