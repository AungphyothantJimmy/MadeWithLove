using MadeWithLove.Data.Base;
using MadeWithLove.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace MadeWithLove.Models
{
    public class NewProductVM 
    {

        public int Id { get; set; }

        [Display(Name = "Proudct Name")]
        [Required(ErrorMessage = "Product name is required")]
        public string ProductName { get; set; }

        [Display(Name = "Proudct Description is required")]
        [Required(ErrorMessage = "Product description is required")]
        public string ProductDescription { get; set; }

        [Display(Name = "Proudct Price")]
        [Required(ErrorMessage = "Product Price is required")]
        public int ProductPrice {  get; set; }

        [Display(Name = "Proudct Image")]
        [Required(ErrorMessage = "ImageURL is required")]
        public string ImageURL {  get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Product category is required")]
        public ProductCategory ProductCategory { get; set; }

        public bool IsOnSale { get; set; }


    }
}
