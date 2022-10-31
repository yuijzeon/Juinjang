namespace ProductPrice.Core
{
    public class Product
    {
        public Product(int v1, string v2, int v3)
        {
            this.Id = v1;
            this.Name = v2;
            this.Price = v3;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}