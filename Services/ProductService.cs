using Domain;
using Infrastructure;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            // Logique métier : validation
            if (product.Price < 0)
            {
                throw new ArgumentException("Le prix ne peut pas être négatif.");
            }

            // Utilise le Repository pour l'accès aux données
            _productRepository.Add(product);
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _productRepository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return _productRepository.GetById(id);
        }
    }
}