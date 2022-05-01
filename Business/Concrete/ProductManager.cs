using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        public IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;

        }


        public List<Product> GetAll()
        {
            //business roller yazılır.örneğin yetkisi var mı vs.


            return _productDal.GetAll(); //şuan iş kodlarından iflerden geçtiği varsayılıyor.
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
