using System.ComponentModel.DataAnnotations;

namespace ProductPrice.Database.Entity
{
    public class Product
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
    }
}