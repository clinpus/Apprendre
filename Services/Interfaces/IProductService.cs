using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IProductService
    {

        public void AddProduct(Product product);
        public Product GetProduct(int id);
        public IEnumerable<Product> GetAllProduct();
    }
}
