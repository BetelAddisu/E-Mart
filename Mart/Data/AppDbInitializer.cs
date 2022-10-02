using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Mart.Models;
using Mart.Data.Enum;

namespace Mart.Data
{
    public class AppDbInitializer
    { 
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //CATEGORY
                if(!context.Categories.Any())
                {
                    context.Categories.AddRange(new List<Category>()
                    {
                        new Category()
                        {
                            Name = "Cloth",
                            Icon = "file://C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Cloth.jpg",
                        },
                        new Category()
                        {
                            Name = "Shoe",
                            Icon = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Shoe.png",
                        },
                         new Category()
                        {
                            Name = "Food",
                            Icon = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Food.png",
                        },
                        new Category()
                        {
                            Name = "Electronics",
                            Icon = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Electronics.jfif",
                        },
                        new Category()
                        {
                            Name = "Automobil",
                            Icon = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Automobil.webp",
                        },
                        new Category()
                        {
                            Name = "House",
                            Icon = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/House.jpg",
                        },
                    });
                    context.SaveChanges();

                }
                //COLOR
                if (!context.Colors.Any())
                {
                    context.Colors.AddRange(new List<Color>()
                    {
                        
                        new Color()
                        {
                            Name = "Black",
                            Picture = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Black.jpg"
                        },
                          new Color()
                        {
                            Name = "Red",
                            Picture = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Red.jpg"
                        },
                            new Color()
                        {
                            Name = "White",
                            Picture = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/White.jpg"
                        },
                        new Color()
                        {
                            Name = "Blue",
                            Picture = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Blue.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //ITEM
                if (!context.Items.Any())
                {
                    context.Items.AddRange(new List<Item>()
                    {
                        new Item()
                        {
                            Name = "Nike Golf",
                            Description = "This is the Nike Golf description",
                            Price = 39.50,
                            ImageURL = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Nike%20Golf.png",
                            ManufacturedDate = DateTime.Now.AddMonths(-20),
                            ProducerId = 2,
                            ItemCategory = ItemCategory.Shoe
                        },

                        new Item()
                        {
                            Name = "Mansion",
                            Description = "This is the Mansion description",
                            Price = 600000,
                            ImageURL = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Mansion.jpg",
                            ManufacturedDate = DateTime.Now.AddMonths(1),
                            ProducerId = 6,
                            ItemCategory = ItemCategory.House
                        },
                         new Item()
                        {
                            Name = "BodyCon Dress",
                            Description = "This is the BodyCon Dress description",
                            Price = 1000,
                            ImageURL = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/BodyCon%20Dress.jpg",
                            ManufacturedDate = DateTime.Now.AddMonths(12),
                            ProducerId = 1,
                            ItemCategory = ItemCategory.Clothing
                        },

                          new Item()
                        {
                            Name = "Samsung A51 ",
                            Description = "This is the Samsung A51 description",
                            Price = 600,
                            ImageURL = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Samsun%20Galaxy%20A51.webp",
                            ManufacturedDate = DateTime.Now.AddMonths(7),
                            ProducerId = 1,
                            ItemCategory = ItemCategory.Electronics
                        },
                              new Item()
                        {
                            Name = "Samsung A71 ",
                            Description = "This is the Samsung A71 description",
                            Price = 600,
                            ImageURL = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Samsun%20Galaxy%20A71.jpg",
                            ManufacturedDate = DateTime.Now.AddMonths(7),
                            ProducerId = 1,
                            ItemCategory = ItemCategory.Electronics
                        },

                                  new Item()
                        {
                            Name = "Iphon 14 ",
                            Description = "This is the Iphon 14 description",
                            Price = 13000,
                            ImageURL = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Iphone14.jpg",
                            ManufacturedDate = DateTime.Now.AddMonths(1),
                            ProducerId = 1,
                            ItemCategory = ItemCategory.Electronics
                        },
                            new Item()
                        {
                            Name = "Tesla x ",
                            Description = "This is the Tesla X description",
                            Price = 60000,
                            ImageURL = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Tesla%20X.jfif",
                            ManufacturedDate = DateTime.Now.AddMonths(20),
                            ProducerId = 1,
                            ItemCategory = ItemCategory.Automobile
                        },


                          new Item()
                        {
                            Name = "Air Force 1",
                            Description = "This is the Air Force 1 description",
                            Price = 99.50,
                            ImageURL = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Nike%20Air%20Force%201.jfif",
                            ManufacturedDate = DateTime.Now.AddMonths(-10),
                            ProducerId = 2,
                            ItemCategory = ItemCategory.Shoe
                        },

                          new Item()
                        {
                            Name = "SunChips",
                            Description = "This is the SunChips description",
                            Price = 50,
                            ImageURL = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/SunChips.jfif",
                            ManufacturedDate = DateTime.Now.AddMonths(-10),
                            ExprirationDate = DateTime.Now.AddMonths(1),
                            ProducerId = 2,
                            ItemCategory = ItemCategory.Food
                        }

                    });
                    context.SaveChanges();
                }
                //PRODUCER
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            Name = "Shein",
                            Bio = "This is the Bio of the Manufacrurer",
                            Picture = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Shein.png"
                        },
                        new Producer()
                        {
                            Name = "Nike",
                            Bio = "This is the Bio of the Manufacrurer",
                            Picture = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Nike.png"
                        },

                         new Producer()
                        {
                            Name = "Adidas",
                            Bio = "This is the Bio of the Manufacrurer",
                            Picture = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Adidas.jpg"
                        },
                        new Producer()
                        {
                            Name = "SunChips",
                            Bio = "This is the Bio of the Manufacrurer",
                            Picture = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Sunchipsjfif.jfif"
                        },
                        new Producer()
                        {
                            Name = "SamSung",
                            Bio = "This is the Bio of the Manufacrurer",
                            Picture = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Samsung.png"
                        },
                        new Producer()
                        {
                            Name = "Iphon",
                            Bio = "This is the Bio of the Manufacrurer",
                            Picture = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/iPhone.png"
                        },
                        new Producer()
                        {
                           Name = "Tesla",
                            Bio = "This is the Bio of the Manufacrurer",
                            Picture = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Tesla.png"
                        },
                        new Producer()
                        {
                           Name = "Toyota",
                            Bio = "This is the Bio of the Manufacrurer",
                            Picture = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/Toyota.png"
                        },
                        new Producer()
                        {
                            Name = "SunShin Real Estat",
                            Bio = "This is the Bio of the Manufacrurer",
                            Picture = "file:///C:/Users/betel/source/repos/Mart/Mart/wwwroot/Image/sunshinejpg.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //COLOR & ITEM
                if (!context.Colors_Items.Any())
                {
                    context.Colors_Items.AddRange(new List<Color_Item>()
                    {
                        new Color_Item()
                        {
                            ColorId = 1,
                            ItemId = 1
                        },
                        new Color_Item()
                        {
                            ColorId = 3,
                            ItemId = 1
                        },
                        new Color_Item()
                        {
                            ColorId = 2,
                            ItemId = 1
                        },
                        new Color_Item()
                        {
                            ColorId = 1,
                            ItemId = 2
                        },
                    new Color_Item()
                    {
                        ColorId = 5,
                        ItemId = 6
                    },
                    });
                context.SaveChanges();
            }

            }
                    
        }
    }
}
