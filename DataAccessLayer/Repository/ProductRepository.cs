using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ProductRepository : IProductDal
    {
        DataContext dc = new DataContext();
        public void AddProduct(Product product)
        {
            dc.Add(product);
            dc.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            dc.Remove(product);
            dc.SaveChanges();
        }

        public Product GetById(int id)
        {
            return dc.Products.Find(id);
        }

        public List<Product> ListAllProduct()
        {
            return dc.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
            dc.Update(product);
            dc.SaveChanges();
        }
    }
}
