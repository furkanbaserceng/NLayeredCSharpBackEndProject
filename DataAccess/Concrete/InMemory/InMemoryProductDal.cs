using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> { 
            
                new Product{ProductId=1,CategoryId=1,ProductName="Laptop",UnitPrice=5000,UnitsInStock=1000},
                new Product{ProductId=2,CategoryId=1,ProductName="Mouse",UnitPrice=65,UnitsInStock=200},
                new Product{ProductId=3,CategoryId=2,ProductName="Keyboard",UnitPrice=120,UnitsInStock=375},
                new Product{ProductId=4,CategoryId=1,ProductName="Camera",UnitPrice=200,UnitsInStock=620},
                new Product{ProductId=5,CategoryId=3,ProductName="Smart Phone",UnitPrice=12000,UnitsInStock=300},
            
             };
        }



        public List<Product> GetAll()
        {
            return _products;
        }


        public void Add(Product product)
        {
            _products.Add(product);  //List<> in Add hazır metodu ile listeye eleman ekledik.
        }

        public void Update(Product product)
        {
            Product productToUpdate=_products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
                
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);


        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
