using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrderApplicationServer.Web.Data.Models;

namespace OrderApplicationServer.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relations
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderPosition>()
                .HasKey(o => new { o.OrderId, o.OrderPositionId });

            modelBuilder.Entity<Order>()
                .HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId);

            // Disable On Delete Cascade
            modelBuilder.Entity<Order>()
                .HasOne(u => u.User)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderPosition>()
                .HasOne(u => u.Product)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            // Seed Users
            var user1 = new ApplicationUser()
            {
                Id = "435dbe81-22b1-4479-bea2-d730a7750aa1",
                FName = "Danny",
                LName = "Devito",
                UserName = "ddevito",
                NormalizedUserName = "DDEVITO",
                Email = "ddevito@gmail.com",
                NormalizedEmail = "DDEVITO@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "+1111111111",
                PhoneNumberConfirmed = true,
                Created = DateTime.Now
            };
            var user2 = new ApplicationUser()
            {
                Id = "z65dbe81-22b1-4479-j58g-d730ap050aa1",
                FName = "Bernd",
                LName = "Brot",
                UserName = "bbrot",
                NormalizedUserName = "BBROT",
                Email = "bbrot@gmail.com",
                NormalizedEmail = "BBROT@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "+222222222",
                PhoneNumberConfirmed = true,
                Created = DateTime.Now
            };

            // Generate password hashes
            var hasher = new PasswordHasher<ApplicationUser>();
            user1.PasswordHash = hasher.HashPassword(user1, "#Q^2BQD2Mj9Y");
            user2.PasswordHash = hasher.HashPassword(user2, "#Q^2BQD2Mj9Y");

            modelBuilder.Entity<ApplicationUser>().HasData(user1);
            modelBuilder.Entity<ApplicationUser>().HasData(user2);

            // Seed Roles
            var role1 = new IdentityRole()
            {
                Id = "rrrrrrrr-22b1-4479-j58g-rrrrrrrr",
                Name = "User",
                NormalizedName = "USER"
            };

            var role2 = new IdentityRole()
            {
                Id = "rrrrrrrr-l0w6-hhhh-jf84-rrrrrrrr",
                Name = "Admin",
                NormalizedName = "ADMIN"
            };

            modelBuilder.Entity<IdentityRole>().HasData(role1);
            modelBuilder.Entity<IdentityRole>().HasData(role2);

            // Seed UserRoles
            var userRole1 = new IdentityUserRole<string>()
            {
                RoleId = "rrrrrrrr-22b1-4479-j58g-rrrrrrrr",
                UserId = "435dbe81-22b1-4479-bea2-d730a7750aa1"
            };

            var userRole2 = new IdentityUserRole<string>()
            {
                RoleId = "rrrrrrrr-l0w6-hhhh-jf84-rrrrrrrr",
                UserId = "z65dbe81-22b1-4479-j58g-d730ap050aa1"
            };

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRole1);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRole2);

            // Seed Products
            var product1 = new Product { ProductId = 1, Title = "Very Far Away Horse for GAMECUBE", Price = 69.99m, ImgPath = "/Images/img1.jpg" };
            var product2 = new Product { ProductId = 2, Title = "Funeral Kazoo", Price = 9.99m, ImgPath = "/Images/img2.jpg" };
            var product3 = new Product { ProductId = 3, Title = "Muppet Screams", Price = 14.99m, ImgPath = "/Images/img3.jpg" };
            var product4 = new Product { ProductId = 4, Title = "Pre-Cracked Egg", Price = 2.50m, ImgPath = "/Images/img4.jpg" };
            var product5 = new Product { ProductId = 5, Title = "Shaq O'Neal's Pregnancy Test", Price = 12m, ImgPath = "/Images/img5.jpg" };
            var product6 = new Product { ProductId = 6, Title = "Defenetry-Not SNOOPY", Price = 4.99m, ImgPath = "/Images/img6.jpg" };
            var product7 = new Product { ProductId = 7, Title = "Weird Dogs", Price = 4.99m, ImgPath = "/Images/img7.jpg" };

            modelBuilder.Entity<Product>().HasData(product1);
            modelBuilder.Entity<Product>().HasData(product2);
            modelBuilder.Entity<Product>().HasData(product3);
            modelBuilder.Entity<Product>().HasData(product4);
            modelBuilder.Entity<Product>().HasData(product5);
            modelBuilder.Entity<Product>().HasData(product6);
            modelBuilder.Entity<Product>().HasData(product7);

            // Seed ProductProperties
            var prodprop1 = new ProductProperty { ProductPropertyId = 1, Title = "Food", Notes = "Food, Snacks including Drinks" };
            var prodprop2 = new ProductProperty { ProductPropertyId = 2, Title = "Game", Notes = "Video Games" };
            var prodprop3 = new ProductProperty { ProductPropertyId = 3, Title = "Consumable", Notes = "Item can be consumed" };
            var prodprop4 = new ProductProperty { ProductPropertyId = 4, Title = "Toy", Notes = "Toy Figure" };
            var prodprop5 = new ProductProperty { ProductPropertyId = 5, Title = "Utility", Notes = "Item can be used" };

            modelBuilder.Entity<ProductProperty>().HasData(prodprop1);
            modelBuilder.Entity<ProductProperty>().HasData(prodprop2);
            modelBuilder.Entity<ProductProperty>().HasData(prodprop3);
            modelBuilder.Entity<ProductProperty>().HasData(prodprop4);
            modelBuilder.Entity<ProductProperty>().HasData(prodprop5);

            // Seed Orders
            var order1 = new Order { OrderId = 1, OrderDate = DateTime.Now, UserId = "z65dbe81-22b1-4479-j58g-d730ap050aa1", };
            var order2 = new Order { OrderId = 2, OrderDate = DateTime.Now, UserId = "435dbe81-22b1-4479-bea2-d730a7750aa1", };
            var order3 = new Order { OrderId = 3, OrderDate = DateTime.Now, UserId = "z65dbe81-22b1-4479-j58g-d730ap050aa1", };
            var order4 = new Order { OrderId = 4, OrderDate = DateTime.Now, UserId = "z65dbe81-22b1-4479-j58g-d730ap050aa1", };
            var order5 = new Order { OrderId = 5, OrderDate = DateTime.Now, UserId = "435dbe81-22b1-4479-bea2-d730a7750aa1", };
            var order6 = new Order { OrderId = 6, OrderDate = DateTime.Now, UserId = "435dbe81-22b1-4479-bea2-d730a7750aa1", };

            modelBuilder.Entity<Order>().HasData(order1);
            modelBuilder.Entity<Order>().HasData(order2);
            modelBuilder.Entity<Order>().HasData(order3);
            modelBuilder.Entity<Order>().HasData(order4);
            modelBuilder.Entity<Order>().HasData(order5);
            modelBuilder.Entity<Order>().HasData(order6);

            // Seed orderpositions
            for (int i = 1; i < 12; i++)
            {
                int orderid = 1;

                if (i % 2 == 0)
                {
                    orderid++;
                }

                modelBuilder.Entity<OrderPosition>()
                    .HasData(new OrderPosition
                    {
                        OrderId = orderid,
                        OrderPositionId = i,
                        ProductId = orderid,
                        Amount = 10,
                        Price = 12
                    });
            }
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderPosition> OrderPosition { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductProperty> ProductProperties { get; set; }
    }
}