using BookApplication.Models;
using BookApplication.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookApplication.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _bookRepository.GetAllBooks();
            return View(data);
        }
        public async Task<IActionResult> GetAllBooks()
        {
            var data = await _bookRepository.GetAllBooks();
            return View(data);
        }
        public async Task<IActionResult> Details(int id)
        {
            var data = await _bookRepository.GetBookById(id);
            return View(data);
        }
        public async Task<List<BookModel>> SerachBooks(string author, string title)
        {
            var data = await _bookRepository.SerachBooks(author, title);
            return data;
        }

    }
}
