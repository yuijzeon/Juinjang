using System.Collections.Generic;

namespace ProductPrice.Core
{
    public interface IRepository
    {
        IEnumerable<Product> GetProducts();
        int Add(Product product);
        int Remove(Product product);
        int Update(Product product);
    }
}