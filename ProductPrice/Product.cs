namespace ProductPrice
{
    public class Product
    {
        public Product()
        { }

        public Product(string inputName, int price)
        {
            Name = inputName;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        internal void Rewrite(Product myProduct)
        {
            Id = myProduct.Id;
            Name = myProduct.Name;
            Price = myProduct.Price;
        }
    }
}