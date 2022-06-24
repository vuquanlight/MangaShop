using MangaShopSolution.Data.Entities;
using MangaShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MangaShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of MangaShopSolution" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of MangaShopSolution" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of MangaShopSolution" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = false },
                new Language() { Id = "en", Name = "English", IsDefault = true });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Figure", LanguageId = "en", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },
                  
                  new CategoryTranslation() { Id = 2, CategoryId = 2, Name = "Clothing", LanguageId = "en", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }
                    );

            modelBuilder.Entity<Product>().HasData(
                  new Product()
                  {
                      Id = 1,
                      DateCreated = DateTime.Now,
                      OriginalPrice = 100000,
                      Price = 200000,
                      Stock = 0,
                      ViewCount = 0,
                  },
                  new Product()
                  {
                      Id = 2,
                      DateCreated = DateTime.Now,
                      OriginalPrice = 100000,
                      Price = 200000,
                      Stock = 0,
                      ViewCount = 0,
                  },
                   new Product()
                  {
                      Id = 3,
                      DateCreated = DateTime.Now,
                      OriginalPrice = 100000,
                      Price = 200000,
                      Stock = 0,
                      ViewCount = 0,
                  },
                   new Product()
                   {
                       Id = 4,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },
                   new Product()
                   {
                       Id = 5,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },
                   new Product()
                   {
                       Id = 6,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },
                   new Product()
                   {
                       Id = 7,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },
                   
                   new Product()
                   {
                       Id = 8,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },
                   new Product()
                   {
                       Id = 9,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },
                   new Product()
                   {
                       Id = 10,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },
                   new Product()
                   {
                       Id = 11,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },
                   new Product()
                   {
                       Id = 12,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },
                   new Product()
                   {
                       Id = 13,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },
                   new Product()
                   {
                       Id = 14,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },
                   new Product()
                   {
                       Id = 15,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },
                   new Product()
                   {
                       Id = 16,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },                   
                   new Product()
                   {
                       Id = 17,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   },
                   new Product()
                   {
                       Id = 18,
                       DateCreated = DateTime.Now,
                       OriginalPrice = 100000,
                       Price = 200000,
                       Stock = 0,
                       ViewCount = 0,
                   }
                  
                  );

            modelBuilder.Entity<ProductTranslation>().HasData(

                    new ProductTranslation()
                    {
                        Id = 1,
                        ProductId = 1,
                        Name = "Chopper",
                        LanguageId = "en",
                        SeoAlias = "chopper"

                    }, new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 2,
                        Name = "Kid",
                        LanguageId = "en",
                        SeoAlias = "kid",
                    }, new ProductTranslation()
                    {
                        Id = 3,
                        ProductId = 3,
                        Name = "Aokiji",
                        LanguageId = "en",
                        SeoAlias = "Aokiji"

                    }, new ProductTranslation()
                    {
                        Id = 4,
                        ProductId = 4,
                        Name = "Akainu",
                        LanguageId = "en",
                        SeoAlias = "Akainu"
                    }, new ProductTranslation()
                    {
                        Id = 5,
                        ProductId = 5,
                        Name = "Kizaru",
                        LanguageId = "en",
                        SeoAlias = "kizaru"
                    }, new ProductTranslation()
                    {
                        Id = 6,
                        ProductId = 6,
                        Name = "Sengoku",
                        LanguageId = "en",
                        SeoAlias = "Sengoku"
                    }, new ProductTranslation()
                    {
                        Id = 7,
                        ProductId = 7,
                        Name = "Ace",
                        LanguageId = "en",
                        SeoAlias = "Ace"
                    }, new ProductTranslation()
                    {
                        Id = 8,
                        ProductId = 8,
                        Name = "Nami",
                        LanguageId = "en",
                        SeoAlias = "Nami"
                    }, new ProductTranslation()
                    {
                        Id = 9,
                        ProductId = 9,
                        Name = "Robin",
                        LanguageId = "en",
                        SeoAlias = "Robin"
                    }, new ProductTranslation()
                    {
                        Id = 10,
                        ProductId = 10,
                        Name = "Luffy",
                        LanguageId = "en",
                        SeoAlias = "Luffy"


                    }, new ProductTranslation()
                    {
                        Id = 11,
                        ProductId = 11,
                        Name = "Zoro",
                        LanguageId = "en",
                        SeoAlias = "Zoro"


                    }, new ProductTranslation()
                    {
                        Id = 12,
                        ProductId = 12,
                        Name = "Mihawk",
                        LanguageId = "en",
                        SeoAlias = "Mihawk"


                    }, new ProductTranslation()
                    {
                        Id = 13,
                        ProductId = 13,
                        Name = "Wano Shirt",
                        LanguageId = "en",
                        SeoAlias = "wano-shirt"


                    }, new ProductTranslation()
                    {
                        Id = 14,
                        ProductId = 14,
                        Name = "Shirahoshi Shirt",
                        LanguageId = "en",
                        SeoAlias = "shirahoshi-shirt"


                    }, new ProductTranslation()
                    {
                        Id = 15,
                        ProductId = 15,
                        Name = "White Shirt",
                        LanguageId = "en",
                        SeoAlias = "white-shirt"


                    }, new ProductTranslation()
                    {
                        Id = 16,
                        ProductId = 16,
                        Name = "Garrison Regiment Hoodie",
                        LanguageId = "en",
                        SeoAlias = "Garrison-Regiment-Hoodie"


                    }, new ProductTranslation()
                    {
                        Id = 17,
                        ProductId = 17,
                        Name = "Military Police Hoodie",
                        LanguageId = "en",
                        SeoAlias = "Military-Police-Hoodie"


                    }, new ProductTranslation()
                    {
                        Id = 18,
                        ProductId = 18,
                        Name = "Scouting Legion Hoodie",
                        LanguageId = "en",
                        SeoAlias = "Scouting-Legion-Hoodie"


                    });




            modelBuilder.Entity<ProductImage>().HasData(
          new ProductImage()
          {
              Id = 1,
              ProductId = 1,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/choper.jpg"
          },
          new ProductImage()
          {
              Id = 2,
              ProductId = 2,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/kid.jpg"
          },
          new ProductImage()
          {
              Id = 3,
              ProductId = 3,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/aokiji.jpeg"
          },
          new ProductImage()
          {
              Id = 4,
              ProductId = 4,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/akainu.jpg"
          },
          new ProductImage()
          {
              Id = 5,
              ProductId = 5,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/kizaru.jpg"
          },
          new ProductImage()
          {
              Id = 6,
              ProductId = 6,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/sengoku.jpg"
          },
          new ProductImage()
          {
              Id = 7,
              ProductId = 7,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/ace.jpg"
          },
          new ProductImage()
          {
              Id = 8,
              ProductId = 8,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/nami.jpg"
          },
          new ProductImage()
          {
              Id = 9,
              ProductId = 9,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/robin.jpg"
          },
          new ProductImage()
          {
              Id = 10,
              ProductId = 10,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/luffy.jpg"
          },
          new ProductImage()
          {
              Id = 11,
              ProductId = 11,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/zoro.jpg"
          },
          new ProductImage()
          {
              Id = 12,
              ProductId = 12,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/mihawk.jpg"
          },
          new ProductImage()
          {
              Id = 13,
              ProductId = 13,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/wano shirt.png"
          },
          new ProductImage()
          {
              Id = 14,
              ProductId = 14,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/shira.jpg"
          },
          new ProductImage()
          {
              Id = 15,
              ProductId = 15,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/white shirt.png"
          },
          new ProductImage()
          {
              Id = 16,
              ProductId = 16,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/garrison regiment.jpg"
          },
          new ProductImage()
          {
              Id = 17,
              ProductId = 17,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/military police.png"
          },
          new ProductImage()
          {
              Id = 18,
              ProductId = 18,
              DateCreated = DateTime.Now,
              IsDefault = true,
              ImagePath = "/images/scouting legion.jpg"
          }
          );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 },
                new ProductInCategory() { ProductId = 2, CategoryId = 1 },
                new ProductInCategory() { ProductId = 3, CategoryId = 1 },
                new ProductInCategory() { ProductId = 4, CategoryId = 1 },
                new ProductInCategory() { ProductId = 5, CategoryId = 1 },
                new ProductInCategory() { ProductId = 6, CategoryId = 1 },
                new ProductInCategory() { ProductId = 7, CategoryId = 1 },
                new ProductInCategory() { ProductId = 8, CategoryId = 1 },
                new ProductInCategory() { ProductId = 9, CategoryId = 1 },
                new ProductInCategory() { ProductId = 10, CategoryId = 1 },
                new ProductInCategory() { ProductId = 11, CategoryId = 1 },
                new ProductInCategory() { ProductId = 12, CategoryId = 1 },
                new ProductInCategory() { ProductId = 13, CategoryId = 2 },
                new ProductInCategory() { ProductId = 14, CategoryId = 2 },
                new ProductInCategory() { ProductId = 15, CategoryId = 2 },
                new ProductInCategory() { ProductId = 16, CategoryId = 2 },
                new ProductInCategory() { ProductId = 17, CategoryId = 2 },
                new ProductInCategory() { ProductId = 18, CategoryId = 2 }
                );

            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "tedu.international@gmail.com",
                NormalizedEmail = "tedu.international@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Toan",
                LastName = "Bach",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<Slide>().HasData(
              new Slide() { Id = 1, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 1, Url = "#", Image = "/themes/images/carousel/1.png", Status = Status.Active },
              new Slide() { Id = 2, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 2, Url = "#", Image = "/themes/images/carousel/2.png", Status = Status.Active },
              new Slide() { Id = 3, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 3, Url = "#", Image = "/themes/images/carousel/3.png", Status = Status.Active },
              new Slide() { Id = 4, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 4, Url = "#", Image = "/themes/images/carousel/4.png", Status = Status.Active },
              new Slide() { Id = 5, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 5, Url = "#", Image = "/themes/images/carousel/5.png", Status = Status.Active },
              new Slide() { Id = 6, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 6, Url = "#", Image = "/themes/images/carousel/6.png", Status = Status.Active }
              );
        }
    }
}