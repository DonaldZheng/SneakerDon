using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using theSneakerDon.Models;

namespace theSneakerDon.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<theSneakerDon.Models.Sneaker> Sneaker { get; set; }
        public DbSet<Sneaker> Sneakers
        {
            get; set;
        }
        public DbSet<Category> Categories
        {
            get; set;
        }
        public DbSet<ShoppingCartItem> ShoppingCartItems
        {
            get; set;
        }
        public DbSet<Order> Orders
        {
            get; set;
        }
        public DbSet<OrderDetail> OrderDetails
        {
            get; set;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Jordan 1" });
            builder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Jordan 3" });
            builder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Jordan 4" });
            builder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Jordan 6" });
            builder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Jordan 11" });

            builder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 1,
                Name = "Jordan 1",
                Price = 170,
                CategoryId = 1,
                ImageUrl = "\\Images\\Jordan1.jpg",
                ImageThumbnailUrl = "\\Images\\Jordan1.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            builder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 2,
                Name = "Jordan 3",
                Price = 220,
                CategoryId = 2,
                ImageUrl = "\\Images\\Jordan3.jpg",
                ImageThumbnailUrl = "\\Images\\Jordan3.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            builder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 3,
                Name = "Jordan 4",
                Price = 220,
                CategoryId = 3,
                ImageUrl = "\\Images\\jordan4.jpg",
                ImageThumbnailUrl = "\\Images\\jordan4.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            builder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 4,
                Name = "Jordan 6",
                Price = 250,
                CategoryId = 4,
                ImageUrl = "\\Images\\Jordan6.jpg",
                ImageThumbnailUrl = "\\Images\\Jordan6.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            builder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 5,
                Name = "Jordan 11",
                Price = 220,
                CategoryId = 5,
                ImageUrl = "\\Images\\Jordan11.jpg",
                ImageThumbnailUrl = "\\Images\\Jordan11.jpg",
                IsInStock = true,
                IsOnSale = false
            });
        }
    }
}
