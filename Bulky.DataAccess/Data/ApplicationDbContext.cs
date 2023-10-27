using BulkyBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //configuration needed, otherwise can't run if IdentityDbContext i used

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Comedy", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Drama", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Science Fiction", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Horror", DisplayOrder = 5 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Book Title 1",
                    Author = "Author 1",
                    Description = "Description of Book 1",
                    ISBN = "ISBN-111111",
                    ListPrice = 19.99,
                    Price = 14.99,
                    Price50 = 12.99,
                    Price100 = 9.99,
                    CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Title = "Book Title 2",
                    Author = "Author 2",
                    Description = "Description of Book 2",
                    ISBN = "ISBN-222222",
                    ListPrice = 24.99,
                    Price = 19.99,
                    Price50 = 16.99,
                    Price100 = 14.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Book Title 3",
                    Author = "Author 3",
                    Description = "Description of Book 3",
                    ISBN = "ISBN-333333",
                    ListPrice = 29.99,
                    Price = 22.99,
                    Price50 = 19.99,
                    Price100 = 17.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Book Title 4",
                    Author = "Author 4",
                    Description = "Description of Book 4",
                    ISBN = "ISBN-444444",
                    ListPrice = 14.99,
                    Price = 11.99,
                    Price50 = 9.99,
                    Price100 = 7.99,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Book Title 5",
                    Author = "Author 5",
                    Description = "Description of Book 5",
                    ISBN = "ISBN-555555",
                    ListPrice = 34.99,
                    Price = 29.99,
                    Price50 = 27.99,
                    Price100 = 24.99,
                    CategoryId = 1,
                    ImageUrl = ""
                }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Company A", StreetAddress = "123 Main St", City = "Anytown", State = "CA", PostalCode = "12345", PhoneNumber = "555-123-4567" },
                new Company { Id = 2, Name = "Company B", StreetAddress = "456 Elm St", City = "Another Town", State = "NY", PostalCode = "67890", PhoneNumber = "555-987-6543" },
                new Company { Id = 3, Name = "Company C", StreetAddress = "789 Oak St", City = "Smallville", State = "TX", PostalCode = "54321", PhoneNumber = "555-555-5555" },
                new Company { Id = 4, Name = "Company D", StreetAddress = "101 Pine St", City = "Suburbia", State = "FL", PostalCode = "98765", PhoneNumber = "555-321-7890" },
                new Company { Id = 5, Name = "Company E", StreetAddress = "202 Cedar St", City = "Metropolis", State = "IL", PostalCode = "23456", PhoneNumber = "555-654-9876" }
                );
        }
    }
}
