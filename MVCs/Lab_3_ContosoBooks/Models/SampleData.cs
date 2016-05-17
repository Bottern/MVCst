using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Lab_3_ContosoBooks.Models
{
    public class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var ctx = serviceProvider.GetService<ApplicationDbContext>();
            ctx.Database.Migrate();
            if (!ctx.Book.Any())
            {
                var austen = ctx.Author.Add(new Author() {LastName = "Austen", FirstMidName = "Jane"}).Entity;
                var dickens = ctx.Author.Add(new Author() {LastName = "Dickens", FirstMidName = "Charles"}).Entity;
                var cervantes = ctx.Author.Add(new Author() {LastName = "Cervantes", FirstMidName = "Miguel"}).Entity;

                ctx.Book.AddRange(new Book()
                {
                    Title = "Pride & Prejudice", Year = 1813, Author = austen,Price = 9.99M, Genre = "Comedy of manners"
                },
                new Book()
                {
                    Title = "Northanger Abbey", Year = 1817, Author = austen, Price = 12.95M, Genre = "Gothic parody"
                },
                new Book()
                {
                    Title = "David Copperfield", Year = 1850, Author = dickens, Price = 15, Genre = "Bildungsroman"
                },
                new Book()
                {
                    Title = "Don Quixote", Year = 1617, Author = cervantes, Price = 8.95M, Genre = "Picaresque"
                }
                );
                ctx.SaveChanges();
            }
        }
    }
}
