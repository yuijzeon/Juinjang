using ProductPrice.Core;

namespace ProductPrice.Database
{
    public class ProductEntity
    {
        public ProductEntity()
        { }

        public ProductEntity(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Price = product.Price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product ToModel()
        {
            return new Product(Id, Name, Price);
        }

        public void Update(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Price = product.Price;
        }
    }
}