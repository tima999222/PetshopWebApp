using PetshopWebApp.Models;

namespace PetshopWebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PetshopContext context)
        {
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Categories[]
            {
                new Categories{CategoryName="Feeds"},
                new Categories{CategoryName="Toys"}
            };
            context.AddRange(categories);
            context.SaveChanges();


            var products = new Products[]
            {
                new Products{ProductName="Royal Canin for cats", Price=5000, CategoryId=1},
                new Products{ProductName="Feed for the dogs", Price=4000, CategoryId=1},
                new Products{ProductName="Ball", Price=300, CategoryId=2}
            };
            context.AddRange(products);
            context.SaveChanges();
        }

    }
}
