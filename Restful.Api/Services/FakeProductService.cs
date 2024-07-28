using Restful.Api.Models;

namespace Restful.Api.Services
{
    public class FakeProductService : IProductService  // Fake Product service
    {
        private readonly List<Product> _products;

        public FakeProductService()
        {
            _products = new List<Product>
        {
            new Product { Id = 1, Name = "Product1", Price = 100 },
            new Product { Id = 2, Name = "Product2", Price = 200 }
        };
        }

        public IEnumerable<Product> GetProducts() => _products;

        public Product GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public void AddProduct(Product product) => _products.Add(product);

        public void UpdateProduct(Product product)
        {
            var existingProduct = GetProductById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
            }
        }

        public void DeleteProduct(int id) => _products.RemoveAll(p => p.Id == id);
    }
}
