using System.ComponentModel.DataAnnotations;

namespace MadeWithLove.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ImageURL {  get; set; }
        public ProductCategory ProductCategory { get; set; }

    }
}
