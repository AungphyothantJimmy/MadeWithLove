using MadeWithLove.Data.Base;
using MadeWithLove.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace MadeWithLove.Models
{
    public class Product:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice {  get; set; }
        public string ImageURL {  get; set; }
        public ProductCategory ProductCategory { get; set; }
        public bool IsOnSale { get; set; }


    }
}
