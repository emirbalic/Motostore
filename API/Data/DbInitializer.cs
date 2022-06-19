using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }

            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "BMW L1 Valve",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/images/products/moto1.jpg",
                    Brand = "BMW",
                    Type = "Motorcycle",
                    QuantityInStock = 10
                },
                new Product
                {
                    Name = "Yamaha Offroad Speedster",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/moto2.jpg",
                    Brand = "Yamaha",
                    Type = "Motorcycle",
                    QuantityInStock = 10
                },
                new Product
                {
                    Name = "KTM 790",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/moto3.jpg",
                    Brand = "KTM",
                    Type = "Motorcycle",
                    QuantityInStock = 7
                },
                new Product
                {
                    Name = "Yamaha Naked Custom",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/moto4.jpg",
                    Brand = "Yamaha",
                    Type = "Motorcycle",
                    QuantityInStock = 10
                },
                new Product
                {
                    Name = "Indian Cool Star",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/products/moto5.jpg",
                    Brand = "Indian",
                    Type = "Motorcycle",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Yamaha R1",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/moto6.jpg",
                    Brand = "Yamaha",
                    Type = "Motorcycle",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Elegant Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/gear1.jpg",
                    Brand = "Dainesse",
                    Type = "Gear",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mirror",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 800,
                    PictureUrl = "/images/products/gear2.jpg",
                    Brand = "Honda",
                    Type = "Gear",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Disc Wheal",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/gear3.jpg",
                    Brand = "Honda",
                    Type = "Gear",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Disc Wheal Steel",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "/images/products/gear4.jpg",
                    Brand = "Kawasaki",
                    Type = "Gear",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Speed meter vintage",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/gear5.jpg",
                    Brand = "BMW",
                    Type = "Gear",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Reservoir",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "/images/products/gear6.jpg",
                    Brand = "Harley-Davidson",
                    Type = "Gear",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Full face LS2",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "/images/products/helmet1.jpg",
                    Brand = "LS2",
                    Type = "Helmet",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Diesel Helmet",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/helmet2.jpg",
                    Brand = "Diesel",
                    Type = "Helmet",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Full face Racing",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "/images/products/helmet3.jpg",
                    Brand = "Yamaha",
                    Type = "Helmet",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nexx Helmet",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl = "/images/products/helmet4.jpg",
                    Brand = "Nolan",
                    Type = "Helmet",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Simpson Helmet",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 15000,
                    PictureUrl = "/images/products/helmet5.jpg",
                    Brand = "Simpson",
                    Type = "Helmet",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Shoei Blue Helmet",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/helmet6.jpg",
                    Brand = "Honda",
                    Type = "Helmet",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}