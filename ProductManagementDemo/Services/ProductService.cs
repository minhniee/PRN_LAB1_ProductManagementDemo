using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        
        public ProductService()
        {
            _repository = new ProductRepository();
        }
        
        public void DeleteProduct(Product p)
        {
            _repository.DeleteProduct(p);
        }

        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public List<Product> GetProducts()
        {
            return _repository.GetProducts();
        }

        public void SaveProduct(Product p)
        {
            _repository.SaveProduct(p);
        }

        public void UpdateProduct(Product p)
        {
            _repository.UpdateProduct(p);
        }
    }
}
