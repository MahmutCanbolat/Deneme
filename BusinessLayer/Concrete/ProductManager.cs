using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> GetList()
        {
            return _productDal.ListAllProduct();
        }

        public void ProductAdd(Product product)
        {
            _productDal.AddProduct(product);        
        }

        public void ProductDelete(Product product)
        {
            _productDal.DeleteProduct(product);
        }

        public void ProductUpdate(Product product)
        {
            _productDal.UpdateProduct(product);
        }
    }
}
