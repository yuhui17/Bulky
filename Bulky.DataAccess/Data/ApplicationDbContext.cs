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
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //configuration needed, otherwise can't run if IdentityDbContext i used

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Action", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Action", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Action", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Action", DisplayOrder = 5 }
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
        }
    }
}
