using Domain;

namespace Infrastructure
{
    public class ProductRepository: IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}