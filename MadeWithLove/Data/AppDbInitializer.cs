using MadeWithLove.Data.Enum;
using MadeWithLove.Models;

namespace MadeWithLove.Data
{
    public class AppDbInitializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                // Making ensure that DB is alr created.i.e. if there is no data in DB, the following data will be added.
                context.Database.EnsureCreated();

                //Products
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            ProductName = "TestItem1",
                            ProductDescription = "This is the description of TestItem1",
                            ImageURL = "https://www.mytheresa.com/media/1094/1238/100/6e/P01012407.jpg",
                            ProductCategory = ProductCategory.Clothings
                        },

                        new Product()
                        {
                            ProductName = "TestItem2",
                            ProductDescription = "This is the description of TestItem2",
                            ImageURL = "https://d3vfig6e0r0snz.cloudfront.net/rcYjnYuenaTH5vyDF/images/products/ce6327ee0687139d93608e6ac31d2a1c.webp",
                            ProductCategory = ProductCategory.Clothings,
                            IsOnSale = true,
                        },

                        new Product()
                        {
                            ProductName = "TestItem3",
                            ProductDescription = "This is the description of TestItem3",
                            ImageURL = "https://d3vfig6e0r0snz.cloudfront.net/rcYjnYuenaTH5vyDF/images/products/6cd1d9603bdc20e73fc2ddb786051490.webp",
                            ProductCategory = ProductCategory.Clothings
                        },

                        new Product()
                        {
                            ProductName = "TestItem4",
                            ProductDescription = "This is the description of TestItem4",
                            ImageURL = "https://eu.astridandmiyu.com/cdn/shop/collections/AM25-Q1PB-N-TEN-HRT-G_3.webp?v=1741278792",
                            ProductCategory = ProductCategory.Accessories
                        },

                        new Product()
                        {
                            ProductName = "TestItem5",
                            ProductDescription = "This is the description of TestItem5",
                            ImageURL = "https://i.ebayimg.com/images/g/UroAAOSwYxBaAlyu/s-l1200.jpg",
                            ProductCategory = ProductCategory.Accessories
                        },

                        new Product()
                        {
                            ProductName = "TestItem6",
                            ProductDescription = "This is the description of TestItem6",
                            ImageURL = "https://thesilverstore.com.au/cdn/shop/files/engrvaed-gold-bar-barcelet.jpg?v=1713750486",
                            ProductCategory = ProductCategory.Accessories,
                            IsOnSale= true
                        },

                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
