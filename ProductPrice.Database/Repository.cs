using System.Collections.Generic;
using System.Linq;
using ProductPrice.Core;

namespace ProductPrice.Database
{
    public class Repository : IRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            using (var db = new JuinjangContext())
            {
                return db.Products.ToList().Select(x => x.ToModel());
            }
        }

        public int Add(Product product)
        {
            using (var db = new JuinjangContext())
            {
                db.Products.Add(new ProductEntity(product));
                return db.SaveChanges();
            }
        }

        public int Remove(Product product)
        {
            using (var db = new JuinjangContext())
            {
                var productEntities = db.Products.Single(x => x.Id == product.Id);
                db.Products.Remove(productEntities);
                return db.SaveChanges();
            }
        }

        public int Update(Product product)
        {
            using (var db = new JuinjangContext())
            {
                var productEntities = db.Products.Single(x => x.Id == product.Id);
                productEntities.Update(product);
                return db.SaveChanges();
            }
        }
    }
}