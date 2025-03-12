using System.Collections.Generic;
using System.Linq;
using MusicStore.Domain.Entities.Product;

namespace MusicStore.BusinessLogic.Core.UserArtist
{
    public class ArtistApi
    {
        private List<ProductData> _products = new List<ProductData>();
        
        
        //-----------------------Arist beat actions--------------------
        internal List<ProductData> AddProduct(ProductData product)
        {
            if (product != null)
            {
                _products.Add(product);
            }

            return _products;
        }

        internal List<ProductData> DeleteProduct(int productId)
        {
            ProductData productToRemove = _products.FirstOrDefault(p => p.Id == productId);
            if (productToRemove!= null)
            {
                _products.Remove(productToRemove);
            }
            return _products;
        }

        internal List<ProductData> GetProductById(int productId)
        {
            return new List<ProductData> { _products.FirstOrDefault(p => p.Id == productId) };
        }

        internal List<ProductData> UpdateProduct(ProductData product)
        {
            if (product != null)
            {
                ProductData productToUpdate = _products.FirstOrDefault(p => p.Id == product.Id);
                if (productToUpdate!= null)
                {
                    productToUpdate.Name = product.Name;
                    productToUpdate.Price = product.Price;
                    productToUpdate.ArtistId = product.ArtistId;
                    productToUpdate.Genre = product.Genre;
                    productToUpdate.ProducerId = product.ProducerId;
                    productToUpdate.BPM = product.BPM;
                }
            }
            return _products;
        }

        internal List<ProductData> GetProducts()
        {
            
            return new List<ProductData>();
        }

        internal List<ProductData> GetProductsByArtist(int artistId)
        {
            return _products;
        }

        internal List<ProductData> GetProductsByGenre(string genre)
        {
           
            return _products.Where(p => p.Genre == genre).ToList();
        }

        internal List<ProductData> GetProductsByProducer(int producerId)
        {
            return _products.Where(p => p.ProducerId == producerId).ToList();
        }

        internal List<ProductData> GetProductsByBPM(int bpm)
        {
            return _products.Where(p => p.BPM == bpm).ToList();
        }

        internal List<ProductData> GetProductsByScale(string scale)
        {
            return _products.Where(p => p.Scale == scale).ToList();
        }

        
    }
}