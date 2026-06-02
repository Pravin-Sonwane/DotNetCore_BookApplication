using BookApplication.Models;

namespace BookApplication.Repository
{
    public class BookRepository
    {

        public async Task<List<BookModel>> GetAllBooks()
        {
            // Since DataSource() returns a List<BookModel>, ToListAsync() is not available.
            // To simulate async behavior, use Task.FromResult.
            return await Task.FromResult(DataSource());
        }
        public async Task<BookModel> GetBookById(int id)
        {
            return await Task.FromResult(DataSource().Where(x => x.Id == id).FirstOrDefault());
        }
        public async Task<List<BookModel>> SerachBooks(string author, string title)
        {
            return await Task.FromResult(DataSource().Where(x => x.Author.Contains(author) && x.Title.Contains(title)).ToList());
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
             {
                new BookModel
                {
                    Id = 1,
                    Title = "The Art of Programming",
                    Author = "John Smith",
                    Description = "A comprehensive guide to programming concepts and best practices.",
                    Price = 100.00,
                    TotalPages = 350,
                    CreatedDate = DateTime.Now
                },
                new BookModel
                {
                    Id = 2,
                    Title = "Mastering C#",
                    Author = "David Johnson",
                    Description = "Learn C# from basics to advanced topics.",
                    Price = 19.99,
                    TotalPages = 200,
                    CreatedDate = DateTime.Now
                },
                new BookModel
                {
                    Id = 3,
                    Title = "ASP.NET Core Essentials",
                    Author = "Michael Brown",
                    Description = "Build modern web applications using ASP.NET Core.",
                    Price = 24.99,
                    TotalPages = 280,
                    CreatedDate = DateTime.Now
                },
                new BookModel
                {
                    Id = 4,
                    Title = "Database Design Fundamentals",
                    Author = "Sarah Wilson",
                    Description = "Understanding relational databases and normalization.",
                    Price = 21.50,
                    TotalPages = 250,
                    CreatedDate = DateTime.Now
                },
                new BookModel
                {
                    Id = 5,
                    Title = "Entity Framework Core",
                    Author = "Robert Davis",
                    Description = "A practical guide to data access with EF Core.",
                    Price = 27.99,
                    TotalPages = 320,
                    CreatedDate = DateTime.Now
                },
                new BookModel
                {
                    Id = 6,
                    Title = "Clean Code Principles",
                    Author = "Emily Taylor",
                    Description = "Writing maintainable and readable software.",
                    Price = 22.99,
                    TotalPages = 275,
                    CreatedDate = DateTime.Now
                },
                new BookModel
                {
                    Id = 7,
                    Title = "JavaScript for Beginners",
                    Author = "Chris Martin",
                    Description = "An introduction to JavaScript programming.",
                    Price = 18.99,
                    TotalPages = 190,
                    CreatedDate = DateTime.Now
                },
                new BookModel
                {
                    Id = 8,
                    Title = "Angular Development",
                    Author = "Jessica Lee",
                    Description = "Build powerful front-end applications with Angular.",
                    Price = 26.99,
                    TotalPages = 310,
                    CreatedDate = DateTime.Now
                },
                new BookModel
                {
                    Id = 9,
                    Title = "Microservices Architecture",
                    Author = "Daniel White",
                    Description = "Designing scalable and distributed systems.",
                    Price = 34.99,
                    TotalPages = 400,
                    CreatedDate = DateTime.Now
                },
                new BookModel
                {
                    Id = 10,
                    Title = "Cloud Computing Basics",
                    Author = "Sophia Green",
                    Description = "Introduction to cloud platforms and services.",
                    Price = 23.99,
                    TotalPages = 260,
                    CreatedDate = DateTime.Now
                }
};

        }
    }

}
